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
    public class AdministrarColor
    {
        ControlCalidadEntities1 db = new ControlCalidadEntities1();
        public void PostColor(ColorVM col)
        {
            var oColor = new Color();
            oColor.Codigo = col.Codigo;
            oColor.Descripcion = col.Descripcion;
            db.Color.Add(oColor);
            db.SaveChanges();
        }
        public void PutColor(ColorVM col)
        {
            var oColor = db.Color.Find(col.Id);
            oColor.Codigo = col.Codigo;
            oColor.Descripcion = col.Descripcion;
            db.Entry(oColor).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteColor(ColorVM col)
        {
            var oColor = db.Color.Find(col.Id);
            db.Color.Remove(oColor);
            db.SaveChanges();
        }
    }
}
