using Angular_GrahQL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Configuration;

namespace Angular_GrahQL.EntityFrameworkCore
{
    public class MyHotelDbContext : DbContext
    {
        public IConfiguration Configuration { get; }
        public MyHotelDbContext(DbContextOptions<MyHotelDbContext> options) : base(options)
        {

        }

        //Настроить на ноутбуке энтити фреймворк
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseNpgsql("Host=localhost;Database=Angluar_GraphQL;Username=postgres;Password=1");

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Guest> Guests { get; set; }

        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //GUESTS
            modelBuilder.Entity<Guest>().HasData(new Guest("Владимир", "Петров", DateTime.Now.AddDays(-10)) { Id = 1 });
            modelBuilder.Entity<Guest>().HasData(new Guest("Александр", "Кононов", DateTime.Now.AddDays(-5)) { Id = 2 });
            modelBuilder.Entity<Guest>().HasData(new Guest("Дафт","Панков", DateTime.Now.AddDays(-1)) { Id = 3 });

            //ROOMS
            modelBuilder.Entity<Room>().HasData(new Room(101, "желтая-Комната", RoomStatus.Available, false) { Id = 1 });
            modelBuilder.Entity<Room>().HasData(new Room(102, "синяя-Комната", RoomStatus.Available, false) { Id = 2 });
            modelBuilder.Entity<Room>().HasData(new Room(103, "белая-Комната", RoomStatus.Unavailable, false) { Id = 3 });
            modelBuilder.Entity<Room>().HasData(new Room(104, "черная-Комната", RoomStatus.Unavailable, false) { Id = 4 });

            //RESERVATIONS
            modelBuilder.Entity<Reservation>().HasData(new Reservation(DateTime.Now.AddDays(-2), DateTime.Now.AddDays(3), 3, 1) { Id = 1 });
            modelBuilder.Entity<Reservation>().HasData(new Reservation(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(4), 4, 2) { Id = 2 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
