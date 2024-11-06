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
   public static class LatestNewsController
    {
        public static LatestNews GetLatestNewsById(int Id) { return DbProvider.LatestNews.GetLatestNewsById(Id); }
        public static DataTable GetLatestNewsList() { return DbProvider.LatestNews.GetLatestNewsList(); }
        public static int InsertLatestNews(LatestNews latestNews){ return DbProvider.LatestNews.InsertLatestNews(latestNews); }
        public static int UpdateLatestNews(LatestNews latestNews) { return DbProvider.LatestNews.UpdateLatestNews(latestNews); }

        public static int DeleteLatestNews(LatestNews latestNews) { return DbProvider.LatestNews.DeleteLatestNews(latestNews); }
        public static DataTable GetLatestNewsLastFive() { return DbProvider.LatestNews.GetLatestNewsLastFive(); }
    }
}
