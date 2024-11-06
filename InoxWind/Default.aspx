<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InoxWind.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="banners mcontainer">
        <div class="banner-swiper swiper">
            <div class="swiper-wrapper" id="BannerDIVSwiperWrapper" runat="server" >
                
                
           <%--     <div class="swiper-slide banner-img">
                    <img src="assets/images/banner-mian.jpg" alt="" />
                    <div class="banner-content">
                        <p class="top-text">Unwind</p>
                        <p class="banner-title">
                            CLEAN ENERGY
                        </p>
                        <p>
                            At Inox Wind Limited, we are leading the way in sustainable wind energy solutions. With a rich legacy of excellence, we have established ourselves as a leading player in the wind energy market.
                        </p>
                        <a href="#" title="Know More" class="main-button"><span>Know More</span></a>
                    </div>
                </div>--%>


                <%--<div class="swiper-slide banner-img">
                    <img src="assets/images/banner-mian.jpg" alt="" />
                    <div class="banner-content">
                        <p class="top-text">Unwind</p>
                        <p class="banner-title">
                            CLEAN ENERGY
                        </p>
                        <p>
                            At Inox Wind Limited, we are leading the way in sustainable wind energy solutions. With a rich legacy of excellence, we have established ourselves as a leading player in the wind energy market.
                        </p>
                        <a href="#" title="Know More" class="main-button"><span>Know More</span></a>
                    </div>
                </div>--%>
            </div>
            <div class="banner-navs navs">
                <div class="banner-prev nav-btn">
                    <i data-feather="chevron-left"></i>
                </div>
                <div class="swiper-pagination"></div>
                <div class="banner-next nav-btn">
                    <i data-feather="chevron-right"></i>
                </div>
            </div>
        </div>
    </section>
  
    <section class="group-counters">
        <div class="top-group mcontainer" runat="server" id="idHomeEditor">
            <%--<div class="w90 margin-center row">
                <div class="col-lg-6 col-md-6 col-sm-12 col-12 grp-img">
                    <img src="assets/images/GroupImg.png" alt="" />
                </div>
                <div class="col-lg-6 col-md-6 col-sm-12 col-12 grp-text">
                    <div class="mcontainer common-headings">
                        <p class="main-title">Part of the <span>INOXGFL Group</span></p>
                        <p>
                            Inox Wind is a part of INOXGFL Group, a market capitalization of approximately 5 billion US$. With a primary focus on Chemicals and Renewable Energy, INOXGFL Group anchors three listed entities, boasting a resilient workforce and a global distribution network.
                        </p>
                        <a href="#" title="Know More" class="main-button"><span>Know More</span></a>
                    </div>
                </div> 
            </div>
            <div class="w90 margin-center row">
                <div class="col-lg-6 col-md-6 col-sm-12 col-12 grp-text">
                    <div class="mcontainer common-headings">
                        <p class="main-title">Part of the <span>INOXGFL Group</span></p>
                        <p>
                            Inox Wind is a part of INOXGFL Group, a market capitalization of approximately 5 billion US$. With a primary focus on Chemicals and Renewable Energy, INOXGFL Group anchors three listed entities, boasting a resilient workforce and a global distribution network.
                        </p>
                        <a href="#" title="Know More" class="main-button"><span>Know More</span></a>
                    </div>
                </div>
                <div class="col-lg-6 col-md-6 col-sm-12 col-12 grp-img">
                    <img src="assets/images/GroupImg.png" alt="" />
                </div>
                

            </div>--%>
        </div>
        <div class="counters mcontainer">
            <div class="w90 margin-center row" id="populateMileStone" runat="server">
                <%--<div class="col-lg-3 col-md-3 col-sm-6 col-6 count-cardmbox">
                    <div class="counter-box">
                        <h4>
                            1500 <span>+</span>
                        </h4>
                        <p>
                            Wind Turbines Installed
                        </p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-6 col-6 count-cardmbox">
                    <div class="counter-box">
                        <h4>
                            3.1 <span>GW+</span>
                        </h4>
                        <p>
                            Installed Capacity
                        </p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-6 col-6 count-cardmbox">
                    <div class="counter-box">
                        <h4>
                            100 <span>+</span>
                        </h4>
                        <p>
                            Valued Customers
                        </p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-6 col-6 count-cardmbox">
                    <div class="counter-box">
                        <h4>
                            4
                        </h4>
                        <p>
                            State-of-the-Art Manufacturing Units
                        </p>
                    </div>
                </div>--%>
            </div>
        </div>
    </section>
    <section class="news-updates">
        <div class="mcontainer">
            <div class="w90 margin-center row">
                <div class="col-lg-8 col-md-6 col-sm-12 col-12 news-offersside">
                    <div class="mcontainer common-headings">
                        <p class="main-title">Empowering the Future with Sustainable <span>Wind Energy Solutions</span></p>
                        <p>
                            We are committed to revolutionizing the renewable energy industry through innovative and sustainable wind technology solutions. Our wind turbines are specifically tailored for low wind speed sites in India, <span>producing approximately 6% - 18% more energy </span>compared to similar turbines available in the market. By tapping into the inexhaustible power of the wind, we strive to improve our world and aspire to leave behind a greener planet for future generations.
                        </p>
                    </div>
                    <div class="mcontainer common-headings offeringsbx">
                        <p class="main-title">Explore <span>Our Offerings</span> </p>
                        <div class="offering-btns">
                            <a href="products.aspx" title="Products" class="main-button type2"><span>Products</span></a>
                            <a href="infrastructure.aspx" title="Services" class="main-button type2"><span>Services</span></a>
                        </div>
                    </div>
                </div> 
                <div class="col-lg-4 col-md-6 col-sm-12 col-12 news-carousel">
                    <p class="news-tag">Latest News & Updates</p>
                    <div class="news-slider swiper">
                        <div class="swiper-wrapper" runat="server" id="populateLatestNews">
                        

                            <%--<div class="swiper-slide">
                                <div class="news-card mcontainer">
                                    <img src="assets/images/news1.png" alt="" style="height:194px;width:393px" />
                                    <div class="news-cards-details mcontainer">
                                        <div class="news-date-box mcontainer">
                                            <p class="news-art-title">
                                                NEWS ARTICLE
                                            </p>
                                            |
                                            <p class="news-date">
                                                <i class="bi bi-calendar4"  style="font-size:16px; color:black"></i>
                                                July 17, 2023
                                            </p>
                                        </div>
                                        <h5>
                                            Inox Wind receives Type Certification from TUV SUD for its 3 MW wind turbine
                                        </h5>
                                        <a href="#" title="Know More" class="main-button"><span>Know More</span></a>
                                    </div>
                                </div>
                            </div>
                            <div class="swiper-slide">
                                <div class="news-card mcontainer">
                                    <img src="assets/images/news1.png" alt="" />
                                    <div class="news-cards-details mcontainer">
                                        <div class="news-date-box mcontainer">
                                            <p class="news-art-title">
                                                NEWS ARTICLE
                                            </p> 
                                            <p class="news-date">
                                                 <i class="bi bi-calendar4"  style="font-size:16px; color:black"></i>
                                                July 17, 2023
                                            </p>
                                        </div>
                                        <h5>
                                            Inox Wind receives Type Certification from TUV SUD for its 3 MW wind turbine
                                        </h5>
                                        <a href="#" title="Know More" class="main-button"><span>Know More</span></a>
                                    </div>
                                </div>
                            </div>--%>

                        </div>
                    </div>
                    <div class="news-navs navs">
                        <div class="news-prev nav-btn">
                            <i data-feather="chevron-left"></i>
                        </div>
                        <div class="news-next nav-btn">
                            <i data-feather="chevron-right"></i>
                        </div>
                    </div>
                </div>
            </div>    
        </div>
    </section>
    <section class="values">
        <div class="mcontainer">
            <div class="w90 margin-center row">
                <div class="mcontainer common-headings text-center">
                    <p class="main-title">Our <span>Values</span></p>
                    <p>
                        We deliver value through precision-engineered windmill components,<br/> empowering the renewable energy revolution.
                    </p>
                </div>
                <div class="mcontainer value-cards">
                    <div class="values-swiper swiper">
                        <div class="swiper-wrapper">
                            <div class="swiper-slide value-card">
                                <div class="backlayer mcontainer">
                                    <img src="assets/images/Value1.png" alt="" />
                                </div>
                                <div class="frontlayer mcontainer">
                                    <div class="front-texts mcontainer text-center">
                                        <h4>
                                            Performance Excellence
                                        </h4>
                                        <p>
                                            At Inox Wind Limited, we are dedicated to achieving performance excellence in every aspect of our offerings. From innovative design to stringent quality assurance, we strive to deliver wind energy solutions that exceed expectations and set industry standards.
                                        </p>
                                    </div>
                                    <div class="circle">
                                        <svg xmlns="http://www.w3.org/2000/svg" width="215" height="215" viewBox="0 0 215 215" fill="none">
                                            <circle cx="107.5" cy="107.5" r="107" stroke="white" stroke-dasharray="6 6"/>
                                        </svg>
                                    </div>
                                </div>
                            </div>
                            <div class="swiper-slide value-card">
                                <div class="backlayer mcontainer">
                                    <img src="assets/images/Value2.png" alt="" />
                                </div>
                                <div class="frontlayer mcontainer">
                                    <div class="front-texts mcontainer text-center">
                                        <h4>
                                            Cost-Effective Solutions
                                        </h4>
                                        <p>
                                            Inox Wind Limited is committed to providing cost-effective solutions without compromising on quality. By leveraging advanced technology and efficient manufacturing processes, we ensure maximum return on investment for our customers, while promoting sustainability in the renewable energy sector.
                                        </p>
                                    </div>
                                    <div class="circle">
                                        <svg xmlns="http://www.w3.org/2000/svg" width="215" height="215" viewBox="0 0 215 215" fill="none">
                                            <circle cx="107.5" cy="107.5" r="107" stroke="white" stroke-dasharray="6 6"/>
                                        </svg>
                                    </div>
                                </div>
                            </div>
                            <div class="swiper-slide value-card">
                                <div class="backlayer mcontainer">
                                    <img src="assets/images/Value3.png" alt="" />
                                </div>
                                <div class="frontlayer mcontainer">
                                    <div class="front-texts mcontainer text-center">
                                        <h4>
                                            Reliability & Integrity
                                        </h4>
                                        <p>
                                            Reliability and integrity are the cornerstones of our business at Inox Wind Limited. With a legacy of trust and transparency, we uphold the highest standards of ethical conduct and accountability in all our endeavours.
                                        </p>
                                    </div>
                                    <div class="circle">
                                        <svg xmlns="http://www.w3.org/2000/svg" width="215" height="215" viewBox="0 0 215 215" fill="none">
                                            <circle cx="107.5" cy="107.5" r="107" stroke="white" stroke-dasharray="6 6"/>
                                        </svg>
                                    </div>
                                </div>
                            </div>
                            <div class="swiper-slide value-card">
                                <div class="backlayer mcontainer">
                                    <img src="assets/images/Value4.png" alt="" />
                                </div>
                                <div class="frontlayer mcontainer">
                                    <div class="front-texts mcontainer text-center">
                                        <h4>
                                            Diversity & Inclusion
                                        </h4>
                                        <p>
                                            At Inox Wind Limited, we embrace diversity and inclusion as key drivers of innovation and success, valuing every individual’s unique perspective and talent. By championing diversity, we foster creativity, collaboration, and excellence throughout our organization.
                                        </p>
                                    </div>
                                    <div class="circle">
                                        <svg xmlns="http://www.w3.org/2000/svg" width="215" height="215" viewBox="0 0 215 215" fill="none">
                                            <circle cx="107.5" cy="107.5" r="107" stroke="white" stroke-dasharray="6 6"/>
                                        </svg>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="value-navs navs">
                    <div class="value-prev nav-btn">
                        <i data-feather="chevron-left"></i>
                    </div>
                    <div class="value-next nav-btn">
                        <i data-feather="chevron-right"></i>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
