using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Net;
using System.Net.Sockets;


namespace Sales
{
    public partial class Client : Form
    {
        Socket socket;
        EndPoint local;
        EndPoint remote;
        byte[] buffer;


        public Client()
        {
            InitializeComponent();

            statusLbl.Text = "Ready";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            local = new IPEndPoint(IPAddress.Parse(txtLocalIp.Text),Convert.ToInt16(txtPortLocal.Text));
            socket.Bind(local);

            remote = new IPEndPoint(IPAddress.Parse(txtIpRemote.Text), Convert.ToInt16(textRemotePort.Text));
            socket.Connect(remote);

            buffer = new byte[1024];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remote, new AsyncCallback(MessageCallBack), buffer);
        
        
        }

        private void MessageCallBack(IAsyncResult ar)
        {
            try
            {
                byte[] receivedData = new byte[1024];
                receivedData = (byte[])ar.AsyncState;
                string message = Encoding.Default.GetString(receivedData);

                 if (lstNotifications.InvokeRequired)
            {
                lstNotifications.Invoke((MethodInvoker)delegate()
                {
                    TransferText(message);

                    stautsLbl.Text = "Message sent.";
                });
            }
            else
                lstNotifications.Items.Add(message);
                buffer = new byte[1024];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void TransferText(string s)
        {
            lstNotifications.Items.Add(string.Format(
                "<server> replied: {0}\t received at {1}",
                s, DateTime.Now.ToLocalTime().ToString()
                ));
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] sendData = new byte[1024];
                sendData = Encoding.Default.GetBytes(txtMessage.Text);
                //send
                socket.Send(sendData);
                lstNotifications.Items.Add("<client> " + txtMessage.Text);
                txtMessage.Text = null;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtLocalIp.Text = GetLocalIp();
            txtIpRemote.Text = GetLocalIp();
        }


        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }
    }
}
