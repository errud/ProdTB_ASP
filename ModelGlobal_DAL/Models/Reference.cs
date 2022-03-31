using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DAL.Models
{
    public class Reference
    {
        public int IdRef { get; set; }
        public string Fullname { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public DateOnly YearRef { get; set; }
        public int IdPers { get; set; }
    }
}
