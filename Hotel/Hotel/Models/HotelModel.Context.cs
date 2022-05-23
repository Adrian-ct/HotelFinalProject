﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HotelEntities : DbContext
    {
        public HotelEntities()
            : base("name=HotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Booking_State> Booking_State { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Room_Type> Room_Type { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<GetAllServices_Result> GetAllServices()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllServices_Result>("GetAllServices");
        }
    
        public virtual ObjectResult<GetAllUsers_Result> GetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUsers_Result>("GetAllUsers");
        }
    
        public virtual ObjectResult<GetRoomsFeatures_Result> GetRoomsFeatures()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRoomsFeatures_Result>("GetRoomsFeatures");
        }
    
        public virtual ObjectResult<SeeRoomsAvailable_Result> SeeRoomsAvailable(string start_date, string end_date)
        {
            var start_dateParameter = start_date != null ?
                new ObjectParameter("start_date", start_date) :
                new ObjectParameter("start_date", typeof(string));
    
            var end_dateParameter = end_date != null ?
                new ObjectParameter("end_date", end_date) :
                new ObjectParameter("end_date", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SeeRoomsAvailable_Result>("SeeRoomsAvailable", start_dateParameter, end_dateParameter);
        }
    }
}
