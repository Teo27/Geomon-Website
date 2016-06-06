<%@ Page Title="" Language="C#" MasterPageFile="~/MPDefault.master" AutoEventWireup="true" CodeFile="ProfileView.aspx.cs" Inherits="multicolor_ProfileView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="page-breadcrumb">
        <div class="vertical-center sun">
             <div class="container">
                <div class="row">
                    <div class="action">
                        <div class="col-sm-12">
                            
                                    <asp:Label ID="ScrNameLabel" runat="server" Text="" Font-Size="XX-Large" />
                                
                           
                        </div>
                     </div>
                </div>
            </div>
        </div>
   </section>

    <div class="container">
        <div class="row">
            <br />
            <div id="DivSuc" runat="server">
            <ul style="text-align:center; font-size:25px">
                <li class="inline" style="padding-right:30px">
                Steps:
                <asp:Label ID="StepLabel" runat="server" Text="" />
                 
                </li> 
                <li class="inline">
                Score:
                <asp:Label ID="ScoreLabel" runat="server" Text="" />
             
                </li>
            </ul>
                </div>
            <br />
            <br />
            
               
    <asp:ListView ID="ListView" runat="server" OnItemDataBound = "ListView_ItemDataBound">
        
        
        <EmptyDataTemplate>
            <ul>
                <li>
                  <h1 style="text-align:center">  User has no Geomons.</h1>
                </li>
                    
             </ul> 
        </EmptyDataTemplate>
        
        <ItemTemplate>
            
            <div style="margin:auto;width:90%">
               
                    <div style="display:inline-block;float:left; padding-right:20px;padding-bottom:20px">
                       <asp:Image ID="Label1" runat="server" ImageUrl='<%# Eval("Picture") %>' style="width:250px;height:250px"/>
                        <br />
                        <div style="width: 50%; margin: 0 auto;"><b>
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    .
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' /></b>
                    <br />
                    
                    <asp:Label ID="RarityLabel" runat="server" Text='<%# Eval("Rarity") %>' Visible="False" />
                    <asp:Label ID="star" runat="server"></asp:Label>
               <%--     <asp:Label ID="TypeLabel" runat="server" Text='<%# Eval("Type") %>'/>  --%>  
                               </div>                
                    </div>
                    
            </div>
        </ItemTemplate>
        
        
    </asp:ListView>
     <div class="alert alert-danger" style="width:75%" id="DivErr" runat="server" visible="false">
                                 <asp:Label ID="DivLabel" runat="server" Text="An error has occured"></asp:Label>
                            </div>

            
            </div>
    </div>
</asp:Content>

