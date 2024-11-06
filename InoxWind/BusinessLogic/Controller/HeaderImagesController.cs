using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace BusinessLogic.Controller
{
  public class HeaderImagesController
    {
        public static List<HeaderImage> GetHeaderImagesList()
        {
           List<HeaderImage> lstHeaderImg = DbProvider.HeaderImage.GetHeaderImagesList();
            return lstHeaderImg;
        }
        public static int InsertHeaderImages(HeaderImage headerimages)
        {
            return DbProvider.HeaderImage.InsertHeaderImages(headerimages);
        } 
        public static int UpdateHeaderImages(HeaderImage headerimages)
        {
            return DbProvider.HeaderImage.UpdateHeaderImages(headerimages);
        }
        public static int DeleteHeaderImages(HeaderImage headerimages)
        {
            return DbProvider.HeaderImage.DeleteHeaderImages(headerimages);
        }
        public static HeaderImage GetHeaderImagesById(int Id)
        { return DbProvider.HeaderImage.GetHeaderImagesById(Id); }
        public static List<WebsitePage> GetWebPageList() { return DbProvider.HeaderImage.GetWebPageList(); }
    }
}
