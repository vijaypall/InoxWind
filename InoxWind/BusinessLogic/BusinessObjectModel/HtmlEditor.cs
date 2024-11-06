using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessObjectModel
{
   public class HtmlEditor
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string HtmlText { get; set; }
        public string SideImage { get; set; }
        public string KnowMoreLink { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}
