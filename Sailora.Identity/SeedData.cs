using System.Collections.Generic;
using Sailora.Identity.Entities;

namespace Sailora.Identity
{
    public static class SeedData
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1, 
                FirstName = "Test", 
                LastName = "User", 
                Patronymic = "UserPatr", 
                Email = "test@mail.ru", 
                Username = "test", 
                Password = "test"
            }
        };
    }
}