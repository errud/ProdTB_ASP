using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DAL.Models
{
    public class Education
    {
        public int IdEdu { get; set; }
        public string SchoolName { get; set; }
        public string SchoolScience { get; set; }
        public string Degree { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int IdPers { get; set; }
    }
}
