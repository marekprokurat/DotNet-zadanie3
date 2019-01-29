using System;
using System.Collections.Generic;
using System.Linq;
using Northwind.Domain.Entities;
using Northwind.Persistence.Infrastructure;

namespace Northwind.Persistence
{
    public class NorthwindInitializer
    {
        private readonly Dictionary<int, Room> Rooms = new Dictionary<int, Room>();

        public static void Initialize(NorthwindDbContext context)
        {
            var initializer = new NorthwindInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(NorthwindDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Rooms.Any())
            {
                return; // Db has been seeded
            }


            SeedRooms(context);

        }

       


        private void SeedRooms(NorthwindDbContext context)
        {
            Rooms.Add(1,
                new Room
                {
                    RoomId = 1,
                    RoomNumber = 1,
                    RoomCapacity = 4,
                  //  ReservationDates =  "Feb 19 1952 12:00AM",
                    Notes = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.",
                    
                });

            Rooms.Add(2,
                new Room
                {
                    RoomId = 2,
                    RoomNumber = 2,
                    RoomCapacity = 4,
                   // RoomCalendar = DateTime.Parse("Feb 19 1952 12:00AM"),
                    Notes = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.",

                });

            Rooms.Add(3,
                new Room
                {
                    RoomId = 2,
                    RoomNumber = 2,
                    RoomCapacity = 4,
                   // RoomCalendar = DateTime.Parse("Feb 19 1952 12:00AM"),
                    Notes = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.",

                });

            Rooms.Add(4,
                new Room
                {
                    RoomId = 4,
                    RoomNumber = 4,
                    RoomCapacity = 4,
                   
                    Notes = "Andrew received his BTS commercial in 1974 and a Ph.Ds Association.",

                });

            Rooms.Add(5,
                new Room
                {

                });

            Rooms.Add(6,
                new Room
                {
                  
                });

            Rooms.Add(7,
                new Room
                {
                   
                });

            

            foreach (var employee in Rooms.Values)
            {
                context.Rooms.Add(employee);
            }

            context.SaveChanges();
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }
    }
}