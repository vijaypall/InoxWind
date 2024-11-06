using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind.Error
{
    public partial class GeneralError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            Exception exception = Server.GetLastError();
            if (exception != null)
            { 
            }
             
            Server.ClearError();
        }

        // Optional: A method for logging the error
        private void LogError(Exception exception)
        {
            // Implement your logging logic here (e.g., write to a file, database, etc.)
        }
    }
}