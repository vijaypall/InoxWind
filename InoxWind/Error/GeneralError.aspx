<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GeneralError.aspx.cs" Inherits="InoxWind.Error.GeneralError" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Oops! Something went wrong</title>
    <style>
        body { font-family: Arial, sans-serif; color: #333; text-align: center; padding-top: 100px; }
        .error-container { max-width: 600px; margin: 0 auto; padding: 20px; border: 1px solid #ddd; border-radius: 4px; }
        h1 { color: #d9534f; }
        p { font-size: 16px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="error-container">
            <h1>We're Sorry!</h1>
            <p>An unexpected error has occurred. Please try again later or contact support if the issue persists.</p>
            <p><a href="/">Return to Home</a></p>
        </div>
    </form>
</body>
</html>