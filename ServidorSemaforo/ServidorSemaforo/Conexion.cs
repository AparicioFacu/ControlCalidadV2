using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServidorSemaforo
{
    public class Conexion
    {
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint localEP;
        Socket listener;
        public Conexion()
        {

        }
        public void Conectar()
        {
            this.host = Dns.GetHostEntry("localhost");
            this.ipAddress = host.AddressList[0];
            this.localEP = new IPEndPoint(ipAddress, 6000);
            try
            {
                this.listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                this.listener.Bind(localEP);
                this.listener.Listen(10);
            }
            catch (Exception)
            {

                throw;
            }           
        }
        public void Send(string mensaje,Socket handler)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(mensaje + "<EOF>");
                int byteSent = handler.Send(msg);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string Receive(Socket handler)
        {
            try
            {
                string data = null;
                byte[] bytes = null;
                while (true)
                {
                    bytes = new byte[1024];
                    int byteRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, byteRec);
                    if (data.IndexOf("<EOF>") > -1)
                        break;
                }
                data = data.Replace("<EOF>", "");
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Socket Conectado()
        {
            return this.listener.Accept();
        }

    }
}
