using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace four_in_one
{
    public partial class Form1 : Form
    {
        private readonly SerialPort _serialPort = new SerialPort();
        private Thread threadSerialPort;
        private Thread threadTCPServer;
        private Thread threadTCPClient;
        private TcpListener server;
        private NetworkStream stream1;
        private NetworkStream stream2;
        private byte[] bytes = new byte[256];
        private byte[] bytesSP = new byte[256];
        private bool ButtonccClicked = false;
        private string msgfromClient = "";
        private string completemsgfromClient = "";
        private Int32 TCPport;
        private string serverIP = "";
        private TcpClient tcpClient2;
        private string msgfromServer = "";
        private string completeMsgfromServer = "";
        private byte[] bytesfromServer = new byte[256];      
        private byte[] bytestoSend = new byte[256];
        private bool formisclosing = false;
        private string[] SPports;

        public Form1()
        {
            InitializeComponent();
            SelectCOMAdd();
            _serialPort.WriteTimeout = 5000;            
            COMAdd();
            this.FormClosing += Form1_FormClosing;            
            UpdateBaudRate();

        }

        private void UpdateBaudRate()
        {
            if(int.TryParse(SerialPortBaudrate.Text, out int baudRate))
            {
                _serialPort.BaudRate = baudRate;
            }
            else
            {
                _serialPort.BaudRate = 9600;
            }
        }

        
        private void SPconnet_Click(object sender, EventArgs e)
        {
            if (SelectCOM.SelectedItem != null && !string.IsNullOrEmpty(SelectCOM.SelectedItem.ToString()) && !string.IsNullOrEmpty(SerialPortBaudrate.Text))
            {
                _serialPort.PortName = SelectCOM.SelectedItem.ToString();
                UpdateBaudRate();
                threadSerialPort = new Thread(() => RunSerialport());
                threadSerialPort.Start();
            }
            else
            {
                MessageBox.Show("select COM and set a Baudrate");
            }

        }

        private void COMAdd()
        {
            SPports = SerialPort.GetPortNames();
            foreach (string port in SPports)
            {
                SelectCOM.Items.Add(port);
            }
        }

        private void RunSerialport()
        {
            try
            {
                _serialPort.Open();
                ShowInfo("Connected");
                while (true)
                {
                    
                    string data = "";
                    string completeData = "";
                    int i;
                    while ((i=_serialPort.Read(bytesSP, 0, bytesSP.Length))!=0)
                    {
                        ShowInfo("Message Received");
                        data = System.Text.Encoding.ASCII.GetString(bytesSP, 0, i);
                        completeData += data;
                        if (data[data.Length - 1] == '\n')
                        {
                            ShowmsgInList("Message Received: " + completeData);

                            completeData = "";
                        }
                    }
                }
            }
            catch
            {

                if (!(formisclosing || ButtonccClicked))
                {
                    ShowInfo("error by receiving message");
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPort.Close();
            formisclosing = true;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (oSerialPort.Checked)
            {
                panelSerialPort.Visible = true;
                panelTCP.Visible = false;
                MessageBox.Show("Please select COM and set a Baudrate");
            }
            else if (oTCP.Checked)
            {
                panelSerialPort.Visible = false;
                panelTCP.Visible = true;

            }
        }
        private void SelectCOMAdd()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                SelectCOM.Items.Add(port);
            }
        }

        private void StartTCPServer_Click(object sender, EventArgs e)
        {
            if (AlsTCPServer.Checked)
            {
                server = new TcpListener(IPAddress.Any, 8000);
                threadTCPServer = new Thread(() => RunTCPserver(server));
                threadTCPServer.Start();
            }
            else
            {
                MessageBox.Show("Please select 'als Server' option ");
            }
        }


        private void RunTCPserver(TcpListener server)
        {
            server.Start();
            ShowInfo("Started Server");
            try
            {
                while (true)
                {
                    ShowInfo("Waiting for a connection... ");
                    TcpClient tcpClient1 = server.AcceptTcpClient();
                    ShowInfo("Connected to Client");
                    stream1 = tcpClient1.GetStream();
                    int i;
                    while ((i = stream1.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        msgfromClient = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        completemsgfromClient += msgfromClient;
                        ShowmsgInList("Reiceived: " + msgfromClient);
                        ShowInfo("Received:");
                    }
                }
            }
            catch (Exception)
            {
                if (ButtonccClicked)
                {
                    ShowInfo("connection closed.");
                }
                else
                {
                    ShowInfo("connection failed. Please try again.");
                }
            }
        }

        private void ConnectToTCPServer_Click(object sender, EventArgs e)
        {
            if (AlsTCPClient.Checked)
            {
                TCPport = int.Parse(PortTCP.Text);
                serverIP = IPTCP.Text;
                tcpClient2 = new TcpClient(serverIP, TCPport);
                threadTCPClient = new Thread(() => RunTCPClient());
                threadTCPClient.Start();
            }
            else
            {
                MessageBox.Show("Please select 'als Client' option ");
            }
        }
        private void RunTCPClient()
        {
            try
            {
                ShowInfo("trying to connect");
                msgfromServer = null;
                stream2 = tcpClient2.GetStream();
                while (true)
                {
                    int i;
                    ShowInfo("Connected to Server");
                    while ((i=stream2.Read(bytesfromServer, 0, bytesfromServer.Length))!=0)
                    {
                        msgfromServer = System.Text.Encoding.ASCII.GetString(bytesfromServer, 0, i);
                        completeMsgfromServer += msgfromServer;
                        if (msgfromServer[msgfromServer.Length-1] == '\n')
                        {
                            ShowmsgInList("Message Received: " + completeMsgfromServer);
                            completeMsgfromServer = "";
                        }
                    }
                }
            }
            catch
            {
                //this.Invoke(new Action(() => { MessageBox.Show(this, "error by receiving message from Server"); }));
                if (!(formisclosing || ButtonccClicked))
                {
                    ShowInfo("error by receiving message from Server");
                }
            }

        }

        private void ShowInfo(string info)
        {
            Info.Invoke(new Action(() => { Info.Text = info; }));
        }

        private void ShowmsgInList(string msg)
        {
            listBox1.Invoke(new Action(() => { listBox1.Items.Add(msg); }));
        }

        private void CloseConnection_Click(object sender, EventArgs e)
        {
            ButtonccClicked = true;
            if (AlsTCPServer.Checked)
            {
                server.Stop();
                stream1.Close();
            }
            else if (AlsTCPClient.Checked)
            {
                tcpClient2.Close();
                stream2.Close();
            }
            else if (oSerialPort.Checked)
            {
                _serialPort.Close();
            }
            ShowInfo("Connection closed");
        }

        private void Send_Click(object sender, EventArgs e)
        {
            bytestoSend = System.Text.Encoding.ASCII.GetBytes(MessageToSend.Text + "\n");
            ShowmsgInList("Message sent: " + MessageToSend.Text);
            if (oSerialPort.Checked)
            {
                _serialPort.Write(bytestoSend, 0, bytestoSend.Length);                
            }
            else if (oTCP.Checked)
            {
                if (AlsTCPServer.Checked)
                {
                   stream1.Write(bytestoSend, 0, bytestoSend.Length);
                }
                else if (AlsTCPClient.Checked)
                {
                   stream2.Write(bytestoSend, 0, bytestoSend.Length);
                }
            }
            ShowInfo("Sent");
        }

        private void ShowMyIP_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(GetLocalIPAddress());
            }
            catch (Exception)
            {

                MessageBox.Show("No network adapters with an IPv4 address in the system!");                
            }
        }


        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");

        }
    }
}
