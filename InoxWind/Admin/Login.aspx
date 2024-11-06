<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="InoxWind.Admin.Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta charset="utf-8" />
    <title>Dashboard - Ace Admin</title>

    <meta name="description" content="User login page" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />

    <!-- bootstrap & fontawesome -->
    <link rel="stylesheet" href="assets/css/bootstrap.min.css" />
    <link rel="stylesheet" href="assets/font-awesome/4.5.0/css/font-awesome.min.css" />

    <!-- text fonts -->
    <link rel="stylesheet" href="assets/css/fonts.googleapis.com.css" />

    <!-- ace styles -->
    <link rel="stylesheet" href="assets/css/ace.min.css" />

    <style type="text/css">
        .login-box .toolbar {
            padding: 10px;
        }

        .login-box .form-control {
            height: 40px;
        }

        .login-box .input-icon > .ace-icon {
            top: 4px;
        }

        .login-layout .widget-box .widget-main {
            padding: 25px 36px 20px;
        }

        .light-login {
            padding-top: 100px;
        }
    </style>

</head>

<body class="login-layout light-login">
    <div class="main-container">
        <div class="main-content">
            <div class="row">
                <div class="col-sm-10 col-sm-offset-1">
                    <div class="login-container">
                        <div class="center">
                            <h1>
                                <span class="red">Admin</span>
                                <span id="id-text2">Login</span>
                            </h1>
                        </div>

                        <div class="space-6"></div>

                        <div class="position-relative">
                            <div id="login-box" class="login-box visible widget-box no-border">
                                <div class="widget-body">
                                    <div class="widget-main">

                                        <div class="space-6">
                                             <p>Time remaining: <span id="timer"></span></p></div>

                                        <form runat="server">
                                            <fieldset>
                                                <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <%--		<input type="text" class="form-control" placeholder="Enter email id" />--%>
                                                        <asp:TextBox  ID="txtEmailId" runat="server" Text="Vijaypall1993@gmail.com" class="form-control" placeholder="Enter email id" />
                                                        <i class="ace-icon fa fa-envelope"></i>
                                                        <span>
                                                            <asp:Label ForeColor="Red" ID="lblerroremail" runat="server"></asp:Label></span>
                                                    </span>
                                                </label>

                                                <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <%--<input type="password" class="form-control" placeholder="Enter OTP" />--%>
                                                        <asp:TextBox  ID="txtpassword" Text="123456"   TextMode="Password" runat="server" class="form-control" placeholder="Enter OTP" />

                                                        <i class="ace-icon fa fa-key"></i>

                                                        <span>
                                                            <asp:Label ForeColor="Red" ID="lblerrorpassword" runat="server"></asp:Label></span>
                                                    </span>
                                                </label>

                                                <div class="space"></div>

                                                <div class="clearfix">
                                                    <%--<button type="button" class="width-40 btn btn-sm btn-primary">
															<span class="bigger-110">Generate OTP</span>
														</button>--%>
                                                    <asp:Button runat="server" ID="btnGenerateOtp" Text="Generate OTP" class="width-40 btn btn-sm btn-primary" OnClick="btnGenerateOtp_Click"
                                                       OnClientClick="return CallJavaScript();"
                                                        />
                                                    <%--<button type="button" class="width-40 pull-right btn btn-sm btn-success">
															<span class="bigger-110">Login</span>
															
														</button>--%>
                                                    <asp:Button runat="server" ID="btnLogin" Text="Login" class="width-40 pull-right btn btn-sm btn-success" OnClick="btnLogin_Click" />
                                                    <br /><div class="row"></div>
                                                   <div class="row" style="text-align:center"> <asp:Label ForeColor="Red" ID="lblInvalidLogin" runat="server"></asp:Label></div>
                                                </div>

                                                <div class="space-4"><span>
                                                    </span></div>
                                            </fieldset>
                                        </form>

                                        <div class="space-6"></div>

                                    </div>
                                    <!-- /.widget-main -->

                                    <div class="toolbar clearfix">
                                    </div>
                                </div>
                                <!-- /.widget-body -->
                            </div>
                            <!-- /.login-box -->

                        </div>
                        <!-- /.position-relative -->

                    </div>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.main-content -->
    </div>
    <!-- /.main-container -->

    <!-- basic scripts -->

    <!--[if !IE]> -->
    <script src="assets/js/jquery-2.1.4.min.js"></script>

    <script type="text/javascript">
        if ('ontouchstart' in document.documentElement) document.write("<script src='assets/js/jquery.mobile.custom.min.js'>" + "<" + "/script>");
    </script>

    <!-- inline scripts related to this page -->
    <script type="text/javascript">
        jQuery(function ($) {
            $(document).on('click', '.toolbar a[data-target]', function (e) {
                e.preventDefault();
                var target = $(this).data('target');
                $('.widget-box.visible').removeClass('visible');//hide others
                $(target).addClass('visible');//show target
            });
        });



        //you don't need this, just used for changing background
        jQuery(function ($) {
            $('#btn-login-dark').on('click', function (e) {
                $('body').attr('class', 'login-layout');
                $('#id-text2').attr('class', 'white');
                $('#id-company-text').attr('class', 'blue');

                e.preventDefault();
            });
            $('#btn-login-light').on('click', function (e) {
                $('body').attr('class', 'login-layout light-login');
                $('#id-text2').attr('class', 'grey');
                $('#id-company-text').attr('class', 'blue');

                e.preventDefault();
            });
            $('#btn-login-blur').on('click', function (e) {
                $('body').attr('class', 'login-layout blur-login');
                $('#id-text2').attr('class', 'white');
                $('#id-company-text').attr('class', 'light-blue');

                e.preventDefault();
            });

        });
    </script>
    <script>
        function CallJavaScript() {
            let otpExpiration = new Date('@DateTime.UtcNow.AddMinutes(10).ToString("yyyy-MM-ddTHH:mm:ssZ")').getTime();

            function startTimer() {
                const timerInterval = setInterval(() => {
                    const now = new Date().getTime();
                    const distance = otpExpiration - now;

                    // Time calculations
                    const minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
                    const seconds = Math.floor((distance % (1000 * 60)) / 1000);

                    // Display the result
                    document.getElementById("timer").innerHTML = minutes + "m " + seconds + "s ";

                    // If the countdown is over, stop the timer
                    if (distance < 0) {
                        clearInterval(timerInterval);
                        document.getElementById("timer").innerHTML = "EXPIRED";
                    }
                }, 1000);
            }

            // Start the timer on page load
            window.onload = startTimer;
        }
    </script>
</body>
</html>
