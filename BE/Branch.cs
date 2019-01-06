using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {
        public int ID { get;  set; } 
        public string PrivateName { get; set; }  
        public string Family { get; set; }  
        public string Gender { get; set; }  
        public string PhoneNumber{ get; set; } 
        public string Address { get; set; } 
        public string YearsOfBirth{ get; set; }    
        public string CarType { get; set; }
        public string GearType { get; set; }
        public string SchoolName { get; set; }
        public string TeachName { get; set; }
        public string NumLessons { get; set; } 
        public override string ToString()
        {
            return branchNumber + " " + branchName;
        }
    }
}
