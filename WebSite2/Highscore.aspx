<%@ Page Title="" Language="C#" MasterPageFile="~/MPDefault.master" AutoEventWireup="true" CodeFile="Highscore.aspx.cs" Inherits="multicolor_Empty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="page-breadcrumb">
        <div class="vertical-center sun">
             <div class="container">
                <div class="row">
                    <div class="action">
                        <div class="col-sm-12">
                            <h1 class="title">Highscore</h1>
                        </div>
                    </div>
                </div>
            </div>
        </div>
   </section>
    <!--/#page-breadcrumb-->


    <br />
    <div class="container">
    <div style="margin: auto;width: 40%;">
    <asp:TextBox ID="TBSearch" runat="server" style="margin-left:15%; margin-right:5px" Height="35px" Width="250px"></asp:TextBox>
        <asp:Button CssClass="btn btn-info" ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    
        </div>
        </div>
    <br />

<div class="container">
       <div class="table-responsive" >          
         <asp:GridView 
             ID="GridViewHighscore"  
             runat="server"  
             AllowSorting="False" 
             AutoGenerateColumns="False" 
             AllowPaging="True"
             Width="50%" 
             HorizontalAlign="Center"
             GridLines="None" 
             CssClass="table table-hover table-striped"
             OnPageIndexChanging="GridViewHighscore_PageIndexChanging" PagerSettings-Mode="NumericFirstLast">

             <Columns>
                <asp:TemplateField HeaderText = "#" ItemStyle-Width="100"  >
                    <ItemTemplate>
                        <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                 
                 <asp:BoundField DataField="ScrName" HeaderText="Screen Name" SortExpression="ScrName" ></asp:BoundField>
                 <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score"></asp:BoundField>
        
            </Columns>
             <PagerStyle HorizontalAlign="Center" />
         </asp:GridView>
           <div class="alert alert-danger" style="width:75%" id="DivErr" runat="server" visible="false">
                                 <asp:Label ID="DivLabel" runat="server" Text="An error has occured"></asp:Label>
                            </div>
           <div class="alert alert-danger" style="width:75%;margin:0 auto" id="DivNoUser" runat="server" visible="false">
                                 <asp:Label ID="Label1" runat="server" Text="No such user exists"></asp:Label>
                            </div>
        
      </div>
</div>


    <br />

    </asp:Content>