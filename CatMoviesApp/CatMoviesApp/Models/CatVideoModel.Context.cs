﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatMoviesApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CatVideoAppEntities : DbContext
    {
        public CatVideoAppEntities()
            : base("name=CatVideoAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<CatNameToURL> CatNameToURLs { get; set; }
        public virtual DbSet<GenreAgeCatNameVideo> GenreAgeCatNameVideos { get; set; }
    }
}