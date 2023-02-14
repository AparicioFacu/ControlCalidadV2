using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace ServidorSemaforo
{
    class Program
    {
        static Dictionary<string, Conectado> di = new Dictionary<string, Conectado>(); 
        static void Main(string[] args)
        {
            Conexion con = new Conexion();
            con.Conectar();
            while (true)
            {
                Socket handler = con.Conectado();
                Conectado c = new Conectado(di, handler);
            }
        }
    }
}
