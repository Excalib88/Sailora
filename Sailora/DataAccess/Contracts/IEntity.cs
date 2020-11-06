using System;

namespace BoatService.Web.DataAccess.Contracts
{
    public interface IEntity
    {
        Guid Id { get; set; }
        bool IsActive { get; set; }
        DateTime CreationDate { get; set; }
    }
}