﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NascarRaceManagment.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NASCARRaceManagementDBEntities : DbContext
    {
        public NASCARRaceManagementDBEntities()
            : base("name=NASCARRaceManagementDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        public virtual DbSet<Race> Race { get; set; }
        public virtual DbSet<RaceParticipant> RaceParticipant { get; set; }
        public virtual DbSet<RaceUser> RaceUser { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
