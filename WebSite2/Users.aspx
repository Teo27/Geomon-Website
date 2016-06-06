<%@ Page Title="" Language="C#" MasterPageFile="~/MPDefault.master" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="multicolor_Empty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<%--    <section id="page-breadcrumb">
        <div class="vertical-center sun">
             <div class="container">
                <div class="row">
                    <div class="action">
                        <div class="col-sm-12">
                            <h1 class="title">Users</h1>
                        </div>
                    </div>
                </div>
            </div>
        </div>

   </section>
    <!--/#page-breadcrumb-->

    <br />
    <br />
<div class="container">
       <div class="table-responsive" >          
         <asp:GridView 
             ID="GridViewUsers"  
             runat="server"  
             AllowSorting="False" 
             AutoGenerateColumns="False" 
             AllowPaging="True" 
             OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
             Width="50%" 
             HorizontalAlign="Center"
             GridLines="None" 
             CssClass="table table-hover table-striped"
             OnPageIndexChanging="GridViewHighscore_PageIndexChanging">

             <Columns>
                <asp:TemplateField HeaderText = "#" ItemStyle-Width="100"  >
                    <ItemTemplate>
                        <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                 
                 <asp:BoundField DataField="ScrName" HeaderText="Screen Name" SortExpression="ScrName" ></asp:BoundField>

                 <asp:TemplateField>
                     <ItemTemplate>
                          <asp:Button ID="ButtonAddFriend" runat="server" CommandArgument='<%# Eval("USername") %>' CommandName="AddFriend" Text="Add Friend" Width="80" class="btn btn-sm button1" OnClick="ButtonAddFriend_Click"/>
                     </ItemTemplate>
                 </asp:TemplateField>
                 

            </Columns>

         </asp:GridView>
           <asp:Label id="label" runat="server"></asp:Label>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=ASUS\SQLEXPRESS;Initial Catalog=GeomonLocal;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [ScrName] FROM [Customer] ORDER BY [ScrName] ASC"></asp:SqlDataSource>
            
      </div>
</div>


    <br />--%>

    </asp:Content>