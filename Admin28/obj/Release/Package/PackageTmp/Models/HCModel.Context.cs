﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin28.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HCEntities : DbContext
    {
        public HCEntities()
            : base("name=HCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<JC_HC_AGENCY> JC_HC_AGENCY { get; set; }
        public DbSet<JC_HC_CURENT> JC_HC_CURENT { get; set; }
        public DbSet<JC_HC_LOI> JC_HC_LOI { get; set; }
        public DbSet<JC_HC_SENT> JC_HC_SENT { get; set; }
        public DbSet<JC_HC_TYPES> JC_HC_TYPES { get; set; }
        public DbSet<JC_HC_USERS> JC_HC_USERS { get; set; }
        public DbSet<JC_HC_USR_SND> JC_HC_USR_SND { get; set; }
    }
}
