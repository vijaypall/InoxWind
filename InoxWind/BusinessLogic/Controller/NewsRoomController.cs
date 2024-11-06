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
    public static class NewsRoomController
    {
        public static int ActiveDectiveRecord(NewsRoom newsRoom) { return DbProvider.NewsRoom.ActiveDectiveRecord(newsRoom); }
        public static NewsRoom GetRecordById(int Id) { return DbProvider.NewsRoom.GetRecordById(Id); }
        public static DataTable GetRecordList() { return DbProvider.NewsRoom.GetRecordList(); }
        public static int InsertRecord(NewsRoom newsRoom) { return DbProvider.NewsRoom.InsertRecord(newsRoom); }
        public static int UpdateRecord(NewsRoom newsRoom) { return DbProvider.NewsRoom.UpdateRecord(newsRoom); }
        public static List<NewsRoom> GetPressReleased(int Id, string NewsType) { return DbProvider.NewsRoom.GetPressReleased(Id, NewsType); }
    }
}
