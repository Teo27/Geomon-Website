<%@ Page Title="" Language="C#" MasterPageFile="~/MPDefault.master" AutoEventWireup="true" CodeFile="Collection.aspx.cs" Inherits="multicolor_Collection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    


    <section id="page-breadcrumb">
        <div class="vertical-center sun">
             <div class="container">
                <div class="row">
                    <div class="action">
                        <div class="col-sm-12">
                            <h1 class="title">Collection</h1>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
   </section>
    <!--/#page-breadcrumb-->
    <br />
     <div class="container" >
        <div class="progress" style="margin-bottom:30px">
            <div runat="server" class="progress-bar progress-bar-success progress-bar-striped" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width:0%" id="ProgBar">
             <b><asp:Label ID="ProgressLabel" runat="server" Text=""></asp:Label></b> 
            </div>
        </div>
         <ul class="portfolio-filter text-center" style="margin:10px 0">
                    <li><asp:Button runat="server" ID="ButtonCommon" CssClass="btn btn-default"  Text="Common" OnClick="ButtonCommon_Click"/></li>      
                    <li><asp:Button runat="server" ID="ButtonRare" CssClass="btn btn-default"  Text="Rare" OnClick="ButtonRare_Click"/></li>     
                    <li><asp:Button runat="server" ID="ButtonAll" CssClass="btn btn-default"  Text="All" OnClick="ButtonAll_Click"/></li>        
                </ul>

        </div>

    <section id="collection">
       
        <div class="container">
            <asp:listview ID="collectionList" runat="server" OnItemDataBound = "ListView_ItemDataBound">    
                        
                <LayoutTemplate>
                    <ul id="collectionContainer" runat="server" >
                        <li runat="server" id="itemPlaceholder" />
                    </ul>
                </LayoutTemplate>

                <ItemTemplate>
                    <li class="pull-left" style="display:inline-block">
                        <asp:imagebutton src='<%# Eval("Picture") %>'  id="geomonImage" runat="server"  CommandArgument='<%# Eval("Name") %>' CssClass="img-responsive" style="padding:10px;width:250px;height:250px" OnClick="ButtonGeomon_Click"/>   
                                  <div style="width: 50%; margin: 0 auto;">                        
                        <b>
                            <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    .<asp:Label ID="geomonNameLabel" runat="server" Text='<%# Eval("Name") %>'  /></b>  <br />
                                      <asp:Label ID="RarityLabel" runat="server" Text='<%# Eval("Rarity") %>' Visible="False" />
                    <asp:Label ID="star" runat="server"></asp:Label>                     
                    </div>
                    </li>

                </ItemTemplate>

                <EmptyDataTemplate>
                    
                       <h1 style="text-align:center"> Play the game to collect some Geomon. </h1>
                    <br />
                    <br />
                 </EmptyDataTemplate>
            </asp:listview>        
            <div class="alert alert-danger" style="width:75%" id="DivErr" runat="server" visible="false">
                                 <asp:Label ID="DivLabel" runat="server" Text="An error has occured"></asp:Label>
                            </div>
            </div>
    </section>


<asp:Label ID="geomonLabel" runat="server" ></asp:Label>
</asp:Content>