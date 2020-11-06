using System;

namespace BoatService.Web.DataAccess.Implementations.Entities
{
    public class Person: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
    }
}