﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SPAAEntities1 : DbContext
    {
        public SPAAEntities1()
            : base("name=SPAAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CITA> CITAs { get; set; }
        public virtual DbSet<CLIENTE> CLIENTEs { get; set; }
        public virtual DbSet<EVALUACIONE> EVALUACIONES { get; set; }
        public virtual DbSet<HISTORIALCITA> HISTORIALCITAS { get; set; }
        public virtual DbSet<HISTORIALCOMPRA> HISTORIALCOMPRAS { get; set; }
        public virtual DbSet<MEMBRESiA> MEMBRESiAS { get; set; }
        public virtual DbSet<NOMINA> NOMINAs { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTOS { get; set; }
        public virtual DbSet<PROFESIONAL> PROFESIONALs { get; set; }
        public virtual DbSet<RESERVA> RESERVAS { get; set; }
        public virtual DbSet<SERVICIO> SERVICIOs { get; set; }
        public virtual DbSet<SUSCRIPCIONE> SUSCRIPCIONES { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<VENTA> VENTAS { get; set; }
    }
}
