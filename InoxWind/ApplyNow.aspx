<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApplyNow.aspx.cs" Inherits="InoxWind.ApplyNow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="application-form">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings center-text centered-headings">
                    <p class="main-title"><span>Application Form</span></p>
                    <p>
                        Complete the form below to join our community. Your application is the first step toward an exciting journey with us
                    </p>
                </div>
                <div class="mainform">
                    <form class="row">
                        <div class="col-lg-6 col-sm-6 col-12  inputbox inputbox">
                            <label>
                                Full Name *
                                <input type="text" name="name" placeholder="Enter your full name" required />
                            </label>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                Contact Number *
                                <input type="number" name="number" placeholder="Enter your contact number" required />
                            </label>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                Age (Years) *
                                <select>
                                    <option selected disabled>Select your age</option>
                                    <option value="20">20</option>
                                    <option value="21">21</option>
                                    <option value="22">22</option>
                                    <option value="23">23</option>
                                    <option value="24">24</option>
                                </select>
                            </label>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                Email *
                                <input type="email" name="email" placeholder="Enter your email" required />
                            </label>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                City *
                                <input type="text" name="city" placeholder="Enter your city" required />
                            </label>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                Position *
                                <select>
                                    <option selected disabled>Select position</option>
                                    <option value="Manager - Utilities And Energy">Manager - Utilities And Energy</option>
                                    <option value="Manager - Utilities And Energy">Manager - Utilities And Energy</option>
                                    <option value="Manager - Utilities And Energy">Manager - Utilities And Energy</option>
                                    <option value="Manager - Utilities And Energy">Manager - Utilities And Energy</option>
                                    <option value="Manager - Utilities And Energy">Manager - Utilities And Energy</option>
                                </select>
                            </label>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                Functional Area *
                                <select>
                                    <option selected disabled>Select your age</option>
                                    <option value="20">20</option>
                                    <option value="21">21</option>
                                    <option value="22">22</option>
                                    <option value="23">23</option>
                                    <option value="24">24</option>
                                </select>
                            </label>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                Experience *
                                <select>
                                    <option selected value="Fresher">Fresher</option>
                                    <option value="2+ Years">2+ Years</option>
                                    <option value="3+ Years">3+ Years</option>
                                    <option value="4+ Years">4+ Years</option>
                                    <option value="5+ Years">5+ Years</option>
                                    <option value="6+ Years">6+ Years</option>
                                </select>
                            </label>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                Qualification  *
                                <select>
                                    <option selected disabled>Select qualification</option>
                                    <option value="12th Pass">12th Pass</option>
                                    <option value="Under Graduate">Under Graduate</option>
                                    <option value="Post Graduate">Post Graduate</option>
                                </select>
                            </label>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox radios">
                            <p>
                                Ready for Relocation *
                            </p>
                            <div class="radiochecks">
                                <label>
                                    <input type="radio" name="relocation" checked value="Yes"/> Yes
                                </label>
                                <label>
                                    <input type="radio" name="relocation" value="No"/> No
                                </label>
                            </div>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                Attach updated Resume *
                                <input type="file" accept=".doc,.docx,.pdf" name="resume" required />
                            </label>
                            <span class="note">only .doc/docx/pdf file attach</span>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="col-lg-6 col-sm-6 col-12  inputbox">
                            <label>
                                Attach professional image
                                <input type="file" accept=".png,.jpg,.jpeg" name="image" />
                            </label>
                            <span class="note">only .jpg/png/jpeg image file attach</span>
                            <span class="error">This field is required</span>
                        </div>
                        <div class="submit-buttons">
                            <button type="submit" class="main-button">
                                <span>Submit</span>
                            </button>
                            <button type="button" class="main-button">
                                <span>Reset</span>
                            </button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
