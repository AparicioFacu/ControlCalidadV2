using ControlCalidadV2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AccesoExterno.Adaptadores
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
        public T GetOrden(string num)
        {           
            return GetUnico(url + $"ordenproduccion?numero={num}");
        }
        public List<T> GetOrdenes()
        {
            return Gets(url + "ordenproduccion");
        }
        public List<T> GetColores()
        {           
            return Gets(url + "color");
        }
        public List<T> GetEmpleados()
        {                        
            return Gets(url + "empleado");
        }
        public List<T> GetModelos()
        {    
            return Gets(url + "modelo");
        }
        public List<T> GetLineas(int idEmp)
        {         
            return Gets(url + $"linea?idEmpleado={idEmp}");
        }
        public List<T> GetRegistroPorPie(int idJornada,int idPie,string hora,string tipoDefecto)
        {
            return Gets(url + $"Registro?idJornada={idJornada}&idPie={idPie}&hora={hora}&tipoDefecto={tipoDefecto}"); 
        }
        public T GetRegistroPorDefecto(int idJornada, int idPie, string hora, string defecto)
        {
            return GetUnico(url + $"Registro?idJornada={idJornada}&idPie={idPie}&hora={hora}&defecto={defecto}");
        }
        public T GetJornadaLaboralPorFecha(DateTime fecha)
        {
            string dateFormatted = fecha.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
            return GetUnico(url + $"jornadalaboral?fecha={dateFormatted}");
        }
        public List<T> GetJornadaLaborales()
        {            
            return Gets(url + "jornadalaboral");
        }
        public T GetTurnoPorJornadaLaboral(int idJornada)
        {
            return GetUnico(url + $"Turno?idJornada={idJornada}");
        }
        public T GetPiePorDescripcion(string descripcion)
        {
            return GetUnico(url + $"Pie?descripcion={descripcion}");
        }
        public T GetDefectoPorDescripcion(string descripcion)
        {
            return GetUnico(url + $"Defecto?descripcion={descripcion}");
        }
        public List<T> GetTipoDefectos()
        {
            return Gets(url + "tipodefecto");
        }
        public List<T> GetTipodePie()
        {
            return Gets(url + "Pie");
        }
        public List<T> GetDefecto(string TipoDefecto)
        {
            return Gets(url + $"Defecto?TipoDefecto={TipoDefecto}");
        }
        public List<T> GetRegistrosPorHoraPie(string hora,int pie)
        {
            return Gets(url + $"Registro?hora={hora}&pie={pie}");
        }
        public List<T> GetRegistrosPorOrdenProduccionPie(int idOrden, int pie)
        {
            return Gets(url + $"Registro?idOrden={idOrden}&pie={pie}");
        }
        public List<T> GetRegistrosPorJornada(int idJornada)
        {
            return Gets(url + $"Registro?idJornada={idJornada}");
        }
        public T GetAlertaPorOrden(int idOrden)
        {
            return GetUnico(url + $"Alerta?idOrden={idOrden}");
        }
        public T GetModeloPorSku(string sku)
        {
            return GetUnico(url + $"modelo?sku={sku}");
        }
        public T GetColorPorCodigo(int codigo)
        {
            return GetUnico(url + $"color?codigo={codigo}");
        }
        public T GetEmpleadoPorDNI(string dni)
        {
            return GetUnico(url + $"empleado?dni={dni}");
        }
       
    }
}
