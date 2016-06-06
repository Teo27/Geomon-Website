<%@ Page Title="" Language="C#" MasterPageFile="~/MPDefault.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="multicolor_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <section id="home-slider">
        <div class="container">
            <div class="row">
                <div class="main-slider">
                    <div class="slide-text">
                        <h1>Geomon</h1>
                        <p>No longer do you need to go around aimlessly. Venture forth into the new age, where geomon roam free in our world. Would you be the first to collect them all? Do you think you have what it takes to be the very best geomon champion?</p>
                        <%--<a href="~/downloads/geomon.apk" class="btn btn-success"><span class="glyphicon glyphicon-download" style="padding-right:10px"></span>Download</a>--%>
                        <asp:HyperLink ID="lnkdwnload" runat="server" class="btn btn-success" NavigateUrl="~/downloads/geomon.apk"><span class="glyphicon glyphicon-download" style="padding-right:10px"></span>Download</asp:HyperLink>
                    </div>

                    <img src="images/home/slider/hill.png" class="slider-hill" alt="slider image">
                    <img src="images/home/slider/house.png" class="slider-house" alt="slider image">
                    <img src="images/home/slider/sun.png" class="slider-sun" alt="slider image">
                    <img src="images/home/slider/birds1.png" class="slider-birds1" alt="slider image">
                    <img src="images/home/slider/birds2.png" class="slider-birds2" alt="slider image">
                </div>
            </div>
        </div>
        <div class="preloader"><i class="fa fa-sun-o fa-spin"></i></div>
    </section>
    <!--/#home-slider-->

    <section id="services">
        <div class="container">
            <div class="row">
                <div class="col-sm-4 text-center padding wow fadeIn" data-wow-duration="1000ms" data-wow-delay="300ms">
                    <div class="single-service">
                        <h2>Fun</h2>
                        <p>Explore the world in a new way, gather geomon wherever you go! Hatch them and make them ready to face the real world!</p>
                    </div>
                </div>
                <div class="col-sm-4 text-center padding wow fadeIn" data-wow-duration="1000ms" data-wow-delay="600ms">
                    <div class="single-service">
                        <h2>Healthy</h2>
                        <p>The unique opportunity to improve your lifestyle in a form of a game. Going from point A to B has never been so motivating before!</p>
                    </div>
                </div>
                <div class="col-sm-4 text-center padding wow fadeIn" data-wow-duration="1000ms" data-wow-delay="900ms">
                    <div class="single-service">
                        <h2>Addicting</h2>
                        <p>Try to collect them all, try to be the very best geomon challenger and compete with others for the champion title.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    
    

</asp:Content>

