using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessObjectModel
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int PID { get; set; }
        public string ProductName { get; set; }
        public string HtmlText { get; set; }
        public string SideImage { get; set; } 
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}
