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
    public class Put
    {
        string url = ConfigurationManager.AppSettings["url"];
        public string Pu<T>(string url, T objectRequest, string method = "PUT")
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
        public void PutJornada(JornadaLaboral jornada)
        {
            Pu<JornadaLaboral>(url + "jornadalaboral", jornada, "PUT");
        }
        public void PutOrdenProduccion(OrdenProduccion orden)
        {
            Pu<OrdenProduccion>(url + "ordenproduccion", orden, "PUT");
        }
        public void PutAlerta(Alerta alerta)
        {
            Pu<Alerta>(url + "Alerta", alerta, "PUT");
        }
        public void PutModelo(Modelo modelo)
        {
            Pu<Modelo>(url + "modelo", modelo, "PUT");
        }
        public void PutColor(Color color)
        {
            Pu<Color>(url + "color", color, "PUT");
        }
        public void PutEmpleado(Empleado empleado)
        {
            Pu<Empleado>(url + "empleado", empleado, "PUT");
        }
    }
}
