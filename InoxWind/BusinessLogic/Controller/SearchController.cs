using BusinessLogic.DataAccessLayer.Providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Controller
{
   public static class SearchController
    {
        public static DataTable GetSearchByText(string searchText) { return DbProvider.Search.GetSearchByText(searchText); }
    }
}
