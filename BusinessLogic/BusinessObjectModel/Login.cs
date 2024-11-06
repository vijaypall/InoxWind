using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessObjectModel
{
 public  class Login
    {
        public int LoginId { get; set; } 
        public string Name { get; set; } 
        public string EmailId { get; set; } 
        public string Password { get; set; }
        public string LoginIP { get; set; }
        public string LoginBrowser { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; }
    }
}
