using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace WebApplication1.Models
{
    public class User : UserData
    {
        public int UserID { get; set; }
        
    }

    public class UserData
    {
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }

    public class UserContext : DbContext {
        public DbSet<User> Users { get; set; }
    }
}