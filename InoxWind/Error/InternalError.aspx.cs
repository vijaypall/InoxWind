using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind.Error
{
    public partial class InternalError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Capture the last error
            Exception exception = Server.GetLastError();
            if (exception != null)
            {
                // Log the error details (optional)
                LogError(exception);
            }

            // Clear the error to prevent duplicate logging
            Server.ClearError();
        }

        // Method to log the error details (optional)
        private void LogError(Exception exception)
        {
            // Implement your logging mechanism here (e.g., log to a file, database, etc.)
        }
    }
}