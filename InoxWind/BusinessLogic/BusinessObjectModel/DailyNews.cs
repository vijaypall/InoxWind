using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessObjectModel
{
   public class DailyNews
    {
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public string NewsHeading { get; set; }
        public string NewsContent { get; set; }
        public string NewsImage { get; set; }
        public string NewsLink { get; set; }
        public bool OpenMediaPopup { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public bool IsActive { get; set; }

    }
}
