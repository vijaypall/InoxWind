<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InternalError.aspx.cs" Inherits="InoxWind.Error.InternalError" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Internal Server Error</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            color: #333;
            text-align: center;
            padding-top: 100px;
        }

        .error-container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 4px;
        }

        h1 {
            color: #d9534f;
        }

        p {
            font-size: 16px;
        }

        a {
            color: #337ab7;
            text-decoration: none;
        }

            a:hover {
                text-decoration: underline;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="error-container">
            <h1>500 - Internal Server Error</h1>
            <p>Oops! Something went wrong on our end. Please try again later.</p>
            <p>If the issue persists, contact support.</p>
            <p><a href="/">Return to Home</a></p>
        </div>
    </form>
</body>
</html>
