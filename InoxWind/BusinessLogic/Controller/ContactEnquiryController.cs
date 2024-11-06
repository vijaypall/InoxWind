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
 public static   class ContactEnquiryController
    {
        public static DataTable GetContactList() { return DbProvider.ContactEnquiry.GetContactList(); }
        public static int InsertContact(ContactEnquiry ContactEnquiry) { return DbProvider.ContactEnquiry.InsertContact (ContactEnquiry); }
    }
}
