using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Controller
{
   public class BannersController
    {
        public static DataTable  GetBannerList()
        {
            return DbProvider.Banner.GetBannerList();
         //   return lstCareer;
        }
        public static int InsertBanner(Banner Banner) { return DbProvider.Banner.InsertBanner(Banner); }
        public static int UpdateBanner(Banner Banner) { return DbProvider.Banner.UpdateBanner(Banner); }
        public static int DeleteBanner(Banner Banner) { return DbProvider.Banner.DeleteBanner(Banner); }
        public static Banner GetBannerById(int Id) { return DbProvider.Banner.GetBannerById(Id); }
    }
}
