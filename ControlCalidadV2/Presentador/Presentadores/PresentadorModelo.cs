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
    public class PresentadorModelo
    {
        public void CrearModelo(string SKU,string denominacion,string inferiorObservado,string inferiorReproceso,string superiorObservado, string superiorReproceso, DataGridView tabla)
        {
            Post postModelo = new Post();
            Modelo modelo = new Modelo();
            modelo.SKU = SKU;
            modelo.Denominacion = denominacion;
            modelo.LimiteInferiorO = int.Parse(inferiorObservado);
            modelo.LimiteInferiorR = int.Parse(inferiorReproceso);
            modelo.LimiteSuperiorO = int.Parse(superiorObservado);
            modelo.LimiteSuperiorR = int.Parse(superiorReproceso);
            postModelo.PostModelo(modelo);
            CargarTabla(tabla);
        }
        public void CargarTabla(DataGridView tabla)
        {
            Get<Modelo> getModelo = new Get<Modelo>();            
            tabla.DataSource = (from modelo in getModelo.GetModelos()
                                select new
                                {
                                    SKU = modelo.SKU,
                                    Denominacion = modelo.Denominacion,
                                    LimiteInferiorObservado = modelo.LimiteInferiorO,
                                    LimiteInferiorReproceso = modelo.LimiteInferiorR,
                                    LimiteSuperiorObservado = modelo.LimiteSuperiorO,
                                    LimiteSuperiorReproceso = modelo.LimiteSuperiorR,
                                }
                ).Distinct().ToList();
        }
        public void BuscarModelo(DataGridView tabla, string sku,TextBox txtDenominacion, TextBox txtInferiorObservado, TextBox txtInferiorReproceso, TextBox txtSuperiorObservado, TextBox txtSuperiorReproceso)
        {
            if (sku.Length == 0)
            {
                CargarTabla(tabla);
            }
            else
            {
                Get<Modelo> getModelo = new Get<Modelo>();
                Modelo modelo = getModelo.GetModeloPorSku(sku);
                tabla.DataSource = (from mod in getModelo.GetModelos()
                                    where mod.SKU == sku
                                    select new
                                    {
                                        SKU = mod.SKU,
                                        Denominacion = mod.Denominacion,
                                        LimiteInferiorObservado = mod.LimiteInferiorO,
                                        LimiteInferiorReproceso = mod.LimiteInferiorR,
                                        LimiteSuperiorObservado = mod.LimiteSuperiorO,
                                        LimiteSuperiorReproceso = mod.LimiteSuperiorR,
                                    }
                    ).Distinct().ToList();
                txtDenominacion.Text = modelo.Denominacion;
                txtInferiorObservado.Text = modelo.LimiteInferiorO.ToString();
                txtInferiorReproceso.Text = modelo.LimiteInferiorR.ToString();
                txtSuperiorObservado.Text = modelo.LimiteSuperiorO.ToString();
                txtSuperiorReproceso.Text = modelo.LimiteSuperiorR.ToString();
            }        
        }
        public void EliminarModelo(DataGridView tabla, string sku)
        {
            Delete delete = new Delete();
            Get<Modelo> getModelo = new Get<Modelo>();
            Modelo modelo = getModelo.GetModeloPorSku(sku);
            delete.DeleteModelo(modelo);
            CargarTabla(tabla);
        }
        public void ModificarModelo(DataGridView tabla, string sku,string txtDenominacion, string txtInferiorObservado, string txtInferiorReproceso, string txtSuperiorObservado, string txtSuperiorReproceso)
        {
            Put put = new Put();
            Get<Modelo> getModelo = new Get<Modelo>();
            Modelo modelo = getModelo.GetModeloPorSku(sku);
            modelo.Denominacion = txtDenominacion;
            modelo.LimiteInferiorO = int.Parse(txtInferiorObservado);
            modelo.LimiteInferiorR = int.Parse(txtInferiorReproceso);
            modelo.LimiteSuperiorO = int.Parse(txtSuperiorObservado);
            modelo.LimiteSuperiorR = int.Parse(txtSuperiorReproceso);
            put.PutModelo(modelo);
            CargarTabla(tabla);
        }
    }
}
