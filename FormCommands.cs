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
    public partial class FormCommands : Form
    {
        public FormCommands()
        {
            InitializeComponent();
            this.richTextBox1.Text = "Hello User";
            
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          if(e.KeyChar == (char)Keys.Enter)
            {
                richTextBox1.Text += "\n" + textBox1.Text;
                try
                {
                    if (!Form1.port.IsOpen)
                    {
                        Form1.port.Open();
                    }
                    Form1.port.Write(textBox1.Text+"\r\n");
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
