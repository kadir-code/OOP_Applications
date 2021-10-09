using OtelFinder.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelFinder
{
    public static class SeedData
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer{Id=1,Name="Max",Surname="Mila"},
            new Customer{Id=2,Name="Lane",Surname="Doe"},
            new Customer{Id=3,Name="Lin",Surname="Kim"},
        };

        public static List<Otel> otels = new List<Otel>()
        {
            new Otel{Id=1,OtelName="Atlantis",Location=Enums.Locations.İstanbul,Price=1000},
            new Otel{Id=2,OtelName="Global",Location=Enums.Locations.İstanbul,Price=2500},
            new Otel{Id=3,OtelName="Axe",Location=Enums.Locations.Ankara,Price=900},
            new Otel{Id=4,OtelName="Louie",Location=Enums.Locations.Ankara,Price=700},
            new Otel{Id=5,OtelName="Max",Location=Enums.Locations.İzmir,Price=1090},
            new Otel{Id=6,OtelName="Granada",Location=Enums.Locations.İzmir,Price=1800},
        };

        public static List<Reservation> reservations = new List<Reservation>()
        {
            new Reservation{Id=1,Customer=customers[0],Otel=otels[0]},
            new Reservation{Id=2,Customer=customers[1],Otel=otels[0]},
            new Reservation{Id=3,Customer=customers[2],Otel=otels[3]},
        };
    }
}
