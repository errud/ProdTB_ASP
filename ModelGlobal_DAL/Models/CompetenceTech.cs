using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DAL.Models
{
    public class CompetenceTech    
    {
        public int IdSk { get; set; }
        public string SkillTyp { get; set; }
        public string SkillName { get; set; }
        public DateTime SkillYear { get; set; }
        public string SkillLevel { get; set; }
        public int IdPers { get; set; }
        public int StatusId { get; set; }
    }
}
