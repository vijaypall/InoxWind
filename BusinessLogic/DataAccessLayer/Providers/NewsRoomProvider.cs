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
    public abstract class NewsRoomProvider
    {
        public static NewsRoomProvider _instance = null;
        static NewsRoomProvider()
        {
            if (_instance == null)
                _instance = (NewsRoomProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["NewsRoom"].ToString()));
        }
        #region Abstract Class

        public abstract int DeleteRecord(NewsRoom newsRoom);
        public abstract NewsRoom GetRecordById(int Id);
        public abstract DataTable GetRecordList();
        public abstract int InsertRecord(NewsRoom newsRoom);
        public abstract int UpdateRecord(NewsRoom newsRoom);
        public abstract List<NewsRoom> GetPressReleased(int Id, string NewsType);
        #endregion
    }
}
