using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;

namespace ServidorSemaforo
{
    public class Conectado
    {
        public string nick { get; set; }
        private Thread recibir;
        private Socket handler;
        private Dictionary<string, Conectado> di;
        private Conexion _con;

        public Conectado(Dictionary<string, Conectado> di, Socket handler)
        {
            this.recibir = new Thread(Receive);
            this.recibir.Start();
            this.di = di;
            this.handler = handler;
            this._con = new Conexion();
        }
        public void Send(string mensaje)
        {
            this._con.Send(mensaje, this.handler);
        }
        public void SendUser(string[] todo)
        {
            try
            {
                Conectado co = this.di[todo[0]];
                co.Send(this.nick + "-" + todo[1]);
            }
            catch(KeyNotFoundException ke)
            {
                Console.WriteLine("key: " + todo[0]);
                Console.WriteLine(ke.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Receive()
        {
            while (true)
            {
                if(this.nick == null)
                {
                    this.nick = this._con.Receive(this.handler);
                    di.Add(this.nick, this);
                    this.Send("conectado");
                }
                else
                {
                    string msg = this._con.Receive(this.handler);
                    if(msg== "desconectar")
                    {
                        di.Remove(this.nick);
                        Conectado co = this;
                        co.handler.Shutdown(SocketShutdown.Both);
                        co.handler.Close();
                        co = null;
                    }
                    else
                    {
                        Console.WriteLine(this.nick + ":" + msg);
                        this.SendUser(msg.Split('-'));
                    }
                }
            }
        }
    }
}
