﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NinjaDomain.OldStyleContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Clan> Clans { get; set; }
        public virtual DbSet<NinjaEquipment> NinjaEquipments { get; set; }
        public virtual DbSet<Ninja> Ninjas { get; set; }
    
        public virtual ObjectResult<Nullable<decimal>> InsertNinja(string name, Nullable<bool> servedInOniwaban, Nullable<int> clanId, Nullable<System.DateTime> dateOfBirth, Nullable<System.DateTime> dateModified, Nullable<System.DateTime> dateCreated)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var servedInOniwabanParameter = servedInOniwaban.HasValue ?
                new ObjectParameter("ServedInOniwaban", servedInOniwaban) :
                new ObjectParameter("ServedInOniwaban", typeof(bool));
    
            var clanIdParameter = clanId.HasValue ?
                new ObjectParameter("ClanId", clanId) :
                new ObjectParameter("ClanId", typeof(int));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(System.DateTime));
    
            var dateModifiedParameter = dateModified.HasValue ?
                new ObjectParameter("DateModified", dateModified) :
                new ObjectParameter("DateModified", typeof(System.DateTime));
    
            var dateCreatedParameter = dateCreated.HasValue ?
                new ObjectParameter("DateCreated", dateCreated) :
                new ObjectParameter("DateCreated", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("InsertNinja", nameParameter, servedInOniwabanParameter, clanIdParameter, dateOfBirthParameter, dateModifiedParameter, dateCreatedParameter);
        }
    }
}
