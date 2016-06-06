<%@ Page Title="" Language="C#" MasterPageFile="~/MPDefault.master" AutoEventWireup="true" CodeFile="Hatchery.aspx.cs" Inherits="multicolor_ProfileView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">




    <section id="page-breadcrumb">
        <div class="vertical-center sun">
             <div class="container">
                <div class="row">
                    <div class="action">
                        <div class="col-sm-12">
                            <h1>Hatchery</h1>
                        </div>
                     </div>
                </div>
            </div>
        </div>
   </section>

    <div class="container">
        <div class="row">
            
  

            <br />
            <br />
            <div style="margin:auto;width:90%">
            <asp:ListView ID="ListView" runat="server" DataKeyNames="Id">
                
                <EmptyDataTemplate>
                    <span>You have no geomon eggs.</span>
                </EmptyDataTemplate>


                <ItemTemplate>
                    
                    <div style="display:inline-block;float:left; padding-right:20px;padding-bottom:20px">
                       <asp:Image ID="Label1" runat="server" ImageUrl='<%# Eval("Picture") %>' />
                        <br />
                    <div style="margin-left:auto;margin-right:auto; text-align:center;padding-top:5px;padding-bottom:5px">
                    <asp:Label ID="NameLabel" runat="server" Text="Egg" cssclass="text-center" Font-Size="Larger"/></div>
                    <asp:Label ID="EggId" runat="server" Text='<%# Eval("Picture") %>' Visible="false"></asp:Label>
                    
                    <div class="progress" style="border-radius:20%;border:2px solid black">
                    <div class="progress-bar progress-bar-info" role="progressbar" aria-valuenow="40" aria-valuemin="0" aria-valuemax="100" style="width:40%" ID="ProgBar" runat="server"></div>
                    </div>
                        <div style="text-align:center">
                        <a href="#" Class="btn btn-success" style="color:black"><span class="glyphicon glyphicon-time" style="padding-right:5px"></span>Hatch</a>
                        </div>
                        
                                               
                    </div>
                    
                </ItemTemplate>


            </asp:ListView>
                <div class="alert alert-danger" style="width:75%" id="DivErr" runat="server" visible="false">
                                 <asp:Label ID="DivLabel" runat="server" Text="An error has occured"></asp:Label>
                            </div>
            </div>
            </div>
    </div>
</asp:Content>

