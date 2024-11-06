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
    public abstract class LatestNewsProvider
    {
        public static LatestNewsProvider _instance = null;
        static LatestNewsProvider()
        {
            if (_instance == null)
                _instance = (LatestNewsProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["LatestNews"].ToString()));
        }
        #region Abstract Class 
        public abstract LatestNews GetLatestNewsById(int Id);
        public abstract DataTable GetLatestNewsList();
        public abstract int InsertLatestNews(LatestNews latestNews);
        public abstract int UpdateLatestNews(LatestNews latestNews);
        public abstract int DeleteLatestNews(LatestNews latestNews);
        public abstract DataTable GetLatestNewsLastFive();
        #endregion
    }
}
