﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop_Wpf_App_Entity_Framework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopDBEntities : DbContext
    {
        public ShopDBEntities()
            : base("name=ShopDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Access> Access { get; set; }
        public virtual DbSet<Clients> Client { get; set; }
        public virtual DbSet<ElectronicsProducts> ElectronicsProducts { get; set; }
        public virtual DbSet<FoodsProducts> FoodsProducts { get; set; }
        public virtual DbSet<Purchases> Purchases { get; set; }
        public virtual DbSet<SpaceProducts> SpaceProducts { get; set; }
    }
}