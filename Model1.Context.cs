﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketManagementSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MarketManagementSystemEntities : DbContext
    {
        public MarketManagementSystemEntities()
            : base("name=MarketManagementSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Irsaliye> Irsaliyes { get; set; }
        public virtual DbSet<Musteri> Musteris { get; set; }
        public virtual DbSet<Satici> Saticis { get; set; }
        public virtual DbSet<Sati> Satis { get; set; }
        public virtual DbSet<Sepet> Sepets { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tedarikci> Tedarikcis { get; set; }
        public virtual DbSet<TedarikciBorcOdeme> TedarikciBorcOdemes { get; set; }
        public virtual DbSet<Urun> Uruns { get; set; }
        public virtual DbSet<MusteriBorcOdeme> MusteriBorcOdemes { get; set; }
        public virtual DbSet<SatisPesin> SatisPesins { get; set; }
        public virtual DbSet<SatisVeresiye> SatisVeresiyes { get; set; }
        public virtual DbSet<SepetUrun> SepetUruns { get; set; }
    }
}
