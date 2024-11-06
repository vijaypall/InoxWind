<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Editor.Master" ValidateRequest="false" AutoEventWireup="true" ClientIDMode="Static" CodeBehind="EditHtmlEditor.aspx.cs" Inherits="InoxWind.Admin.EditHtmlEditor1" %>
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
                    <a href="HtmlEditor.aspx">Editor</a>
                </li>
                <li class="active">Edit Editor</li>
            </ul>
                <!-- /.breadcrumb -->
 
                <!-- /.nav-search -->
            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Editor</h1>
                </div>
                <!-- /.page-header -->

                <div class="row">
                    <div class="col-xs-12">
                        <form runat="server">
                            <div class="wysiwyg-editor" id="editor1" runat="server"></div>
                            <asp:HiddenField ID="hdHtmleditor" runat="server" />
                            <div class="hr hr-double dotted"></div>
                            <div class="row">
                                <div class="form-group col-sm-4">
                                    <label>Upload Image</label>
                                    <asp:FileUpload runat="server" ID="FileUploader" AllowMultiple="false" />
                                       <span>The height*width ratio must be 570*384.</span>
                                       <br /> <span> <asp:Label Text="" ID="lblerrorUpload" runat="server" ForeColor="Red" />  </span>


                                </div>
                                <div class="form-group col-sm-4">
                                    <label>Page*</label>

                                    <asp:DropDownList runat="server" class="form-control" ID="DdlPageSelect">
                                        <asp:ListItem Text="SELECT" Value="0" />
                                        <asp:ListItem Text="HomePage" Value="HomePage" />
                                        <asp:ListItem Text="Infrastructure" Value="Infrastructure" />
                                        <asp:ListItem Text="Operations" Value="Operations" />
                                    </asp:DropDownList>
                                    <span>
                                        <asp:Label Text="" ID="lblPageSelecterror" ForeColor="Red" runat="server" /></span>
                                </div>
                                <div class="form-group col-sm-4">
                                    <label>Know More Url</label>
                                    <asp:TextBox runat="server" ID="txtKnowMore" CssClass="form-control" />
                                    <span>
                                        <asp:Label Text="" ID="lblErrorKnowMore" ForeColor="Red" runat="server" /></span>
                                </div>
                            </div>
                            <asp:Button Text="Submit" ID="btnSubmit" runat="server" class="btn btn-sm btn-success" OnClick="btnSubmit_Click1"
                                OnClientClick="return CallJavaScript();" />

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
         $('#Editor').addClass('active');
         function CallJavaScript() {
             var editorContent = $('#editor1').html();
             $('#hdHtmleditor').val(editorContent);
             return true;
         }
     </script>
</asp:Content>
