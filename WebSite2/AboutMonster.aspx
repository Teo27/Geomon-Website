<%@ Page Title="" Language="C#" MasterPageFile="~/MPDefault.master" AutoEventWireup="true" CodeFile="AboutMonster.aspx.cs" Inherits="multicolor_AboutMonster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    


    <section id="page-breadcrumb">
        <div class="vertical-center sun">
             <div class="container">
                <div class="row">
                    <div class="action">
                        <div class="col-sm-12">
                            <h1 class="title">Geomon</h1>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
   </section>
    <!--/#page-breadcrumb-->  
    
       
<asp:listview ID="geomon" runat="server" OnItemDataBound="geomon_ItemDataBound">

    <LayoutTemplate>
                    <ul id="collectionContainer" runat="server" >
                        <li runat="server" id="itemPlaceholder" />
                    </ul>
                </LayoutTemplate>

 <ItemTemplate>
<li>

    <section id="company-information" class="choose">
        <div class="container">
            <div class="row">
                 <div class="single-features">
                <div class="col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="0ms">
                    <div style="width:100%; height:auto">
                     

                    <asp:image id="geomonPlaceholder"   src='<%# Eval("Picture") %>' style="position:absolute; top:10%; left:15%; width:75%; height: 75%" runat='server' class="img-responsive"/>    
                     <img src="http://arrowinternational.co.nz/wp-content/uploads/2015/10/grey-circle.png"  style="position:center; width:100%; height:100%" class="img-responsive">
                                         
                    </div>

                </div>
                <div class="col-sm-6 padding-top wow fadeInDown " data-wow-duration="1000ms" data-wow-delay="0ms">
                    <asp:label id="geomonName" text='<%# Eval("Name") %>' runat="server"  Font-Bold="true" Font-Size="XX-Large"></asp:label>
                    <br />
                    <br />

                    <asp:label id="geomonDescription" text='<%# Eval("Description") %>' runat="server" Font-Size="Large"></asp:label>
                    <br />
                    <br />

                    <ul class="elements">
                        <li class="wow fadeInDown" data-wow-duration="900ms" data-wow-delay="100ms">
                            <asp:Label id="LabelType" runat="server" text="Type: "  Font-Size="Large" Font-Bold="true" /> 
                            <asp:label  runat="server" ID="geomonType" Font-Size="Large" text='<%# Eval("Type") %>' /></li>
                        <div class="clearfix visible-xs-block"></div>
                    <br />

                        <li class="wow fadeInDown" data-wow-duration="800ms" data-wow-delay="200ms">
                            <asp:Label id="LabelRarity" runat="server"  Font-Size="Large" text="Rarity: "  Font-Bold="true" /> 
                            <asp:Label id="geomonRarity" runat="server" Font-Size="Large" text='<%# Eval("Rarity") %>' Visible="False" /> 
                            <asp:Label ID="star" runat="server"></asp:Label>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        </div>
    </section>

</li>
     </ItemTemplate>

    <EmptyDataTemplate>                  
    <asp:label ID="noGeomon" runat="server" style="text-align:center"> Please choose a Geomon. </asp:label>
    <br />
    <br />
    </EmptyDataTemplate>
     </asp:listview>
    <br />
    <asp:label ID="noGeomon" runat="server" style="text-align:center" Visible="false"> Please choose a Geomon. </asp:label>
   <br />
</asp:Content>