using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;

namespace BusinessLogic.DataAccessLayer.Providers
{
    public abstract class HtmlEditorProvider
    {
        public static HtmlEditorProvider _instance = null;
        static HtmlEditorProvider()
        {
            if (_instance == null)
                _instance = (HtmlEditorProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["HtmlEditor"].ToString()));
        }
        public abstract int DeleteRecord(HtmlEditor htmlEditor);
        public abstract HtmlEditor GetRecordById(int Id);
        public abstract DataTable GetRecordList();
        public abstract int InsertRecord(HtmlEditor htmlEditor);
        public abstract int UpdateRecord(HtmlEditor htmlEditor);
    }
}
