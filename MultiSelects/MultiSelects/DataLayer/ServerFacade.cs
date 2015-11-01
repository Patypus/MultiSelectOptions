using MultiSelects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiSelects.DataLayer
{
    public class ServerFacade
    {
        public static List<Location> GetAllLocations()
        {
            return new List<Location>
            {
                new Location { Id = 1, Name = "Brighton" },
                new Location { Id = 2, Name = "Dover" },
                new Location { Id = 3, Name = "Venice" },
                new Location { Id = 4, Name = "Paris" },
                new Location { Id = 5, Name = "Lille" },
                new Location { Id = 6, Name = "Barcelona" },
                new Location { Id = 7, Name = "Colonge" },
                new Location { Id = 8, Name = "Athens" },
                new Location { Id = 9, Name = "Istanbul" },
                new Location { Id = 10, Name = "Mainz" },
                new Location { Id = 11, Name = "London" }
            };
        }
    }
}