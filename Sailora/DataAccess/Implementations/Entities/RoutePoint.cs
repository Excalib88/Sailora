using System;

namespace BoatService.Web.DataAccess.Implementations.Entities
{
    public class RoutePoint : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Guid? RouteId { get; set; }
    }
}