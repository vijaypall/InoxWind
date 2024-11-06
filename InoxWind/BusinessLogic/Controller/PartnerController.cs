using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;

namespace BusinessLogic.Controller
{
  public static  class PartnerController
    {
        public static DataTable GetPartnerList()
        {
            return DbProvider.Partner.GetPartnerList();
        }
        public static int InsertPartner(Partner partner) { return DbProvider.Partner.InsertPartner(partner); }
        public static int DeletePartner(Partner partner) { return DbProvider.Partner.DeletePartner(partner); }
        public static Partner GetBannerById(int Id) { return DbProvider.Partner.GetBannerById(Id); }
    }
}
