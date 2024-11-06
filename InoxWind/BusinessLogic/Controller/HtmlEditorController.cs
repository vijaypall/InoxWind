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
    public static class HtmlEditorController
    {
        public static int DeleteRecord(HtmlEditor htmlEditor) { return DbProvider.HtmlEditor.DeleteRecord(htmlEditor); }
        public static HtmlEditor GetRecordById(int Id) { return DbProvider.HtmlEditor.GetRecordById(Id); }
        public static DataTable GetRecordList() { return DbProvider.HtmlEditor.GetRecordList(); }
        public static int InsertRecord(HtmlEditor htmlEditor) { return DbProvider.HtmlEditor.InsertRecord(htmlEditor); }
        public static int UpdateRecord(HtmlEditor htmlEditor) { return DbProvider.HtmlEditor.UpdateRecord(htmlEditor); }
    }
}
