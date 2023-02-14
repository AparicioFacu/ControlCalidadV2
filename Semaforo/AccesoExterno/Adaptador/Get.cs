using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AccesoExterno.Adaptador
{
    public class Get<T>
    {
        List<T> list;
        T objec;
        string url = ConfigurationManager.AppSettings["url"];
        public async void ActulizarGet(string url)
        {
            string respuesta = await GetHttp(url);
            list = JsonConvert.DeserializeObject<List<T>>(respuesta);
        }
        private async Task<string> GetHttp(string url)
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        public List<T> Gets(string url)
        {
            ActulizarGet(url);
            return list;
        }
        public async void ActulizarGetUnico(string url)
        {
            string respuesta = await GetHttpBuscar(url);
            objec = JsonConvert.DeserializeObject<T>(respuesta);

        }
        private async Task<string> GetHttpBuscar(string url)
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        public T GetUnico(string url)
        {
            ActulizarGetUnico(url);
            return objec;
        }
        public List<T> GetRegistrosPorJornada(int idJornada)
        {
            return Gets(url + $"Registro?idJornada={idJornada}");
        }
        public T GetOrdenPorJornadaLaboral(int idOrden)
        {
            return GetUnico(url + $"ordenproduccion?idOrden={idOrden}");
        }
        public List<T> GetDefecto(string TipoDefecto)
        {
            return Gets(url + $"Defecto?TipoDefecto={TipoDefecto}");
        }
        public T GetTurnoPorJornadaLaboral(int idJornada)
        {
            return GetUnico(url + $"Turno?idJornada={idJornada}");
        }
        public List<T> GetRegistrosPorOrdenProduccionPie(int idOrden, int pie)
        {
            return Gets(url + $"Registro?idOrden={idOrden}&pie={pie}");
        }

    }
}
