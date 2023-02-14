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
    public class Delete
    {
        string url = ConfigurationManager.AppSettings["url"];
        public string Delet<T>(string url, T objectRequest, string method = "DELETE")
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
        public void DeleteRegistro(Registro registro)
        {
            Delet<Registro>(url + "registro", registro, "DELETE");
        }
        public void DeleteModelo(Modelo modelo)
        {
            Delet<Modelo>(url + "modelo", modelo, "DELETE");
        }
        public void DeleteColor(Color color)
        {
            Delet<Color>(url + "color", color, "DELETE");
        }
        public void DeleteEmpleado(Empleado empleado)
        {
            Delet<Empleado>(url + "empleado", empleado, "DELETE");
        }
    }
}
