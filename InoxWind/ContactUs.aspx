<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="ContactUs.aspx.cs" Inherits="InoxWind.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .submit-buttons .btnContactUSCss {
            height: 50px;
            margin-top: 15px;
        }

            .submit-buttons .btnContactUSCss:hover {
                background: var(--gradient1);
                color: #fff;
                border: none;
            }

        .mainform .inputbox {
            padding-bottom: 20px;
        }
    </style>
    <script src="https://www.google.com/recaptcha/api.js" async defer></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="application-form contact-form">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings center-text centered-headings">
                    <p class="main-title"><span>Contact Us</span></p>
                    <p>
                        Got questions? Fill out the form below, and our team will get back to you promptly with the answers you need. We're here to help!
                    </p>
                </div>
                <form id="form1" runat="server">
                    <%--<asp:ScriptManager ID="ScriptManager1" runat="server" />
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>--%>
                            <div class="row mainform">
                                <div class="col-lg-6 col-sm-6 col-12  inputbox">
                                    <label>
                                        Full Name *<asp:TextBox runat="server" ID="txtName" placeholder="Enter your full name" />
                                    </label>
                                    <span><asp:Label ForeColor="Red" ID="lblErroName" runat="server" /></span>
                                </div>
                                <div class="col-lg-6 col-sm-6 col-12  inputbox">
                                    <label>
                                        Email * <asp:TextBox runat="server" ID="txtemail" placeholder="Enter your email" />
                                    </label>
                                         <span> <asp:Label ForeColor="Red" ID="lblErrorEmail" runat="server" /></span>
                                </div>
                                <div class="col-lg-6 col-sm-6 col-12  inputbox">
                                    <label>   Mobile Number *  <asp:TextBox runat="server" ID="txtMobileNo" ClientIDMode="Static" placeholder="Enter your mobile number" onkeypress="allowOnlyNumbers(event)" TextMode="Number" MaxLength="10" />
                                    </label>
                                     <span> <asp:Label ForeColor="Red" ID="lblerroMobile" runat="server" /></span>
                                </div>
                                <div class="col-lg-6 col-sm-6 col-12  inputbox">
                                    <label>  Nature of Enquiry *
                                 <asp:DropDownList runat="server" class="form-control" ID="ddlNatureEnquiry">
                                     <asp:ListItem Text="SELECT" Value="0" />
                                     <asp:ListItem Text="20" Value="20" />
                                     <asp:ListItem Text="21" Value="21" />
                                     <asp:ListItem Text="22" Value="22" />
                                     <asp:ListItem Text="23" Value="23" />
                                     <asp:ListItem Text="24" Value="24" />
                                 </asp:DropDownList>

                                    </label>
                                    <span>
                                        <asp:Label ForeColor="Red" ID="lblNatture" runat="server" /></span>

                                </div>
                                <div class="col-12  inputbox">
                                    <label>
                                        Description *   <asp:TextBox runat="server" TextMode="MultiLine" Rows="5" Columns="30" ID="txtdescription" placeholder="Type your queries, concerns or feedback"></asp:TextBox>

                                    </label>
                                        <span><asp:Label ForeColor="Red" ID="lblErrorDesc" runat="server" /></span>
                                </div>
                                <div class="submit-buttons">

                                    <div class="g-recaptcha" data-sitekey="6LdKhWwqAAAAAOpuoMkbK9M1QFO8FkS-sDs8v2nI"></div>
                                    <br />
                                    <asp:Button Text="Send Enquiry" runat="server" CssClass="main-button btnContactUSCss" ID="btnsendEnquire" OnClick="btnsendEnquire_Click"></asp:Button>

                                </div>

                            </div>
                     <%--   </ContentTemplate>
                    </asp:UpdatePanel>--%>
                </form>
            </div>
        </div>
    </section>
    <script> 
        function allowOnlyNumbers(event) {
            const key = event.key;
            // Allow numbers, backspace, tab, and arrow keys
            if (!/^[0-9]$/.test(key) && key !== 'Backspace' && key !== 'Tab' && !['ArrowLeft', 'ArrowRight'].includes(key)) {
                event.preventDefault(); // Prevent the default action if the key is not a number
            }
        }
        document.getElementById('txtMobileNo').addEventListener('input', function () {
            let value = this.value;
            if (value.length > 10) {
                this.value = value.substring(0, 10);
            }
        });
    </script>
     
</asp:Content>
