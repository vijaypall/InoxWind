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
   public abstract class DailyNewsProvider
    {
        public static DailyNewsProvider _instance = null;
        static DailyNewsProvider()
        {
            if (_instance == null)
                _instance = (DailyNewsProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["DailyNews"].ToString()));
        }
        #region Abstract Class

        public abstract int DeleteDailyNews(DailyNews dailyNews);
        public abstract DailyNews GetDailyNewsById(int Id);
        public abstract DataTable GetDailyNewsList();
        public abstract int InsertDailyNews(DailyNews dailyNews);
        public abstract int UpdateDailyNews(DailyNews dailyNews);
        public abstract List<DailyNews> GetPressDalilyNews(int Id);
        #endregion
    }
}
