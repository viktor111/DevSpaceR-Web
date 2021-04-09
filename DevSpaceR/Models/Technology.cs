using DevSpaceR.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSpaceR.Models
{
    public class Technology
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TechnologyCategoryType TechnologyCategory { get; set; }

        public IEnumerable<TechnologySkill> TechnologySkill { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastEdit { get; set; }


    }
}
