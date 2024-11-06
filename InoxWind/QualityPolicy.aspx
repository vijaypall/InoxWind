<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QualityPolicy.aspx.cs" Inherits="InoxWind.QualityPolicy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="inner-banner">
        <img src="./assets/images/policy-banner.jpg" alt="" />
    </section>
    <section class="quality-pol">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="titles-flex">
                    <div class="titles-side">
                        <div class="mcontainer common-headings">
                            <p class="main-title">Quality<span> Policy</span></p>
                            <p>
                                Inox Wind Limited aims to achieve the highest standards of quality in all business units’ practices and operations. Our objective is to continually improve our company performance, while offering our customers safe, cost effective and professional service.
                            </p>
                            <p>
                                Quality performance is one of the cornerstones of our company culture and is considered a personal responsibility of all employees. To maintain quality performance of all business units at the highest level, the following aims are pursued:
                            </p>
                        </div>
                    </div>
                    <div class="point-list">
                        <ul>
                            <li>
                                To establish a Quality Management System based on ISO standard, and ensure that our Quality Policy and Procedures are communicated and understood by all persons working for us.
                            </li>
                            <li>
                                To fulfill or exceed customer needs and expectations by delivering a quality product in a consistent and timely manner.
                            </li>
                            <li>
                                To respond to feedback from customers in the shortest possible time.
                            </li>
                            <li>
                                Policies are updated and reviewed periodically to ensure the ability of all groups to perform their work effectively and efficiently.
                            </li>
                            <li>
                                Every staff member is made responsible for ensuring that his or her work is of the highest standard and is encouraged to be actively involved in elimination of non-conformities.
                            </li>
                            <li>
                                We select and continuously develop our Vendor base on set quality parameters to ensure timely delivery and qualitative product.
                            </li>
                            <li>
                                Adopting suitable practices for maintaining safe and healthy environment and to meet Statutory and Regulatory requirements.
                            </li>
                        </ul>
                    </div>
                </div>
                <%--<div class="certificates-list quality-list">
                    <div class="w33 pdf-card">
                        <img src="./assets/images/pdf-icon.png" alt="" />
                        <div class="pdf-content">
                            <p>
                                ISO 14K
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
                                EN ISO 3834-2
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
                                ISO 9K
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
                                OHSAS
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
                </div>--%>
                <div class="certificates-list quality-list" runat="server" id="Divcertificates">
                   <%-- <div class="w33 pdf-card">
                        <img src="assets/images/pdf-icon.png" alt="" />
                        <div class="pdf-content">
                            <p>
                                ISO 14K
                            </p> 
                            
                            <a href="#" title="" download="" target="_blank"  style="color:#212529">
                                
                                <i class="bi bi-download" style=" font-size:18px"></i>
                            </a>
                        </div>
                    </div>
                    <div class="w33 pdf-card">
                        <img src="assets/images/pdf-icon.png" alt="" />
                        <div class="pdf-content">
                            <p>
                                EN ISO 3834-2
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
                        <img src="assets/images/pdf-icon.png" alt="" />
                        <div class="pdf-content">
                            <p>
                                ISO 9K
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
                        <img src="assets/images/pdf-icon.png" alt="" />
                        <div class="pdf-content">
                            <p>
                                OHSAS
                            </p>
                           <a href="#" title="" download="">
                                <svg xmlns="http://www.w3.org/2000/svg" width="25" height="24" viewBox="0 0 25 24" fill="none">
                                    <path d="M20.5 14.6666V18.2222C20.5 18.6937 20.3127 19.1459 19.9793 19.4793C19.6459 19.8127 19.1937 20 18.7222 20H6.27778C5.80628 20 5.3541 19.8127 5.0207 19.4793C4.6873 19.1459 4.5 18.6937 4.5 18.2222V14.6666" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                    <path d="M8.05566 10.2222L12.5001 14.6666L16.9446 10.2222" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                    <path d="M12.5 14.6667V4" stroke="#1B1C1E" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                </svg>
                            </a>
                        </div>
                    </div>--%>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
