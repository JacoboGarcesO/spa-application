//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace servicioProyecto
{
    using System;
    using System.Collections.Generic;
    
    public partial class CITA
    {
        public int IDCITA { get; set; }
        public Nullable<int> IDCLIENTE { get; set; }
        public Nullable<int> IDSERVICIO { get; set; }
        public Nullable<System.DateTime> FECHACITA { get; set; }
        public Nullable<int> HORA { get; set; }
        public string OBSERVACIONES { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual SERVICIO SERVICIO { get; set; }
    }
}
