﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructure.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TALIS_FAST_FOODEntities : DbContext
    {
        public TALIS_FAST_FOODEntities()
            : base("name=TALIS_FAST_FOODEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIA_PRODUCTO> CATEGORIA_PRODUCTO { get; set; }
        public virtual DbSet<DETALLE_ORDEN> DETALLE_ORDEN { get; set; }
        public virtual DbSet<ESTADO_MESA> ESTADO_MESA { get; set; }
        public virtual DbSet<ESTADO_ORDEN> ESTADO_ORDEN { get; set; }
        public virtual DbSet<FACTURA> FACTURA { get; set; }
        public virtual DbSet<FACTURA_TIPO_PAGO> FACTURA_TIPO_PAGO { get; set; }
        public virtual DbSet<MESA> MESA { get; set; }
        public virtual DbSet<ORDEN> ORDEN { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<RESTAURANTE> RESTAURANTE { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<TIPO_PAGO> TIPO_PAGO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}