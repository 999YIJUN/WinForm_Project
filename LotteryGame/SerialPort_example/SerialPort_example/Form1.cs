using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPort_example
{
    public partial class FrmMain : Form
    {
        string[] Ports = SerialPort.GetPortNames();
        SerialPort m_serialPort;
        private delegate void invokeDelegate();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach(var item in Ports)
            {
                cboPortName.Items.Add(item);
            }
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Comport_Start(cboPortName.Text))
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Comport_Stop();
        }

        private bool Comport_Start(string sPortName)
        {
            try
            {
                if(m_serialPort == null)
                {
                    m_serialPort = new SerialPort();

                    m_serialPort.PortName = sPortName;
                    m_serialPort.BaudRate = 9600;
                    m_serialPort.Parity = Parity.None;
                    m_serialPort.DataBits = 8;
                    m_serialPort.StopBits = StopBits.One;

                    m_serialPort.DataReceived += DataReceiver;
                }

                m_serialPort.Open();
                SetMsg(string.Format("{0} Port Start...\r\n", sPortName));

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void Comport_Stop()
        {
            //m_serialPort.DataReceived -= DataReceiver;
            m_serialPort.Close();
            SetMsg(string.Format("{0} Port Stop...\r\n", m_serialPort.PortName));
            m_serialPort = null;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtSend.Text != "")
            {
                DataSender(txtSend.Text +"\r\n");
            }
            else
            {
                MessageBox.Show("Print Something");
            }
        }

        private void DataReceiver(object sender, SerialDataReceivedEventArgs e)
        {
            string sRead = "";

            while (true)
            {
                if (sRead.Contains("\r\n") == true) { break; };
                int count = m_serialPort.BytesToRead;
                byte[] arrRead = new byte[count];
                m_serialPort.Read(arrRead, 0, count);

                sRead += Encoding.UTF8.GetString(arrRead, 0, arrRead.Length);
            }

            SetMsg(sRead);
        }

        private void DataSender(string data)
        {
            if(m_serialPort != null)
            {
                byte[] arrWrite = Encoding.UTF8.GetBytes(data);
                m_serialPort.Write(arrWrite, 0, arrWrite.Length);
            }
        }

        private void SetMsg(string txt)
        {
            invokeDelegate setTxt = () => txtMsg.AppendText(string.Format(txt));
            Invoke(setTxt);
            Application.DoEvents();
        }
    }
}
