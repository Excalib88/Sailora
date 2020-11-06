using System.Collections;
using System.Collections.Generic;

namespace BoatService.Web.DataAccess.Implementations.Entities
{
    public class TripOrder : BaseEntity
    {
        public Boat Boat { get; set; }
        public Route Route { get; set; }
        public string FreePlaces { get; set; }
        public Person Owner { get; set; }
        public decimal Price { get; set; }
        public ICollection<TripOrderRequest> TripOrderRequests { get; set; }
    }
}