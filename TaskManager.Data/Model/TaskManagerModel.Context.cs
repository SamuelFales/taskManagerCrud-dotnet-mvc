﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TaskManagerEntities : DbContext
    {
        public TaskManagerEntities()
            : base("name=TaskManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_Roles> TB_Roles { get; set; }
        public virtual DbSet<TB_Task> TB_Task { get; set; }
        public virtual DbSet<TB_TaskList> TB_TaskList { get; set; }
        public virtual DbSet<TB_TaskStatus> TB_TaskStatus { get; set; }
        public virtual DbSet<TB_User> TB_User { get; set; }
        public virtual DbSet<TB_UserRoles> TB_UserRoles { get; set; }
    }
}