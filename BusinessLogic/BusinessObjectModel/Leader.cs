using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessObjectModel
{
    public class Leader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Category { get; set; }
        public string LinkedinUrl { get; set; }
        public string PopupContent { get; set; }
        public bool OpenPopup { get; set; }
        public string ProfileImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}
