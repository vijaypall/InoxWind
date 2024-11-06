<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="InoxWind.products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="inner-banner">
        <img src="./assets/images/products.jpg" alt="" />
    </section>
    <section class="about-text technology-partner">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings">
                    <p class="main-title">Our <span>Products</span></p>
                    <p>
                        Our products are crafted to harness the power of wind efficiently and sustainably. Inox Wind advanced wind turbines, like the INOX DF 113 (2 MW) and INOX DF 145 (3 MW), are designed for high performance, reliability, and efficiency. Using the latest technology and innovative designs, each turbine ensures maximum energy output with minimal environmental impact.
                    </p>
                </div>
            </div>
        </div>
    </section>
    <form runat="server">
        <section class="productsmain">
            <div class="mcontainer products-flexbox">
                <div class="productstopbar mcontainer">
                    <div class="w90 margin-center">
                        <ul>
                            <li class="product-tab active-pr-tab" data-id="prod1">INOX DF 145 (3 MW)
                            </li>
                            <li class="product-tab" data-id="prod2">INOX DF 113 (2 MW)
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="product-data mcontainer" id="prod1">
                    <div class="mcontainer product-about" id="DivProduct1Image" runat="server">
                        
                    </div>
                    <div class="product-specs mcontainer">
                        <div class="w90 margin-center prodabtflex">
                            <p class="spec-title">
                                Unlock actionable insights with seamless access to precise technical data:
                            </p>
                            <div class="spec-accordions mcontainer" id="DivProduct1Data" runat="server">
                              <%--  <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec11">
                                        <p>
                                            Operating Data
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec11">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec12">
                                        <p>
                                            Rotor
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec12">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec13">
                                        <p>
                                            Generator
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec13">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec14">
                                        <p>
                                            Baking System
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec14">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec15">
                                        <p>
                                            Gear Box
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec15">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec16">
                                        <p>
                                            Tower
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec16">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>--%>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="product-data mcontainer" id="prod2">
                    <div class="mcontainer product-about">
                        <div class="w90 margin-center prodabtflex" id="DivProduct2Image" runat="server">
                            
                        </div>
                    </div>
                    <div class="product-specs mcontainer">
                        <div class="w90 margin-center prodabtflex">
                            <p class="spec-title">
                                Unlock actionable insights with seamless access to precise technical data:
                            </p>
                            <div class="spec-accordions mcontainer" id="DivProduct2Data" runat="server">
                              <%--  <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec21">
                                        <p>
                                            Operating Data
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec21">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec22">
                                        <p>
                                            Rotor
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec22">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec33">
                                        <p>
                                            Generator
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec33">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec44">
                                        <p>
                                            Baking System
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec44">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec55">
                                        <p>
                                            Gear Box
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec55">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="spec-acc mcontainer">
                                    <div class="spec-acc-title" data-id="spec66">
                                        <p>
                                            Tower
                                        </p>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48" fill="none">
                                            <path d="M16 20L24 28L32 20" stroke="#2E2F34" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round" />
                                        </svg>
                                    </div>
                                    <div class="spec-content" id="spec66">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>Rated Max Power
                                                    </td>
                                                    <td>3000/3300 kW
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-in Wind Speed
                                                    </td>
                                                    <td>3.0 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Wind Speed
                                                    </td>
                                                    <td>9.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Cut-out Wind Speed
                                                    </td>
                                                    <td>20 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Survival Wind Speed
                                                    </td>
                                                    <td>52.5 m/s
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Hub Height
                                                    </td>
                                                    <td>100 to 140 meters
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rated Speed
                                                    </td>
                                                    <td>11 rpm
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </form>
    <script>
        document.addEventListener('DOMContentLoaded', function () {
        //product tabs
        var prodTabs = document.querySelectorAll('.product-tab');
        prodTabs.forEach((elem, index) => {
            var id = elem.dataset.id;
            if (index == 0) {
                document.getElementById(id).style.display = 'block'
                accordionSettings(document.getElementById(id));
            }
            elem.addEventListener('click', function () {
                if (elem.classList.contains('active-pr-tab')) {
                    // hideTabContent();
                } else {
                    hideTabContent();
                    prodTabs.forEach(el => el.classList.remove('active-pr-tab'));
                    elem.classList.add('active-pr-tab');
                    var elemToShow = document.getElementById(id);
                    elemToShow.style.display = 'block';
                    accordionSettings(document.getElementById(id));
                }
            });
        });
        function hideTabContent() {
            var elements = document.querySelectorAll('.product-data')
            elements.forEach(elem => {
                elem.style.display = 'none';
            })
        }
        //product tabs end
        // accordions 
        function accordionSettings(parent) {
            var accordions = parent.querySelectorAll('.spec-acc-title');
            console.log(accordions);
            accordions.forEach((elem, index) => {
                var id = elem.dataset.id;
                if (index == 0) {
                    var content = document.getElementById(id);
                    content.style.maxHeight = content.scrollHeight + 'px';
                    elem.classList.add('active-title');
                };
                elem.addEventListener('click', function () {
                    var content = document.getElementById(id);
                    if (elem.classList.contains('active-title')) {
                        content.style.maxHeight = null
                        elem.classList.remove('active-title');
                    } else {
                        content.style.maxHeight = content.scrollHeight + 'px';
                        elem.classList.add('active-title');
                    }
                });
            })
            };
        });
    </script>
</asp:Content>
