using BusinessLogic.BusinessObjectModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataAccessLayer.Providers
{
   public abstract class BannerProvider
    {
        public static BannerProvider _instance = null;
        static BannerProvider()
        {
            if (_instance == null)
                _instance = (BannerProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["Banner"].ToString()));
        }
        public abstract DataTable  GetBannerList();
        public abstract int InsertBanner(Banner Banner);
        public abstract int UpdateBanner(Banner Banner);
        public abstract int DeleteBanner(Banner Banner);
        public abstract Banner GetBannerById(int Id);
    }
}
