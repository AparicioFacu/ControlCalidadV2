using AccesoExterno.Adaptadores;
using ControlCalidadV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador.Presentadores
{
    public class PresentadorColor
    {
        public void CrearColor(string codigo, string descripcion, DataGridView tabla)
        {
            Post postModelo = new Post();
            Color color = new Color();
            color.Codigo = int.Parse(codigo);
            color.Descripcion = descripcion;
            
            postModelo.PostColor(color);
            CargarTabla(tabla);
        }
        public void CargarTabla(DataGridView tabla)
        {
            Get<Color> getColor = new Get<Color>();
            tabla.DataSource = (from color in getColor.GetColores()
                                select new
                                {
                                    Codigo = color.Codigo,
                                    Descripcion = color.Descripcion,
                                    
                                }
                ).Distinct().ToList();
        }
        public void BuscarColor(DataGridView tabla, string codigo, TextBox txtdescipcion)
        {
            if (codigo.Length == 0)
            {
                CargarTabla(tabla);
            }
            else
            {
                Get<Color> getColor = new Get<Color>();
                Color col = getColor.GetColorPorCodigo(int.Parse(codigo));
                tabla.DataSource = (from color in getColor.GetColores()
                                    where color.Codigo == int.Parse(codigo)
                                    select new
                                    {
                                        Codigo = color.Codigo,
                                        Descripcion = color.Descripcion,
                                    }
                    ).Distinct().ToList();
                txtdescipcion.Text = col.Descripcion;
            }
        }
        public void EliminarColor(DataGridView tabla, string codigo)
        {
            Delete delete = new Delete();
            Get<Color> getColor = new Get<Color>();
            Color col = getColor.GetColorPorCodigo(int.Parse(codigo));
            delete.DeleteColor(col);
            CargarTabla(tabla);
        }
        public void ModificarColor(DataGridView tabla, string codigo, string txtDescipcion)
        {
            Put put = new Put();
            Get<Color> getColor = new Get<Color>();
            Color col = getColor.GetColorPorCodigo(int.Parse(codigo));
            col.Descripcion = txtDescipcion;
            put.PutColor(col);
            CargarTabla(tabla);
        }
    }
}
