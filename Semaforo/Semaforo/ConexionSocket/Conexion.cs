using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Semaforo
{
    public class Conexion
    {
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint localEP;
        Socket enviador;

        public Conexion()
        {

        }

        public void Conectar()
        {
            host = Dns.GetHostEntry("localhost");
            ipAddress = host.AddressList[0];
            localEP = new IPEndPoint(ipAddress, 6000);
            enviador = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            enviador.Connect(localEP);
        }
        public void Send(string mensaje)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(mensaje + "<EOF>");
                enviador.Send(msg);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string Receive()
        {
            try
            {
                string data = null;
                byte[] bytes = null;
                while (true)
                {
                    bytes = new byte[1024];
                    int byteRec = this.enviador.Receive(bytes);
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
        public void Desconectar()
        {
            enviador.Shutdown(SocketShutdown.Both);
            enviador.Close();
        }
    }
}
