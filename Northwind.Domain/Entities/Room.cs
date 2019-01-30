﻿using System.Collections.Generic;
namespace Northwind.Domain.Entities
{
    public class Room
    {
        public Room()
        {
            ReservationDates = new List<Date>();
        }

        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public int RoomCapacity { get; set; }
        public string Notes { get; set; }
        public ICollection<Date> ReservationDates { get; set; }


    }
}

        
        
       



   
