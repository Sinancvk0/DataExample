using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftitoProject_01.Entity
{
    public class User:BaseModel
    {
  
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public Personal Personal { get; set; }
        public Student Student { get; set; }
        public Jobber Jobber { get; set; }
    }
}
