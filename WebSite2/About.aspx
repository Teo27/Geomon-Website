<%@ Page Title="" Language="C#" MasterPageFile="~/MPDefault.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="multicolor_About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <section id="page-breadcrumb">
        <div class="vertical-center sun">
             <div class="container">
                <div class="row">
                    <div class="action">
                        <div class="col-sm-12">
                            <h1 class="title">About Us</h1>
                            <p>Why YOU would love to come and play.</p>
                        </div>

                     </div>
                </div>
            </div>
        </div>
   </section>
    <!--/#page-breadcrumb-->

    <section id="company-information" class="padding wow fadeIn" data-wow-duration="1000ms" data-wow-delay="300ms">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    <img src="images/aboutus/1.png" class="img-responsive" alt="">
                </div>
                <div class="col-sm-6" style="padding-top:35px">
                    <p><b>Geomon is the new way fun way people are going to explore the world.</b></p>
                    <br />
                    <p>&nbsp&nbsp&nbsp&nbsp This android application promotes having a good lifestyle by prompting its users to go out and explore. Geomons are small creatures from unknows universe far from here. They decided to try and live with us, so they send their eggs to Earth. Thus the age of geomons began. Now it is time for the users to find and take care of these creatures, helping them achieve their glory. As with any other pet, it is up to you to make sure that they get all the nutritions needed as well as exercises. Feed them, walk them, collected them and be the very best champion there is. Go and explore! Let your journey begin...</p>
                </div>
            </div>
        </div>
    </section>

    <section id="services">
        <div class="container">
            <div class="row">
                <div class="col-sm-4 text-center padding wow fadeIn" data-wow-duration="1000ms" data-wow-delay="300ms">
                    <div class="single-service">
                        <div class="wow scaleIn" data-wow-duration="500ms" data-wow-delay="300ms">
                            <img src="images/home/icon1.png" alt="">
                        </div>
                        <h2>Location detection</h2>
                        <p>Will analyse you postion and provide you with enough fun even if you go out on vacation and maybe some other rare geomons.</p>
                    </div>
                </div>
                <div class="col-sm-4 text-center padding wow fadeIn" data-wow-duration="1000ms" data-wow-delay="600ms">
                    <div class="single-service">
                        <div class="wow scaleIn" data-wow-duration="500ms" data-wow-delay="600ms">
                            <img src="images/home/icon2.png" alt="">
                        </div>
                        <h2>Weather detection</h2>
                        <p>Will check the weather in your area and maybe get you some very interesting result when it comes to your geomons.</p>
                    </div>
                </div>
                <div class="col-sm-4 text-center padding wow fadeIn" data-wow-duration="1000ms" data-wow-delay="900ms">
                    <div class="single-service">
                        <div class="wow scaleIn" data-wow-duration="500ms" data-wow-delay="900ms">
                            <img src="images/home/icon3.png" alt="">
                        </div>
                        <h2>Allows offline</h2>
                        <p>Set you location and download the map, so you can play with your geomon even if there is no internet connection.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    
    <section id="team">
        <div class="container">
            <div class="row">
                <div class="cool_sun">
                    <h1 class="title text-center wow fadeInDown" data-wow-duration="500ms" data-wow-delay="300ms">Meet the Team</h1>
                    <p class="text-center wow fadeInDown" data-wow-duration="400ms" data-wow-delay="400ms">
                        We all come from different contries but choosing to study computer science has brought us together <br>
                    We are very easy people to hang out it and we believe that we are a "family" and that you are a part of it. </p>
                </div>
                <div id="team-carousel"  data-wow-duration="400ms" data-wow-delay="400ms">
                  
                     <!-- Team -->
                   
                    

                        <div class="item active">
                            <div class="col-sm-3 col-xs-6">
                                <div class="team-single-wrapper">
                                    <div class="team-single">
                                        <div class="person-thumb">
                                            <img src="images/aboutus/1.jpg" class="img-responsive" alt="">
                                        </div>
                                        <div class="social-profile">
                                            <ul class="nav nav-pills">
                                                <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                                                <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                                                <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="person-info">
                                        <h2 class="text-center">Teodor Dimitriev</h2>
                                        <p class="text-center">CEO &amp; Developer</p>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-3 col-xs-6">
                                <div class="team-single-wrapper">
                                    <div class="team-single">
                                        <div class="person-thumb">
                                            <img src="images/aboutus/2.jpg" class="img-responsive" alt="">
                                        </div>
                                        <div class="social-profile">
                                            <ul class="nav nav-pills">
                                                <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                                                <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                                                <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="person-info">
                                        <h2 class="text-center">Ieva Jonikaite</h2>
                                        <p class="text-center">CEO &amp; Developer</p>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-3 col-xs-6">
                                <div class="team-single-wrapper">
                                    <div class="team-single">
                                        <div class="person-thumb">
                                            <img src="images/aboutus/3.jpg" class="img-responsive" alt="">
                                        </div>
                                        <div class="social-profile">
                                            <ul class="nav nav-pills">
                                                <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                                                <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                                                <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="person-info">
                                        <h2 class="text-center">George Dragoniuo</h2>
                                        <p class="text-center">CEO &amp; Developer</p>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-3 col-xs-6">
                                <div class="team-single-wrapper">
                                    <div class="team-single">
                                        <div class="person-thumb">
                                            <img src="images/aboutus/1.jpg" class="img-responsive" alt="">
                                        </div>
                                        
                                    </div>
                                    <div class="person-info">
                                        <h2 class="text-center">You</h2>
                                        <p class="text-center">User &amp; Part of the family</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        
                            
                    
       
                    <!-- Controls -->
                   
                </div>
            </div>
        </div>
    </section>
    <!--/#team-->





</asp:Content>

