using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataAccessLayer.Providers
{
    public abstract class SearchProvider
    {
        public static SearchProvider _instance = null;
        static SearchProvider()
        {
            if (_instance == null)
                _instance = (SearchProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["Search"].ToString()));
        }

        public abstract DataTable GetSearchByText(string searchText);
    }
}
