using System;
using BoatService.Web.DataAccess.Contracts;

namespace BoatService.Web.DataAccess.Implementations.Entities
{
    public class BaseEntity: IEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
    }
}