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
    public static class CareersController
    {
        public static DataTable  GetCareerList()
        {
            return  DbProvider.Career.GetCareerList(); 
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
