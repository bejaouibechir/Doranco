﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class AdventureWorksLT2014Entities : DbContext, IModel
    {
        public AdventureWorksLT2014Entities()
            : base("name=AdventureWorksLT2014Entities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
