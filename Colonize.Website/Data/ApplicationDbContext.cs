using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Colonize.Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Voyage> Voyage { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var ships = new List<Ship>
            {
                new Ship(1, "Moonshot", "jsdf", 200,
                new Uri("https://via.placeholder.com/480x360.png?text=Moonshot", UriKind.Absolute)),

                new Ship(2, "Mars Explorer", "kjgns", 1800,
                new Uri("https://via.placeholder.com/480x360.png?text=Mars+Explorer", UriKind.Absolute))
            };

            ships.ForEach(x => modelBuilder.Entity<Ship>().HasData(x));

            var destinations = new List<Destination>
            {
                new Destination(1, "Moon", "slrgk",
                new Uri("https://via.placeholder.com/480x360.png?text=Moon", UriKind.Absolute)),

                new Destination(2, "Mars", "qp3r",
                new Uri("https://via.placeholder.com/480x360.png?text=Mars", UriKind.Absolute))
            };

            destinations.ForEach(x => modelBuilder.Entity<Destination>().HasData(x));

            var moonshot = ships.Find(x => x.Name == "Moonshot");
            var marsExplorer = ships.Find(x => x.Name == "Mars Explorer");

            var moon = destinations.Find(x => x.Name == "Moon");
            var mars = destinations.Find(x => x.Name == "Mars");

            var voyages = new List<Voyage>
            {
                new Voyage(1, moon.Id, moonshot.Id, new DateTime(2020, 11, 02, 16, 30, 00), new DateTime(2022, 11, 10, 13, 36, 06)),

                new Voyage(2, mars.Id, marsExplorer.Id, new DateTime(2023, 05, 20, 03, 20, 20),new DateTime(2026, 03, 30, 00, 00, 01))
            };

            voyages.ForEach(x => modelBuilder.Entity<Voyage>().HasData(x));
        }
    }
}
