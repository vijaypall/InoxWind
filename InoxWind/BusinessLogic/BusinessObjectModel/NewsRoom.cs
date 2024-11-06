using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessObjectModel
{
    public class NewsRoom
    {
        public int Id { get; set; }
        public string ParticularsORNewspaper { get; set; }
        public string NewsDATE { get; set; }
        public string NewsDoc { get; set; }
        public string NewsType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public bool IsActive { get; set; }

    }
}
