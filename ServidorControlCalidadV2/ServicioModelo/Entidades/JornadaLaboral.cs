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
    
    public partial class JornadaLaboral
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JornadaLaboral()
        {
            this.Registro = new HashSet<Registro>();
            this.Turno = new HashSet<Turno>();
        }
    
        public int IdJornadaLaboral { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFinal { get; set; }
        public Nullable<int> CantParPrimera { get; set; }
        public Nullable<int> CantParSegunda { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<int> IdOrdenProduccion { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual OrdenProduccion OrdenProduccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro> Registro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turno { get; set; }
    }
}