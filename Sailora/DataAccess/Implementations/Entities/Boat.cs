using System.Collections.Generic;

namespace BoatService.Web.DataAccess.Implementations.Entities
{
    public class Boat: BaseEntity
    {
        public Skipper Skipper { get; set; }
        public int CabinQty { get; set; }
    }
}