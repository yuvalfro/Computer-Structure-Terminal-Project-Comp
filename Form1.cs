using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace TerminalPC
{
    public partial class Form1 : Form
    {
        public static SerialPort port;
        Boolean firstConnection = true;
        public static Parity parityTemp;
        public static StopBits stopbitsTemp;
        public static string comTemp;
        public static int baudTemp;
        
        public Form1()
        {
            InitializeComponent();
            comboBoxBaud.SelectedIndex = 1;
            comboBoxCOM.SelectedIndex = 0;
            comboBoxParity.SelectedIndex = 0;
            comboBoxSTPBIT.SelectedIndex = 0;
            
        }

        //Open command mode window
        private void ButtonCommandsMode_Click(object sender, EventArgs e)
        {
            FormCommands fc = new FormCommands();
            fc.ShowDialog();
            
        }

        private void ComboBoxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Connect + update parameters
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (firstConnection)//if its the first connection we need the default pramas, else we notify the MP about change in the params and then we change
            {
                port = new SerialPort(comboBoxCOM.SelectedItem.ToString(),
                                     9600,
                                     Parity.None,
                                     8,
                                     StopBits.One);
                firstConnection = false;
            }

            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                parityTemp = (Parity)comboBoxParity.SelectedIndex;
                stopbitsTemp = (StopBits)(comboBoxSTPBIT.SelectedIndex+1);
                comTemp = comboBoxCOM.SelectedItem.ToString();
                baudTemp = int.Parse(comboBoxBaud.SelectedItem.ToString());
               

                port.Write("ConnectionParams"+ " "+
                           comboBoxBaud.SelectedItem.ToString()+" "+
                           comboBoxParity.SelectedItem.ToString()+" "+
                           comboBoxSTPBIT.SelectedItem.ToString()+"\r\n");

             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Data recieved event
        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            System.Threading.Thread.Sleep(500);
            string indata;
            if (!port.IsOpen)
            {
                port.Open();
            }
            while ((indata = sp.ReadLine()) == "\0") ;

            if (indata.Equals("ack"))
            {
                MessageBox.Show("Request Recieved");
                try
                {
                    port.Close();
                    port = new SerialPort(comTemp,
                           baudTemp,
                           parityTemp,
                           8,
                           stopbitsTemp);
                    port.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("Connection Failed: "+ indata);
        }

        //Open chat mode window
        private void ButtonChat_Click(object sender, EventArgs e)
        {
            FormChat fc = new FormChat();
            fc.ShowDialog();
        }

        ////Open file transfer window
        private void ButtonFile_Click(object sender, EventArgs e)
        {
            FormFileTransfer ft = new FormFileTransfer();
            ft.ShowDialog();
        }
    }   
}
