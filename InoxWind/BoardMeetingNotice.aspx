<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BoardMeetingNotice.aspx.cs" Inherits="InoxWind.BoardMeetingNotice" %>
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
                            <p>Financial Information</p>
                        </li>
                    </ul>
                </nav>
                <div class="page-content mcontainer">
                    <div class="page-filters mcontainer">
                        <form>
                            <div class="filter-input">
                                <label>
                                    Financial Year
                                    <select required name="year">
                                        <option selected value="2023-24">2023-24</option>
                                        <option value="2022-23">2022-23</option>
                                        <option value="2021-20">2021-20</option>
                                        <option value="2020-21">2020-21</option>
                                    </select>
                                </label>
                            </div>
                            <div class="filter-input">
                                <label>
                                    Quater
                                    <select required name="quarter">
                                        <option selected  value="Any">Any</option>
                                        <option value="First">First</option>
                                        <option value="Second">Second</option>
                                        <option value="Third">Third</option>
                                        <option value="Fourth">Fourth</option>
                                    </select>
                                </label>
                            </div>
                            <div class="filter-input">
                                <button type="submit">Apply</button>
                            </div>
                        </form>
                    </div>
                    <div class="mcontainer common-headings detail-content">
                        <p class="main-title"><span>Notice of Board Meeting</span></p>
                    </div>
                    <div class="pdfs-list certificates-list">
                        <div class="w33 pdf-card">
                            <img src="./assets/images/pdf-icon.png" alt="" />
                            <div class="pdf-content">
                                <p>
                                    Financial Year - 2023-24 (Quarter 1)
                                </p>
                                <a href="#" title="" download="">
                                    <svg xmlns="http://www.w3.org/2000/svg" width="25" height="24" viewBox="0 0 25 24" fill="none">
                                        <path d="M20.5 14.6666V18.2222C20.5 18.6937 20.3127 19.1459 19.9793 19.4793C19.6459 19.8127 19.1937 20 18.7222 20H6.27778C5.80628 20 5.3541 19.8127 5.0207 19.4793C4.6873 19.1459 4.5 18.6937 4.5 18.2222V14.6666" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        <path d="M8.05566 10.2222L12.5001 14.6666L16.9446 10.2222" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        <path d="M12.5 14.6667V4" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                    </svg>
                                </a>
                            </div>
                        </div>
                        <div class="w33 pdf-card">
                            <img src="./assets/images/pdf-icon.png" alt="" />
                            <div class="pdf-content">
                                <p>
                                    Financial Year - 2023-24 (Quarter 2)
                                </p>
                                <a href="#" title="" download="">
                                    <svg xmlns="http://www.w3.org/2000/svg" width="25" height="24" viewBox="0 0 25 24" fill="none">
                                        <path d="M20.5 14.6666V18.2222C20.5 18.6937 20.3127 19.1459 19.9793 19.4793C19.6459 19.8127 19.1937 20 18.7222 20H6.27778C5.80628 20 5.3541 19.8127 5.0207 19.4793C4.6873 19.1459 4.5 18.6937 4.5 18.2222V14.6666" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        <path d="M8.05566 10.2222L12.5001 14.6666L16.9446 10.2222" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        <path d="M12.5 14.6667V4" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                    </svg>
                                </a>
                            </div>
                        </div>
                        <div class="w33 pdf-card">
                            <img src="./assets/images/pdf-icon.png" alt="" />
                            <div class="pdf-content">
                                <p>
                                    Financial Year - 2023-24 (Quarter 3)
                                </p>
                                <a href="#" title="" download="">
                                    <svg xmlns="http://www.w3.org/2000/svg" width="25" height="24" viewBox="0 0 25 24" fill="none">
                                        <path d="M20.5 14.6666V18.2222C20.5 18.6937 20.3127 19.1459 19.9793 19.4793C19.6459 19.8127 19.1937 20 18.7222 20H6.27778C5.80628 20 5.3541 19.8127 5.0207 19.4793C4.6873 19.1459 4.5 18.6937 4.5 18.2222V14.6666" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        <path d="M8.05566 10.2222L12.5001 14.6666L16.9446 10.2222" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        <path d="M12.5 14.6667V4" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                    </svg>
                                </a>
                            </div>
                        </div>
                        <div class="w33 pdf-card">
                            <img src="./assets/images/pdf-icon.png" alt="" />
                            <div class="pdf-content">
                                <p>
                                    Financial Year - 2023-24 (Quarter 4)
                                </p>
                                <a href="#" title="" download="">
                                    <svg xmlns="http://www.w3.org/2000/svg" width="25" height="24" viewBox="0 0 25 24" fill="none">
                                        <path d="M20.5 14.6666V18.2222C20.5 18.6937 20.3127 19.1459 19.9793 19.4793C19.6459 19.8127 19.1937 20 18.7222 20H6.27778C5.80628 20 5.3541 19.8127 5.0207 19.4793C4.6873 19.1459 4.5 18.6937 4.5 18.2222V14.6666" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        <path d="M8.05566 10.2222L12.5001 14.6666L16.9446 10.2222" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        <path d="M12.5 14.6667V4" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                    </svg>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
   
</asp:Content>
