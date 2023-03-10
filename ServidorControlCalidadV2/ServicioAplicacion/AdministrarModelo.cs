using ServicioDatos;
using ServicioModelo.Entidades;
using ServicioVistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioAplicacion
{
    public class AdministrarModelo
    {
        ControlCalidadEntities1 db = new ControlCalidadEntities1();
        public void PostModelo(ModeloVM mod)
        {
            var oModelo = new Modelo();
            oModelo.Denominacion = mod.Denominacion;
            oModelo.LimiteInferiorO = mod.LimiteInferiorO;
            oModelo.LimiteInferiorR = mod.LimiteInferiorR;
            oModelo.LimiteSuperiorO = mod.LimiteSuperiorO;
            oModelo.LimiteSuperiorR = mod.LimiteSuperiorR;
            oModelo.SKU = mod.Sku;
            db.Modelo.Add(oModelo);
            db.SaveChanges();
        }
        public void PutModelo(ModeloVM mod)
        {
            var oModelo = db.Modelo.Find(mod.Id);
            oModelo.Denominacion = mod.Denominacion;
            oModelo.LimiteInferiorO = mod.LimiteInferiorO;
            oModelo.LimiteInferiorR = mod.LimiteInferiorR;
            oModelo.LimiteSuperiorO = mod.LimiteSuperiorO;
            oModelo.LimiteSuperiorR = mod.LimiteSuperiorR;
            oModelo.SKU = mod.Sku;
            db.Entry(oModelo).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteModelo(ModeloVM mod)
        {
            var oModelo = db.Modelo.Find(mod.Id);
            db.Modelo.Remove(oModelo);
            db.SaveChanges();
        }
    }
}
