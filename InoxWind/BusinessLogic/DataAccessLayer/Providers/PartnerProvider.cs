using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;

namespace BusinessLogic.DataAccessLayer.Providers
{
    public abstract class PartnerProvider
    {
        public static PartnerProvider _instance = null;
        static PartnerProvider()
        {
            if (_instance == null)
                _instance = (PartnerProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["Partner"].ToString()));
        }
        public abstract DataTable GetPartnerList();
        public abstract int InsertPartner(Partner partner);
        public abstract int DeletePartner(Partner partner);
        public abstract Partner GetBannerById(int Id);
    }
}
