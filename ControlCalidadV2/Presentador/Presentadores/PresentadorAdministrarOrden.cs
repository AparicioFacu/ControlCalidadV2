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
    public class PresentadorAdministrarOrden
    {
        
        JornadaLaboral jornadaPorFecha = new JornadaLaboral();
        string FechaHoraReinicio;
        int idEmpleado;

        public PresentadorAdministrarOrden(int id)
        {
            idEmpleado = id;
        }
        public void CargarTablaOrdenProduccion(DataGridView tabla)
        {            
            Get<OrdenProduccion> getOrden = new Get<OrdenProduccion>();
            Get<JornadaLaboral> getJornada = new Get<JornadaLaboral>();
            tabla.DataSource = (from orden in getOrden.GetOrdenes()
                                join jornada in getJornada.GetJornadaLaborales()
                                on orden.Id equals jornada.IdOrdenProduccion
                                select new
                                {
                                    Numero = orden.Numero,
                                    FechaInicio = orden.FechaInicio,
                                    Color = orden.Color.Descripcion,
                                    Modelo = orden.Modelo.Denominacion,
                                    Estado = orden.EstadoOrden.Descripcion,
                                    InicioJornada = jornada.FechaInicio,
                                    Empleado = jornada.Empleado.ApeYNom
                                }
                ).Distinct().ToList();
            tabla.Columns["InicioJornada"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }
        public void BuscarOrdenProduccion(DataGridView tabla, string numero)
        {
            if (numero.Length == 0)
            {
                CargarTablaOrdenProduccion(tabla);
            }
            else
            {
                Get<JornadaLaboral> getJornada = new Get<JornadaLaboral>();
                Get<OrdenProduccion> get = new Get<OrdenProduccion>();
                tabla.DataSource = (from orden in get.GetOrdenes()                                    
                                    where orden.Numero == numero
                                    join jornada in getJornada.GetJornadaLaborales()
                                    on orden.Id equals jornada.IdOrdenProduccion
                                    select new
                                    {
                                        Numero = orden.Numero,
                                        FechaInicio = orden.FechaInicio,
                                        Color = orden.Color.Descripcion,
                                        Modelo = orden.Modelo.Denominacion,
                                        Estado = orden.EstadoOrden.Descripcion,
                                        FechaInicioJornada = jornada.FechaInicio
                                    }
                    ).Distinct().ToList();
            }
        }       
        public void GetTurnos(ComboBox cbxTurno,DateTime fecha, Label lblTotalPrimera)
        {           
            List<string> IntervaloHoras;
            Get<JornadaLaboral> getJornada = new Get<JornadaLaboral>();
            this.jornadaPorFecha = getJornada.GetJornadaLaboralPorFecha(fecha);     
            Get<Turno> getTurno = new Get<Turno>();
            Turno _turno = getTurno.GetTurnoPorJornadaLaboral((int)jornadaPorFecha.Id);
            IntervaloHoras = GeneraIntervaloHoras((DateTime)_turno.HoraInicio, (DateTime)_turno.HoraFin);
            cbxTurno.DataSource = IntervaloHoras;
            cbxTurno.ValueMember = "Id";
            cbxTurno.DisplayMember = "IntervaloHoras";           
            CalcularTotalPrimera(lblTotalPrimera);
        }
        public void AgregarDefecto(string horaTurno, string defecto, string tipoPie, string tipoDefecto,DataGridView tablaIzquieda, DataGridView tablaDerecha)
        {
            Get<Defecto> getDefecto = new Get<Defecto>();
            Get<TipoPie> getTipoPie = new Get<TipoPie>();
            Post post = new Post();
            //Put put = new Put();
            Registro registro = new Registro();
            registro.Defecto = getDefecto.GetDefectoPorDescripcion(defecto);
            registro.TipoPie = getTipoPie.GetPiePorDescripcion(tipoPie);
            registro.Hora = DateTime.Now;
            registro.IdJornadaLaboral = jornadaPorFecha.Id;           
            post.PostRegistro(registro);
            GetDefectos(tablaIzquieda, tablaDerecha, horaTurno, tipoDefecto);

        }
        public void EliminarDefectoIzquierdo(string horaTurno, string defecto, string tipoDefecto, DataGridView tablaIzquieda, DataGridView tablaDerecha)
        {
            Get<Registro> getRegistro = new Get<Registro>();
            Registro registro = getRegistro.GetRegistroPorDefecto((int)jornadaPorFecha.Id, 1, horaTurno, defecto);
            Delete deleteRegistro = new Delete();
            deleteRegistro.DeleteRegistro(registro);
            GetDefectos(tablaIzquieda, tablaDerecha, horaTurno, tipoDefecto);
        }
        public void EliminarDefectoDerecho(string horaTurno, string defecto, string tipoDefecto, DataGridView tablaIzquieda, DataGridView tablaDerecha)
        {
            Get<Registro> getRegistro = new Get<Registro>();
            Registro registro = getRegistro.GetRegistroPorDefecto((int)jornadaPorFecha.Id, 2, horaTurno, defecto);
            Delete deleteRegistro = new Delete();
            deleteRegistro.DeleteRegistro(registro);
            GetDefectos(tablaIzquieda, tablaDerecha, horaTurno, tipoDefecto);
        }
        public void GetDefectos(DataGridView tablaIzquieda, DataGridView tablaDerecha,string horaTurno,string tipoDefecto)
        {
            Get<Registro> getRegistro = new Get<Registro>();                  
            tablaIzquieda.DataSource = (from registro in getRegistro.GetRegistroPorPie((int)jornadaPorFecha.Id,1,horaTurno,tipoDefecto)                                
                                select new
                                {
                                    Defecto = registro.Defecto.Descripcion,                                   
                                }
                ).Distinct().ToList();
            
            tablaDerecha.DataSource = (from registro in getRegistro.GetRegistroPorPie((int)jornadaPorFecha.Id, 2, horaTurno, tipoDefecto)
                                        select new
                                        {
                                            Defecto = registro.Defecto.Descripcion,
                                            
                                        }
                ).Distinct().ToList();
                  
        }
        public void DesvincularEmpleado(string estado, DataGridView tabla)
        {
            Put put = new Put();
            if(estado == "Pausada")
            {
                jornadaPorFecha.Empleado.Id = 6;
                put.PutJornada(jornadaPorFecha);
                CargarTablaOrdenProduccion(tabla);
            }          
        }
        public void VincularEmpleado(string estado, DataGridView tabla)
        {
            Put put = new Put();
            if (estado == "Pausada")
            {
                jornadaPorFecha.Empleado.Id = idEmpleado;
                put.PutJornada(jornadaPorFecha);
                CargarTablaOrdenProduccion(tabla);
            }
        }
        public void PausarOP(string numero, DataGridView tabla,string color,int tipoDefecto)
        {
            string estado = EstadoOrdenEnum.Pausada.ToString();
            CambiarEstado(numero, tabla, estado);
            if(color == SemaforoEnum.Rojo.ToString())
            {
                Post post = new Post();
                Alerta _alerta = new Alerta();
                _alerta.FechaHoraDetine = DateTime.Now;
                _alerta.IdOrdenProduccion = jornadaPorFecha.IdOrdenProduccion;
                _alerta.Semaforo = new Semaforo
                {
                    Id = 3
                };
                _alerta.TipoDefecto = new TipoDefecto
                {
                    Id = tipoDefecto
                };
                post.PostAlerta(_alerta);
            }
        }
        public void RenaudarOP(string numero, DataGridView tabla)
        {
            string estado = EstadoOrdenEnum.Iniciada.ToString();
            CambiarEstado(numero, tabla, estado);
            Get<Alerta> getAlerta = new Get<Alerta>();
            Alerta alerta = getAlerta.GetAlertaPorOrden((int)jornadaPorFecha.IdOrdenProduccion);
            alerta.FechaHoraReinicio = DateTime.Now;
            alerta.IdOrdenProduccion = jornadaPorFecha.IdOrdenProduccion;
            Put put = new Put();
            put.PutAlerta(alerta);
            FechaHoraReinicio = alerta.FechaHoraReinicio.ToString();
            ConectarSocket();
        }
        public void FinalizarOP(string numero, DataGridView tabla)
        {
            string estado = EstadoOrdenEnum.Finalizada.ToString();
            CambiarEstado(numero, tabla, estado);
        }
        public void CambiarEstado(string numero, DataGridView tabla,string estado)
        {
            Put put = new Put();
            Get<OrdenProduccion> getOrden = new Get<OrdenProduccion>();
            OrdenProduccion orden = getOrden.GetOrden(numero);
            orden.EstadoOrden.Descripcion = estado;
            put.PutOrdenProduccion(orden);
            CargarTablaOrdenProduccion(tabla);
            
        }
        public void CalcularTotalDefectosPorHora(string hora,Label lblTotalIzquierdoPorHora, Label lblTotalDerechoPorHora)
        {
            Get<Registro> getRegistro = new Get<Registro>();
            List<Registro> listRegistroIzquierdo = getRegistro.GetRegistrosPorHoraPie(hora,1);
            List<Registro> listRegistroDerecho = getRegistro.GetRegistrosPorHoraPie(hora, 2);
            lblTotalIzquierdoPorHora.Text = listRegistroIzquierdo.Count().ToString();
            lblTotalDerechoPorHora.Text = listRegistroDerecho.Count().ToString();
        }
        public void CalcularTotalDefectos(Label lblTotalIzquierdo, Label lblTotalDerecho)
        {
            Get<Registro> getRegistro = new Get<Registro>();
            List<Registro> listRegistroIzquierdo = getRegistro.GetRegistrosPorOrdenProduccionPie((int)jornadaPorFecha.Id,1);
            List<Registro> listRegistroDerecho = getRegistro.GetRegistrosPorOrdenProduccionPie((int)jornadaPorFecha.Id, 2);
            lblTotalDerecho.Text = listRegistroDerecho.Count().ToString();
            lblTotalIzquierdo.Text = listRegistroIzquierdo.Count().ToString();
        }
        public void CalcularTotalPrimera(Label lblTotalPrimera)
        {
            lblTotalPrimera.Text = jornadaPorFecha.CParPrimera.ToString();
        }       
        public void SumarParPrimera()
        {
            Put putJornada = new Put();
            jornadaPorFecha.CParPrimera += 1;
            putJornada.PutJornada(jornadaPorFecha);
        }
        public void RestarParPrimera(Label lblTotalPrimera)
        {
            Put putJornada = new Put();
            if (int.Parse(lblTotalPrimera.Text) > 0)
            {
                jornadaPorFecha.CParPrimera -= 1;
                putJornada.PutJornada(jornadaPorFecha);
            }
            
        }
        public void GetDefectoCbx(ComboBox cbxDefecto,string tipoDefecto, DataGridView tablaIzquieda, DataGridView tablaDerecha,string horaTurno)
        {
            Get<Defecto> _defecto = new Get<Defecto>();
            cbxDefecto.DataSource = _defecto.GetDefecto(tipoDefecto);
            cbxDefecto.ValueMember = "Id";
            cbxDefecto.DisplayMember = "Descripcion";        
        }
        public void GetTipoPie(ComboBox cbxPie)
        {
            Get<TipoPie> _tipoPie = new Get<TipoPie>();
            cbxPie.DataSource = _tipoPie.GetTipodePie();
            cbxPie.ValueMember = "Id";
            cbxPie.DisplayMember = "Descripcion";
        }
        public void GetTipoDefectos(ComboBox cbxTipoDefecto)
        {
            Get<TipoDefecto> _tipoDefecto = new Get<TipoDefecto>();
            cbxTipoDefecto.DataSource = _tipoDefecto.GetTipoDefectos();
            cbxTipoDefecto.ValueMember = "Id";
            cbxTipoDefecto.DisplayMember = "Descripcion";
        }
        public string ConectarSocket()
        {
            return jornadaPorFecha.Id.ToString()+FechaHoraReinicio;
        }
        public List<string> GeneraIntervaloHoras(DateTime _horainicio, DateTime _horafin)
        {
            List<string> resultado = new List<string>();            
            DateTime _horaactual = _horainicio;

            while (_horaactual < _horafin)
            {
                resultado.Add(
                    _horaactual.ToShortTimeString() + " - " +
                    _horaactual.AddHours(1).ToShortTimeString());

                _horaactual = _horaactual.AddHours(1);
            }

            return resultado;
        }
    }
}
