<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Editor.Master" ClientIDMode="Static" ValidateRequest="false" AutoEventWireup="true" CodeBehind="EditBanner.aspx.cs" Inherits="InoxWind.Admin.EditBanner1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                <li>
                    <i class="ace-icon fa fa-home home-icon"></i>
                    <a href="#">Website Home</a>
                </li>
                <li> 
                    <a href="Banner.aspx">Banner</a>
                </li>
                <li class="active">Edit Banner</li>
            </ul>
                <!-- /.breadcrumb -->

                 
                <!-- /.nav-search -->
            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Edit Banner</h1>
                </div>
                <!-- /.page-header -->

                <div class="row">
                    <div class="col-xs-12">
                        <form runat="server">
                            <div class="wysiwyg-editor" id="editor1" runat="server"></div>
                            <asp:HiddenField ID="hdHtmleditor" runat="server" />
                            <div class="hr hr-double dotted"></div>
                            <div class="row">
                                <div class="form-group col-sm-3">
                                    <label>Banner Order*</label> 
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="DDlBannerOrder" Enabled="false">
                                        <asp:ListItem Text="SELECT" Value="0" />
                                        <asp:ListItem Text="1" Value="1" />
                                        <asp:ListItem Text="2" Value="2" />
                                        <asp:ListItem Text="3" Value="3" />
                                        <asp:ListItem Text="4" Value="4" />
                                        <asp:ListItem Text="5" Value="5" />
                                    </asp:DropDownList>
                                    <span>
                                        <asp:Label Text="" ID="lblerrorBannerOrder" ForeColor="Red" runat="server" /></span>
                                </div>

                                <div class="form-group  col-sm-3">
                                    <label>Banner Url</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txthref" />
                                </div>
                                <div class="form-group  col-sm-6">
                                    <label>Upload Banner*</label>

                                    <asp:FileUpload runat="server" ID="ftpBannerUpload" AllowMultiple="false" />
                                       <span>The height*width ratio must be 550*1440.</span>
                                                   <br /> <span>
                                                        <asp:Label Text="" ID="lblerrorUpload" runat="server" ForeColor="Red" /></span>
                                </div>

                            </div>
                            <asp:Button Text="Submit" ID="btnSubmit" runat="server" class="btn btn-sm btn-success"
                                OnClientClick="return CallJavaScript();" OnClick="btnSubmit_Click" />

                            <asp:Button Text="Back" ID="Back" runat="server" class="btn btn-sm btn-danger" OnClientClick="window.history.go(-1); return false;" />

                            <!-- PAGE CONTENT ENDS -->
                        </form>
                        <!-- PAGE CONTENT ENDS -->
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.page-content -->
        </div>
    </div>
    <!-- /.main-content -->
    <script type="text/javascript">
        $('#WebsiteHome').addClass('active open');
        $('#Banner').addClass('active');
        function CallJavaScript() {
            var editorContent = $('#editor1').html();
            $('#hdHtmleditor').val(editorContent);
            return true;
        }
    </script>
</asp:Content>
