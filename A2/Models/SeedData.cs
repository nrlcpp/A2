using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace A2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ReservationsDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ReservationsDbContext>>()))
            {
                // Look for any reservations.
                if (context.Reservations.Any())
                {
                    return;   // DB table has been seeded
                }

                context.Reservations.AddRange(
                    new Reservation
                    {
                        Sum = 2000,
                        Location = "Turcia",
                        AddedOn = new DateTime(2020, 04, 10),
                        Currency = Currency.EUR,
                        Type = Type.stay,
                        DepartureTime = new DateTime(2020, 09, 10),
                        ArrivalTime = new DateTime(2020, 09, 17),
                        Documents = false

                    },
                     new Reservation
                     {
                         Sum = 1500,
                         Location = "Grecia",
                         AddedOn = new DateTime(2020, 04, 20),
                         Currency = Currency.EUR,
                         Type = Type.stay,
                         DepartureTime = new DateTime(2020, 08, 10),
                         ArrivalTime = new DateTime(2020, 08, 17),
                         Documents = false

                     },

                     new Reservation
                     {
                         Sum = 700,
                         Location = "Bulgaria",
                         AddedOn = new DateTime(2020, 04, 30),
                         Currency = Currency.EUR,
                         Type = Type.accommodation,
                         DepartureTime = new DateTime(2020, 07, 10),
                         ArrivalTime = new DateTime(2020, 07, 15),
                         Documents = true

                     },
                      new Reservation
                      {
                          Sum = 700,
                          Location = "Romania",
                          AddedOn = new DateTime(2020, 04, 30),
                          Currency = Currency.RON,
                          Type = Type.accommodation,
                          DepartureTime = new DateTime(2020, 08, 20),
                          ArrivalTime = new DateTime(2020, 08, 25),
                          Documents = false

                      }

                );
                context.SaveChanges();
            }
        }
    }
}

