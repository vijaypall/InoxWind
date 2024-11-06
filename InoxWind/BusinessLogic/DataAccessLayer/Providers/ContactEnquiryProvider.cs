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
   public abstract class ContactEnquiryProvider
    {
        public static ContactEnquiryProvider _instance = null;
        static ContactEnquiryProvider()
        {
            if (_instance == null)
                _instance = (ContactEnquiryProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["ContactEnquiry"].ToString()));
        }
        public abstract DataTable GetContactList();
        public abstract int InsertContact(ContactEnquiry ContactEnquiry);
    }
}
