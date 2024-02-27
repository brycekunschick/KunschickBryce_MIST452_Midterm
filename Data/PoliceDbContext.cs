using KunschickMidterm452.Models;
using Microsoft.EntityFrameworkCore;

namespace KunschickMidterm452.Data
{
    public class PoliceDbContext : DbContext
    {
        public PoliceDbContext(DbContextOptions<PoliceDbContext> options)
            : base(options)
        {

        }

        public DbSet<Officer> Officers { get; set; }

        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Officer>().HasData(

                new Officer
                {
                    OfficerId = 1,
                    FirstName = "George",
                    LastName = "Washington",
                    Address = "1776 Main St",
                    PhoneNum = "3045151776",
                    StartDate = new DateTime(2015, 2, 27),
                    DLN = "85891642",
                    DOB = new DateTime(1985, 5, 15)
                },

                new Officer
                {
                    OfficerId = 2,
                    FirstName = "Thomas",
                    LastName = "Jefferson",
                    Address = "1800 Beechurst Ave",
                    PhoneNum = "3048549120",
                    StartDate = new DateTime(2017, 10, 4),
                    DLN = "74326681",
                    DOB = new DateTime(1988, 8, 21)
                },

                new Officer
                {
                    OfficerId = 3,
                    FirstName = "John",
                    LastName = "Adams",
                    Address = "15 University Ave",
                    PhoneNum = "3047811659",
                    StartDate = new DateTime(2020, 6, 12),
                    DLN = "74326681",
                    DOB = new DateTime(1977, 5, 15)
                }

                );

            modelBuilder.Entity<Request>().HasData(
                
                new Request
                {
                    RequestId = 1,
                    VIN = "1HGBH41JXMN109186",
                    PlateNum = "XYZ1234",
                    VehicleMake = "Ford",
                    VehicleModel = "Explorer",
                    Mileage = 50000,
                    Description = "Routine Service.",
                    OfficerId = 1
                },
                new Request
                {
                    RequestId = 2,
                    VIN = "2FMDK3GC4BBA03605",
                    PlateNum = "ABC6789",
                    VehicleMake = "Dodge",
                    VehicleModel = "Charger",
                    Mileage = 75000,
                    Description = "Brake pad replaced.",
                    OfficerId = 2
                },
                new Request
                {
                    RequestId = 3,
                    VIN = "3JFUD3TM4UFS58410",
                    PlateNum = "DEF4567",
                    VehicleMake = "Dodge",
                    VehicleModel = "Charger",
                    Mileage = 60000,
                    Description = "New battery.",
                    OfficerId = 3
                }


            );
        }
    }
}
