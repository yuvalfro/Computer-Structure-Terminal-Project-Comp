using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace TerminalPC
{
    public partial class FormFileTransfer : Form
    {
        public static string file = "";
        public static bool waitingForFile = false;
        public static string fileName;
        public static int sendingMode=0;
        public System.Timers.Timer timer;
        public FormFileTransfer()
        {
            InitializeComponent();
            Form1.port.DataReceived += new SerialDataReceivedEventHandler(port_File_DataReceived);
        }
        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            sendingMode = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Choose File");
            }
            else
            {
                FileInfo f = new FileInfo(textBox1.Text);
                string fname = f.Name;              // file name: fileX.txt
                long s1 = f.Length;                 // file size in bytes
                StreamReader sr = new StreamReader(textBox1.Text);
                try
                {
                    file = sr.ReadToEnd();          //translate file to string
                    if (!Form1.port.IsOpen)
                    {
                        Form1.port.Open();
                    }
                    
                    Form1.port.Write("filer "+fname+ " "+s1.ToString()+"\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void port_File_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata="";
            //char inchar;
            //while ((indata = sp.ReadLine()) == "\0") ;
            if (waitingForFile)
            {
                waitingForFile = false;
                indata = ((char)Form1.port.ReadChar()).ToString();//check
                while (!(indata.EndsWith("|")))
                {
                    indata += ((char)Form1.port.ReadChar()).ToString();
                }
                indata = indata.Substring(0, indata.Length - 1);
                File.WriteAllText(@"C:\Users\Yuval Froman\Desktop\Terminal\Recieved files\" + fileName, indata);
            }
            else
            {
                indata = sp.ReadLine();
                if (indata.Equals("ack"))
                {
                    if (sendingMode == 0) { //normal sending
                        try
                        {
                            if (!Form1.port.IsOpen)
                            {
                                Form1.port.Open();
                            }
                            Form1.port.Write(file);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    if (sendingMode == 1)//sending with timer
                    {
                        timer = new System.Timers.Timer(1);
                        timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Tick);
                        timer.Enabled = true;
                        timer.Start();
                    }
                }
                else
                {
                    if (indata.StartsWith("filename"))
                    {
                        fileName = indata.Substring(9, indata.Length - 9);
                        //string path = @"C:\Users\Yuval Froman\Desktop\Terminal\Recieved files\"+ fileName;
                        //File.Create(path);
                  
                        waitingForFile = true;
                        try
                        {
                            if (!Form1.port.IsOpen)
                            {
                                Form1.port.Open();
                            }
                            Form1.port.Write("ackfile\n");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    else
                        MessageBox.Show("Ack Failed: " + indata);
                }
            }
        }

        private void FormFileTransfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!Form1.port.IsOpen)
                {
                    Form1.port.Open();
                }
                Form1.port.Write("FilesExit\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Form1.port.DataReceived -= port_File_DataReceived;
        }

        private void ButtonFilesLCD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Form1.port.IsOpen)
                {
                    Form1.port.Open();
                }
                Form1.port.Write("FilesLCD\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Form1.port.Close();
        }

        private void Button_SendTimer_Click(object sender, EventArgs e)
        {
            sendingMode = 1;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Choose File");
            }
            else
            {
                FileInfo f = new FileInfo(textBox1.Text);
                string fname = f.Name;              // file name: fileX.txt
                long s1 = f.Length;                 // file size in bytes
                StreamReader sr = new StreamReader(textBox1.Text);
                try
                {
                    file = sr.ReadToEnd();          //translate file to string
                    if (!Form1.port.IsOpen)
                    {
                        Form1.port.Open();
                    }

                    Form1.port.Write("filer " + fname + " " + s1.ToString() + "\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        int i = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (i < file.Length)
            {
                try
                {
                    if (!Form1.port.IsOpen)
                    {
                        Form1.port.Open();
                    }
                    Form1.port.Write(file[i].ToString());
                    i++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                timer.Stop();
                i = 0;
            }
        }
    }
}
