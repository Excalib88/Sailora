using System.Collections;
using System.Collections.Generic;

namespace BoatService.Web.DataAccess.Implementations.Entities
{
    public class Route : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<RoutePoint> RoutePoints { get; set; }
    }
}