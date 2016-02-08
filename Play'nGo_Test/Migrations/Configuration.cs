namespace Play_nGo_Test.Migrations
{
    using Play_nGo_Test.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Play_nGo_Test.Models.RestaurantsDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Play_nGo_Test.Models.RestaurantsDB context)
        {

            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant {Name = "Lola's Best", City = "Makati", Contact = "(02) 659 5652"},
                new Restaurant {Name = "Spiral", City = "Pasay City", Contact = "(02) 551 5555"},
                new Restaurant {Name = "Harbor View Restaurant", City = "Manila", Contact = "(02) 710 0060"},
                new Restaurant {Name = "Seryna Japanese Restaurant", City = "Makati", Contact = "(02) 894 3855"},
                new Restaurant {Name = "Seattle's Best Coffee", City = "Taguig", Contact = "(02) 856 4527"}
                
                );
            
        }
    }
}
