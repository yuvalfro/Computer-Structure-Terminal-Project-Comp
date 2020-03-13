using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalPC
{
    public partial class FormChat : Form
    {
        public FormChat()
        {
            InitializeComponent();
            this.richTextBox1.Text = "Hello User\n You can send up to 32 chars.\n Press Enter to send, look at the LCD (:\n ";
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                richTextBox1.Text += "\n"+"["+ DateTime.Now+"]: " + textBox1.Text;
                try
                {
                    if (!Form1.port.IsOpen)
                    {
                        Form1.port.Open();
                    }
                    if(textBox1.Text.StartsWith("\r\n"))
                        Form1.port.Write("msg " + textBox1.Text.Substring(2) + "\r\n");
                    else
                        Form1.port.Write("msg " + textBox1.Text + "\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                Form1.port.Close();
                textBox1.Text = "";
            } 
        }
    }
}
