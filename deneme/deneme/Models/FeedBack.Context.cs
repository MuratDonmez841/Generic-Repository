﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deneme.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FBEntities : DbContext
    {
        public FBEntities()
            : base("name=FBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Company_Info> Company_Info { get; set; }
        public virtual DbSet<FeedBack_IMG> FeedBack_IMG { get; set; }
        public virtual DbSet<FeedBack_Info> FeedBack_Info { get; set; }
        public virtual DbSet<FeedBack_Point> FeedBack_Point { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<User_Com> User_Com { get; set; }
        public virtual DbSet<User_PI> User_PI { get; set; }
        public virtual DbSet<vCategory> vCategory { get; set; }
        public virtual DbSet<vFeedBack> vFeedBack { get; set; }
        public virtual DbSet<vProducts> vProducts { get; set; }
        public virtual DbSet<FeedBack_Description> FeedBack_Description { get; set; }
    }
}
