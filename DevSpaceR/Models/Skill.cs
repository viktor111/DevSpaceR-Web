using DevSpaceR.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSpaceR.Models
{
    public class Skill
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public IEnumerable<TechnologySkill> TechnologySkill { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastEdit { get; set; }
    }
}
