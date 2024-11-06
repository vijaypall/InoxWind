<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddDailyNews.aspx.cs" Inherits="InoxWind.Admin.AddDailyNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                    <a href="DailyNews.aspx">Daily News</a>
                </li>
                <li class="active">Add Latest News</li>
            </ul>
            <!-- /.breadcrumb -->

            <!-- /.nav-search -->
        </div>

        <div class="page-content">
            <div class="page-header">
                <h1>Add Daily News
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
                                                    <label>Channel Name*</label>
                                                    <asp:TextBox runat="server" ID="txtchannel" CssClass="form-control" />
                                                    <span>
                                                        <asp:Label Text="" ID="lblerrorchannel" ForeColor="Red" runat="server" /></span>
                                                </div>
                                                <div class="form-group col-sm-4">
                                                    <label>News Heading*</label>
                                                    <asp:TextBox runat="server" ID="txtNewsHeading" CssClass="form-control" />
                                                    <span>
                                                        <asp:Label Text="" ID="lblErrorNewshading" ForeColor="Red" runat="server" /></span>
                                                </div>
                                                <div class="form-group col-sm-4">
                                                    <label>News Content*</label>

                                                    <asp:TextBox runat="server" ID="txtnewscontent" CssClass="form-control"  />
                                                    <span>
                                                        <asp:Label Text="" ID="lblErrorNewContent" runat="server" ForeColor="Red" /></span>
                                                </div>
                                                 <div class="form-group col-sm-4">
                                                    <label>News Url*</label>

                                                    <asp:TextBox runat="server" ID="txtNeewLink" CssClass="form-control" />
                                                    <span>
                                                        <asp:Label Text="" ID="lblerrorNewsLink" runat="server" ForeColor="Red" /></span>
                                                </div>
                                                <div class="form-group col-sm-4">
                                                    <label>News Image*</label>

                                                    <asp:FileUpload runat="server" ID="ftpDailNews" AllowMultiple="false" />
                                                    <span>Height*Width ratio should be 157*286</span>
                                                    <span>
                                                        <asp:Label Text="" ID="lblerroruploadlogo" runat="server" ForeColor="Red" /></span>
                                                </div>
                                                
                                                <div class="form-group col-sm-4" style="margin-top: 20px">
                                                    
                                                        <label class="block">
                                                            <%--<input name="form-field-checkbox" type="checkbox" class="ace input-lg">--%>
                                                            <asp:CheckBox ID="chkmediapoup" runat="server" name="form-field-checkbox"  class="ace" />
                                                           <span class="lbl">Open Media Poup</span>
                                                        </label> 
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
        $('#DailyNews').addClass('active');
    </script>
</asp:Content>
