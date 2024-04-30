using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace InventoryProject.Models
{
    public class AppUser : IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public int PhoneNumber { get; set; }
        
    }
}
