using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessObjectModel
{
    public class Banner
    {
        public int Id { get; set; }
        public int BannerOrder { get; set; }
        public string BannerImage { get; set; } 
        public string PopupContent { get; set; }
        public string ReadmoreUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public bool IsActive { get; set; }


    }
}
