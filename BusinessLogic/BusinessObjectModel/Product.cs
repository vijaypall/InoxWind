using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessObjectModel
{
    public class Product
    {
        public int Id { get; set; }
        public int PID { get; set; }
        public string HtmlText { get; set; }
        public string Image { get; set; }
        public int TecDataID { get; set; }
        public int TecItemID { get; set; }
        public string TecItemValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public bool IsActive { get; set; }

        //Other

        public string ProductDesc { get; set; }
        public string TechDataDesc { get; set; }
        public string TechItemDesc { get; set; }
    }
}
