<%@ Page Title="" Language="C#" MasterPageFile="~/MPDefault.master" AutoEventWireup="true" CodeFile="Achievements.aspx.cs" Inherits="multicolor_Empty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <section id="page-breadcrumb">
        <div class="vertical-center sun">
             <div class="container">
                <div class="row">
                    <div class="action">
                        <div class="col-sm-12">
                            <h1 class="title">Achievements</h1>
                        </div>
                     </div>
                </div>
            </div>
        </div>
   </section>

    <br />
    <div class="container">
        <div class="progress">
            <div class="progress-bar progress-bar-success progress-bar-striped" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width:0%" id="ProgBar" runat="server">
             <b><asp:Label ID="ProgressLabel" runat="server" Text=""></asp:Label></b> 
            </div>
        </div>

        <div>

            <div>



                <asp:ListView ID="ListAch" runat="server">
                   
                    
                    <EmptyDataTemplate>
                        <br />
                       <h1 style="text-align:center"> Play the game to earn some more achievements. </h1>
                    </EmptyDataTemplate>
                    
                    <ItemSeparatorTemplate>
<br />
                    </ItemSeparatorTemplate>
                    <ItemTemplate>
                        <li>
                            <div style="border: 1px solid gray; border-radius:25px;padding: 10px">
                                <img class="pull-left" src="images/trophy.png" height="50" width="48" style="margin-right:5px" />
                                <b><asp:Label ID="ValueLabel" runat="server" Text='<%# Eval("Value") %>' CssClass="pull-right" style="padding:10px 0"/></b>
                                
                                
                                <div>
                                    <b><asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' /></b>
                                    <br />
                                    <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                                </div>
                            </div>
                            
                        </li>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <ul id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <li runat="server" id="itemPlaceholder" />
                        </ul>
                        <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                        </div>
                    </LayoutTemplate>
                   
                </asp:ListView>
                <div class="alert alert-danger" style="width:75%" id="DivErr" runat="server" visible="false">
                                 <asp:Label ID="DivLabel" runat="server" Text="An error has occured"></asp:Label>
                            </div>
            </div>
        </div>
    </div>

    


</asp:Content>

