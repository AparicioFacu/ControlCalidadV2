//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioModelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Turno
    {
        public int IdTurno { get; set; }
        public Nullable<System.DateTime> HorarioInicio { get; set; }
        public Nullable<System.DateTime> HorarioFin { get; set; }
        public Nullable<int> IdJornadaLaboral { get; set; }
    
        public virtual JornadaLaboral JornadaLaboral { get; set; }
    }
}