using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;

namespace BusinessLogic.Controller
{
    public class CareersController
    {
        public static List<Career> GetCareerList()
        {
            List<Career> lstCareer = DbProvider.Career.GetCareerList();
            return lstCareer;
        }
        public static int InsertCareer(Career Career)
        {
            return DbProvider.Career.InsertCareer(Career);
        }
        public static int UpdateCareer(Career Career)
        {
            return DbProvider.Career.UpdateCareer(Career);
        }
        public static int DeleteCareer(Career Career)
        {
            return DbProvider.Career.DeleteCareer(Career);
        }
        public static Career GetCareerbyId(int Id)
        { return DbProvider.Career.GetCareerbyId(Id); }
        //public static List<WebsitePage> GetWebPageList() { return DbProvider.HeaderImage.GetWebPageList(); }
    }
}
