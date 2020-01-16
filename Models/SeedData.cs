using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AutoService.Data;
using System;
using System.Linq;

namespace AutoService.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AutoServiceContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AutoServiceContext>>()))
            {
                // Look for any clients.
                if (context.Client.Any())
                {
                    return;   // DB has been seeded
                }

                context.Client.AddRange(
                    new Client
                    {
                        Name = "Stewart",
                        Surname = "Mclean",
                        Email = "congue.elit@nequesed.ca",
                        Phone = "1 23 193 7006-5481"
                    },

                    new Client
                    {
                        Name = "Alvin",
                        Surname = "Copeland",
                        Email = "euismod@etmagnis.com",
                        Phone = "1 60 979 5069-3506"
                    },

                    new Client
                    {
                        Name = "Macon",
                        Surname = "Young",
                        Email = "natoque.penatibus.et@adipiscing.ca",
                        Phone = "1 54 775 9874-5095"
                    },

                    new Client
                    {
                        Name = "Wade",
                        Surname = "Olsen",
                        Email = "magna.sed@enimSuspendissealiquet.com",
                        Phone = "1 17 573 5675-6601"
                    },

                    new Client
                    {
                        Name = "Harding",
                        Surname = "Rich",
                        Email = "turpis.nulla@eleifendvitae.ca",
                        Phone = "1 24 873 5282-3231"
                    },

                    new Client
                    {
                        Name = "Maxwell",
                        Surname = "Barton",
                        Email = "elementum.sem@nonduinec.org",
                        Phone = "1 48 753 5271-6520"
                    },

                    new Client
                    {
                        Name = "Donovan",
                        Surname = "Ashley",
                        Email = "tellus.id@semper.edu",
                        Phone = "1 64 370 4221-4853"
                    },

                    new Client
                    {
                        Name = "Kuame",
                        Surname = "Carney",
                        Email = "ut.nisi@nullamvelit.edu",
                        Phone = "1 18 501 5497-6930"
                    },

                    new Client
                    {
                        Name = "Dalton",
                        Surname = "Barton",
                        Email = "vel@montes.org",
                        Phone = "1 72 398 4688-9088"
                    },

                    new Client
                    {
                        Name = "Keane",
                        Surname = "Tillman",
                        Email = "malesuada.fames.ac@et.ca",
                        Phone = "1 98 290 2064-3416"
                    }
                );

                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        Brand = "BMW",
                        Model = "320i",
                        ProductionDate = DateTime.Parse("2001-4-12"),
                        RegistrationNumber = "WZ 522SA",
                    },

                    new Car
                    {
                        Brand = "Audi",
                        Model = "A4",
                        ProductionDate = DateTime.Parse("2009-12-01"),
                        RegistrationNumber = "PO 245LA",
                    },

                    new Car
                    {
                        Brand = "Honda",
                        Model = "Accord",
                        ProductionDate = DateTime.Parse("2018-6-20"),
                        RegistrationNumber = "KR 908KO",
                    },

                    new Car
                    {
                        Brand = "Toyota",
                        Model = "Avensis",
                        ProductionDate = DateTime.Parse("2009-4-25"),
                        RegistrationNumber = "WB 748ZZ",
                    },

                    new Car
                    {
                        Brand = "Mercedes",
                        Model = "E220d",
                        ProductionDate = DateTime.Parse("1999-3-13"),
                        RegistrationNumber = "GD 232AD",
                    },

                    new Car
                    {
                        Brand = "Citroen",
                        Model = "Berlingo",
                        ProductionDate = DateTime.Parse("2005-6-4"),
                        RegistrationNumber = "GSP 374DA",
                    },

                    new Car
                    {
                        Brand = "BMW",
                        Model = "530d",
                        ProductionDate = DateTime.Parse("2011-8-10"),
                        RegistrationNumber = "GA 128SL",
                    },

                    new Car
                    {
                        Brand = "Lexus",
                        Model = "IS",
                        ProductionDate = DateTime.Parse("2011-8-10"),
                        RegistrationNumber = "GA 128SL",
                    },

                    new Car
                    {
                        Brand = "Nissan",
                        Model = "Navara",
                        ProductionDate = DateTime.Parse("2016-2-11"),
                        RegistrationNumber = "ZS 694RS",
                    },

                    new Car
                    {
                        Brand = "Suzuki",
                        Model = "Vitara",
                        ProductionDate = DateTime.Parse("2008-3-2"),
                        RegistrationNumber = "ZK 879HS",
                    }
                );

                context.SaveChanges();
            }
        }
    }
}