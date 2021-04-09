using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSpaceR.Models
{
    public class ApplicationUser : IdentityUser
    {
        public override int Id { get; set; }

        public string Name { get; set; }

        public override string PhoneNumber { get; set; }

        public string Country { get; set; }

        public string Description { get; set; }

        public IEnumerable<Skill> Skills { get; set; }

        public string GitHub { get; set; }

        public string LinkedIn { get; set; }

        public override string Email { get; set; }
    }
}