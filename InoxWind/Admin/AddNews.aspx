<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="InoxWind.Admin.AddNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--  <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            $('#<%= txtDate1.ClientID %>').datepicker({
                dateFormat: 'mm/dd/yy' // Customize date format
            });
            $("#spandiv").datepicker({
                dateFormat: 'mm/dd/yy' // Customize date format
            });

            $('.input-daterange').datepicker({ autoclose: true });
        });
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content-inner">
        <div class="breadcrumbs ace-save-state" id="breadcrumbs">
               <ul class="breadcrumb">
                <li>
                    <i class="ace-icon fa fa-home home-icon"></i>
                    <a href="#">NewsRoom</a>
                </li>
                <li>
                    <i class="ace-icon fa fa-home home-icon"></i>
                    <a href="News.aspx">News</a>
                </li>
                <li class="active">Add News</li>
            </ul>
            <!-- /.breadcrumb -->

            <!-- /.nav-search -->
        </div>

        <div class="page-content">
            <div class="page-header">
                <h1>Add News
                </h1>
            </div>
            <!-- /.page-header -->

            <div class="row">
                <div class="col-xs-12">
                    <!-- PAGE CONTENT BEGINS -->
                    <form role="form" runat="server">
                        <div class="row">
                            <!-- /.span -->
                            <div class="col-xs-12 col-sm-12">
                                <div class="widget-box">
                                    <div class="widget-header">
                                    </div>
                                    <div class="widget-body">
                                        <div class="widget-main">
                                            <div class="row">
                                                <div class="form-group col-sm-4">
                                                    <label>News Type*</label>
                                                    <asp:DropDownList runat="server" class="form-control" ID="ddlPartnerType">
                                                        <asp:ListItem Text="SELECT" Value="0" />
                                                        <asp:ListItem Text="Press Releases" Value="Press Releases" />
                                                        <asp:ListItem Text="Notice of Board Meeting" Value="Notice of Board Meeting" />
                                                        <asp:ListItem Text="Financials Results" Value="Financials Results" />
                                                        <asp:ListItem Text="Notice to Shareholders" Value="Notice to Shareholders" />
                                                    </asp:DropDownList>
                                                    <span>
                                                        <asp:Label Text="" ID="lblErrorpartner" ForeColor="Red" runat="server" /></span>
                                                </div>
                                                <div class="form-group col-sm-4">
                                                    <label>Upload News Document*</label>
                                                    <asp:FileUpload runat="server" ID="ftpDocUpload" AllowMultiple="false" />
                                                           <span>The uploaded document must be in PDF format.</span><br />
                                                    <span>
                                                        <asp:Label Text="" ID="lblerroruDoc" runat="server" ForeColor="Red" /></span>
                                                </div>
                                                <div class="form-group col-sm-4">
                                                    <label>Particulars/Newspaper*</label>
                                                    <asp:TextBox runat="server" ID="txtParticulars" CssClass="form-control" />
                                                    <span>
                                                        <asp:Label Text="" ID="lblerrorParticulars" runat="server" ForeColor="Red" /></span>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="form-group col-sm-4">
                                                    <label>News Date*</label>
                                                    <div class="input-group">
                                                        <asp:TextBox runat="server" ID="txtnewsdate" CssClass="form-control date-picker" />
                                                        <span class="input-group-addon">
                                                            <i class="fa fa-calendar bigger-110"></i>
                                                        </span>
                                                    </div>
                                                    <span>
                                                        <asp:Label Text="" ID="lblnewserror" runat="server" ForeColor="Red" /></span>
                                                </div>
                                            </div>
                                            <asp:Button Text="Submit" ID="btSubmit" runat="server" class="btn btn-sm btn-success" OnClick="btSubmit_Click" />
                                            <asp:Button Text="Back" ID="Back" runat="server" class="btn btn-sm btn-danger" OnClientClick="window.history.go(-1); return false;" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.span -->

                        </div>
                        <!-- /.row -->

                    </form>

                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.page-content -->
    </div>

    <script type="text/javascript"> 
        $('#NewRoomUI').addClass('active open');
        $('#Newsli').addClass('active');

    </script>


</asp:Content>
