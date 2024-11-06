using BusinessLogic.BusinessObjectModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataAccessLayer.Providers
{
    public abstract class HeaderImageProvider
    {
        public static HeaderImageProvider _instance = null;
        static HeaderImageProvider()
        {
            if (_instance == null)
                _instance = (HeaderImageProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["HeaderImage"].ToString()));
        }  

        public abstract List<HeaderImage> GetHeaderImagesList();
        public abstract int InsertHeaderImages(HeaderImage headerimages);
        public abstract int UpdateHeaderImages(HeaderImage headerimages);
        public abstract int DeleteHeaderImages(HeaderImage headerimages);
        public abstract HeaderImage GetHeaderImagesById(int Id);
        public abstract List<WebsitePage> GetWebPageList();
    }
}
