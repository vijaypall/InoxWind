<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AnalystMeeting.aspx.cs" Inherits="InoxWind.AnalystMeeting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="inner-banner">
        <img src="./assets/images/investors-banner.jpg" alt="" />
    </section>
    <section class="investor-content-page">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <nav class="breadcrumbs mcontainer">
                    <ul>
                        <li>
                            <a href="Default.aspx" title="Home">Home</a>
                        </li>
                        /
                        <li>
                            <a href="investors.aspx" title="Investors">Investors</a>
                        </li>
                        /
                        <li>
                            <p>Analyst Meetings (Invite & Transcripts)</p>
                        </li>
                    </ul>
                </nav>
                <div class="page-content mcontainer">
                    <div class="mcontainer common-headings detail-content">
                        <p class="main-title"><span>Analyst Meeting</span></p>
                    </div>
                    <div class="content-table full-table">
                        <table>
                            <tbody>
                                <tr>
                                    <th>
                                        Name of the Investor
                                    </th>
                                    <th>
                                        Type of Investor (Buy Side/Sell Side)
                                    </th>
                                    <th>
                                        Type of Meeting
                                    </th>
                                    <th>
                                        Date of Meeting	
                                    </th>
                                    <th>
                                        Location
                                    </th>
                                    <th>
                                        PDF
                                    </th>
                                </tr>
                                <tr>
                                    <td>
                                        Various
                                    </td>
                                    <td>
                                        Buy Side/Sell Side
                                    </td>
                                    <td>
                                        Conference call by Company Management
                                    </td>
                                    <td>
                                        18th December, 2015
                                    </td>
                                    <td>
                                        Noida
                                    </td>
                                    <td onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                        <img src="./assets/images/pdf-icon.png" alt="">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Various
                                    </td>
                                    <td>
                                        Buy Side/Sell Side
                                    </td>
                                    <td>
                                        Conference call by Company Management
                                    </td>
                                    <td>
                                        18th December, 2015
                                    </td>
                                    <td>
                                        Noida
                                    </td>
                                    <td>
                                        -
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <div class="loadbuttons mcontainer">
                            <button class="main-button">
                                <span>Load More</span>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    
</asp:Content>
