using BoatService.Web.DataAccess.Implementations.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoatService.Web.DataAccess.Implementations
{
    public class DataContext: DbContext
    {
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<RoutePoint> RoutePoints { get; set; }
        public DbSet<Skipper> Skippers { get; set; }
        public DbSet<TripOrder> TripOrders { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
    }
}