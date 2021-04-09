using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSpaceR.Models
{
    public class TechnologySkill
    {
        public int TechnologyId { get; set; }

        public int SkillId { get; set; }

        public Skill Skill { get; set; }

        public Technology Technology { get; set; }
    }
}
