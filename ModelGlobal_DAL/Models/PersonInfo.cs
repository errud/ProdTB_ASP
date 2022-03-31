using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DAL.Models
{
    public class PersonInfo
    {
        public int IdPers { get; set; }  
        public string LastName { get; set; }       
        public string FirstName { get; set; }      
        public string Tel { get; set; }      
        public string Email { get; set; }        
        public string Address { get; set; }      
        public string Nationality { get; set; }         
        public int Age { get; set; }
        public string Strengths { get; set; }       
        public string Weaknesses { get; set; }
        public string Objective { get; set; }
        public string Profile { get; set; }
        public string SocialMedia { get; set; }
        public string InfoSup { get; set; }
    }
}
