using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Play_nGo_Test.Models
{
    public class RestaurantsDB : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

    }
}