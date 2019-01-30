using System.Collections.Generic;
using Northwind.Domain.Entities;

namespace Northwind.Persistence
{
    public class NorthwindInitializer
    {
        private readonly Dictionary<int, Room> Rooms = new Dictionary<int, Room>();

        public static void Initialize(NorthwindDbContext context)
        {
            var initializer = new NorthwindInitializer();
            initializer.SeedEverything(context);
            initializer.SeedRooms(context);
        }

        public void SeedEverything(NorthwindDbContext context)
        {
            context.Database.EnsureCreated();

            SeedRooms(context);

        }


        public void SeedRooms(NorthwindDbContext context)
        {
            var rooms = new[]
            {

                new Room()
                {
                    RoomId = 1,
                    RoomNumber = 1,
                    RoomCapacity = 4,
                    Notes = "Andrew received his BTS commerciad to vice preside",

                },

                new Room()
                {
                    RoomId = 2,
                    RoomNumber = 2,
                    RoomCapacity = 4,
                    Notes = "Andrew receivific Rim Importers Association.",

                },

                new Room()
                {
                    RoomId = 3,
                    RoomNumber = 2,
                    RoomCapacity = 4,
                    Notes = "Andrew",
                },


                new Room()
                {
                    RoomId = 4,
                    RoomNumber = 4,
                    RoomCapacity = 4,
                    Notes = "Andrew received his BTS commercial in 1974 and a Ph.Ds Association.",

                },


                new Room()
                {
                    RoomId = 5,
                    RoomNumber = 4,
                    RoomCapacity = 4,
                    Notes = "Andrew received his BTS commercial in 1974 and a Ph.Ds Association.",
                },


                new Room()
                {
                    RoomId = 6,
                    RoomNumber = 4,
                    RoomCapacity = 4,
                    Notes = "Andrew received his BTS commercial in 1974 and a Ph.Ds Association.",
                },


                new Room()
                {
                    RoomId = 7,
                    RoomNumber = 4,
                    RoomCapacity = 4,
                    Notes = "Andrew received his BTS commercial in 1974 and a Ph.Ds Association.",
                }
            };


            context.Rooms.AddRange(rooms);
  
            context.SaveChanges();
        } };


     
}