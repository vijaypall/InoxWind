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
   public static class DailyNewsController
    {
        public static int DeleteDailyNews(DailyNews dailyNews) { return DbProvider.DailyNews.DeleteDailyNews(dailyNews); }
        public static DailyNews GetDailyNewsById(int Id) { return DbProvider.DailyNews.GetDailyNewsById(Id); }
        public static DataTable GetDailyNewsList() { return DbProvider.DailyNews.GetDailyNewsList(); }
        public static int InsertDailyNews(DailyNews dailyNews) { return DbProvider.DailyNews.InsertDailyNews(dailyNews); }
        public static int UpdateDailyNews(DailyNews dailyNews) { return DbProvider.DailyNews.UpdateDailyNews(dailyNews); }
        public static List<DailyNews> GetPressDalilyNews(int Id) { return DbProvider.DailyNews.GetPressDalilyNews(Id); }
    }
}
