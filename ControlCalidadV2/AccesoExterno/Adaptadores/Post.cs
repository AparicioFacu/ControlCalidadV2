using ControlCalidadV2;
using Nancy.Json;
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
    public class Post
    {
        string url = ConfigurationManager.AppSettings["url"];
        public string Add<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                //Serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);
                //Peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }       
        public void PostOrdenProduccion(OrdenProduccion orden)
        {
            Add<OrdenProduccion>(url + "ordenproduccion", orden, "POST");
        }
        public void PostJornadaLaboral(JornadaLaboral jornada)
        {
            Add<JornadaLaboral>(url + "jornadalaboral", jornada, "POST");
        }
        public void PostModelo(Modelo modelo)
        {
            Add<Modelo>(url + "modelo", modelo, "POST");
        }
        public void PostRegistro(Registro registro)
        {
            Add<Registro>(url + "Registro", registro, "POST");
        }
        public void PostAlerta(Alerta alerta)
        {
            Add<Alerta>(url + "Alerta", alerta, "POST");
        }
        public void PostColor(Color color)
        {
            Add<Color>(url + "Color", color, "POST");
        }
        public void PostEmpleado(Empleado empleado)
        {
            Add<Empleado>(url + "empleado", empleado, "POST");
        }
    }
}
