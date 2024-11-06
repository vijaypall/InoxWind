<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AboutInoxgfl.aspx.cs" Inherits="InoxWind.AboutInoxgfl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="inner-banner">
        <img src="./assets/images/about-inoxgfl.jpg" alt="" />
    </section>
    <section class="about-text">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings">
                    <p class="main-title">About <span>INOXGFL Group</span></p>
                    <p>
                        The INOXGFL group, an Indian conglomerate with a legacy spanning over 100 years, stands as a pioneering force in diverse business segments such as Refrigerants, Fluoropolymers, Specialty Chemicals, Wind Energy, and Renewables. With a rich history, the INOXGFL Group has showcased remarkable resilience, evolving into a multibillion-dollar enterprise.
                    </p>
                </div>
            </div>
        </div>
    </section>
    <section class="business-entities">
        <div class="mcontainer">
            <div class="w90 margin-center busent-head">
                <div class="common-headings">
                    <p class="main-title">Our <span>Business Entities</span></p>
                    <p>
                        The Group currently with 4 listed entities has a market capitalization ~ 8 bn USD.
                    </p>
                </div>
                <div class="gfl-navs navs">
                    <div class="news-prev nav-btn">
                        <i data-feather="chevron-left"></i>
                    </div>
                    <div class="news-next nav-btn">
                        <i data-feather="chevron-right"></i>
                    </div>
                </div>
            </div>
        </div>
        <div class="mcontainer business-swiper">
            <div class="swiper bus-swiper">
                <div class="swiper-wrapper">
                    <div class="swiper-slide business-card ">
                        <div class="business-top">
                            <img src="./assets/images/gfl.png" alt="" />
                            <p class="tag">Chemicals</p>
                        </div>
                        <div class="business-content">
                            <p class="bus-title">
                                Gujarat Fluorochemicals Limited
                            </p>
                            <p>
                                GFL is the largest producer of Fluoropolymers in India with other product areas being Refrigerants, Chemicals, and Fluorospeciality.
                            </p>
                        </div>
                    </div>
                    <div class="swiper-slide business-card">
                        <div class="business-top">
                            <img src="./assets/images/gfl-ev.png" alt="" />
                            <p class="tag">Chemicals</p>
                        </div>
                        <div class="business-content">
                            <p class="bus-title">
                                GFCL EV Products Limited
                            </p>
                            <p>
                                GFCLEV is a 100% subsidiary of GFL, specializes in manufacturing intermediate materials for Lithium-ion Batteries.
                            </p>
                        </div>
                    </div>
                    <div class="swiper-slide business-card">
                        <div class="business-top">
                            <img src="./assets/images/inoxwind.png" alt="" />
                            <p class="tag">Renewable Energy</p>
                        </div>
                        <div class="business-content">
                            <p class="bus-title">
                                Inox Wind Limited
                            </p>
                            <p>
                                Inox Wind Ltd - Fully integrated solutions provider for end-to-end turnkey services.
                            </p>
                        </div>
                    </div>
                    <div class="swiper-slide business-card">
                        <div class="business-top">
                            <img src="./assets/images/inoxgreen.png" alt="" />
                            <p class="tag">Renewable Energy</p>
                        </div>
                        <div class="business-content">
                            <p class="bus-title">
                                Inox Green Energy Services Limited
                            </p>
                            <p>
                                IGESL is India's top O&M services provider, with over 8 years of operational experience.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="keystats">
        <div class="mcontainer stats-flex">
            <div class="keycontent col-lg-6 col-md-6 col-sm-12">
                <div class="w80 margin-center">
                    <div class="common-headings">
                        <p class="main-title">Key Statistics<span> and Insights</span></p>
                        <p>
                            The Group currently with 4 listed entities has a market capitalization ~ 8 bn USD.
                        </p>
                    </div>
                    <div class="statsboxes">
                        <div class="col-lg-6 col-md-6 col-sm-12 count-cardmbox">
                            <div class="counter-box">
                                <h4>
                                    6K<span>+</span>
                                </h4>
                                <p>
                                    Workforce
                                </p>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12  count-cardmbox">
                            <div class="counter-box">
                                <h4>
                                    16<span>+</span>
                                </h4>
                                <p>
                                    Countries Presence
                                </p>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12  count-cardmbox">
                            <div class="counter-box">
                                <h4>
                                    $8  <span>bn </span>
                                </h4>
                                <p>
                                    Market Capitalisation
                                </p>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 count-cardmbox gradientbg">
                            <a href="#" title="">
                                <div class="counter-box ">
                                    <img src="./assets/images/inoxgflwhite.png" alt="" />
                                    <p>
                                        Click Here to Know More
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-6 col-md-6 col-sm-12 stats-image">
                <img src="./assets/images/stats.png" alt="" />
            </div>
        </div>
    </section>
    
</asp:Content>
