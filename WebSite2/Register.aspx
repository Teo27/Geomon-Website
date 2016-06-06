<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="multicolor_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Login/Register</title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/font-awesome.min.css" rel="stylesheet">
    <link href="css/lightbox.css" rel="stylesheet"> 
    <link href="css/animate.min.css" rel="stylesheet"> 
	<link href="css/main.css" rel="stylesheet">
	<link href="css/responsive.css" rel="stylesheet">


    <!--[if lt IE 9]>
	    <script src="js/html5shiv.js"></script>
	    <script src="js/respond.min.js"></script>
    <![endif]-->       
    <link rel="shortcut icon" href="images/ico/favicon.ico">
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="images/ico/apple-touch-icon-144-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="images/ico/apple-touch-icon-114-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="images/ico/apple-touch-icon-72-precomposed.png">
    <link rel="apple-touch-icon-precomposed" href="images/ico/apple-touch-icon-57-precomposed.png">



    <style>
        .buttons{
             background:none;
             border:none; 
             padding:0;
             font: inherit;
             cursor: pointer;
        }

    </style>

</head>
<body>



    <form id="form1" runat="server" defaultbutton="BtnLogin">

    <div class="container">
    	<div class="row">


			<div class="col-md-6 col-md-offset-3">
				<div class="panel">
					<div class="panel-heading">
						<div class="row">
							<div class="col-xs-6">
								<asp:Button runat="server" ID="BtnLoginView" Text="Login"  OnClick="BtnLoginView_Click" CssClass="buttons"/>
                            </div>
							<div class="col-xs-6">
							    <asp:Button runat="server" ID="btnRegisterView" Text="Register" CssClass="buttons" OnClick="btnRegisterView_Click"/>
                        	</div>
						</div>
						<hr>
					</div>
					<div class="panel-body">
						<div class="row">
							<div class="col-lg-12">
								<asp:MultiView ID="MultiView1" runat="server">


                    <asp:View ID="View1" runat="server">
                        <div>
                            <div>
                                <asp:TextBox runat="server" ID="LogUser" placeholder="Username" style="margin-bottom:10px;width:75%"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserLog" runat="server" ErrorMessage="Username is required." ControlToValidate="LogUser" Display="Dynamic"  CssClass="alert-text" ForeColor="Red" Font-Bold="True" ValidationGroup="Log" />
                            </div>
                            <div>
                                <asp:TextBox runat="server" ID="LogPass" placeholder="Password" style="margin-bottom:10px;width:75%" TextMode="Password"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassLog" runat="server" ErrorMessage="Password is required." ControlToValidate="LogPass" Display="Dynamic"  CssClass="alert-text" ForeColor="Red" Font-Bold="True" ValidationGroup="Log" />
                            </div>
                            <div>
                                <asp:Button runat="server" ID="BtnLogin" Text="Login" OnClick="BtnLogin_Click" ValidationGroup="Log"/>
                            </div>
                            <br />
                            <div class="alert alert-danger" style="width:75%" id="DivLog" runat="server">
                                 <asp:Label ID="DivLogLabel" runat="server" Text=""></asp:Label>
                                <br />
                            </div>
                            
                             
                        </div>
                    </asp:View>

                    <asp:View ID="View2" runat="server">
                         
                        
                        <div>
                             
                            <div>
                                <asp:TextBox runat="server" ID="RegUser" placeholder="Username" style="margin-bottom:10px;width:75%"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ErrorMessage="Username is required." ControlToValidate="RegUser" Display="Dynamic"  CssClass="alert-text" ForeColor="Red" Font-Bold="True" ValidationGroup="Reg" />
                            </div>
                            <div>
                                <asp:TextBox runat="server" ID="RegPass" placeholder="Password" style="margin-bottom:10px;width:75%" TextMode="Password"></asp:TextBox>
                                <br />
                                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidatorPass" runat="server" ErrorMessage="Password must be atleast 8 characters including a digit." ControlToValidate="RegPass" ValidationExpression="^.*(?=.{8,})(?=.*[\d]).*$" Display="Dynamic" CssClass="alert-text" ForeColor="Red" Font-Bold="True" ValidationGroup="Reg"></asp:RegularExpressionValidator>--%>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidatorPass" runat="server" ErrorMessage="Password is required." ControlToValidate="RegPass" Display="Dynamic"  CssClass="alert-text" ForeColor="Red" Font-Bold="True" ValidationGroup="Reg" />--%>
                            </div>
                             <div>
                                <asp:TextBox runat="server" ID="RegPass2" placeholder="Repeat Password" style="margin-bottom:10px;width:75%" TextMode="Password"></asp:TextBox>
                                <br />
                                <asp:CompareValidator ID="CompareValidatorPass" runat="server" ControlToCompare="RegPass2" ControlToValidate="RegPass" ErrorMessage="Passwords don't match." Display="Dynamic"  CssClass="alert-text" ForeColor="Red" Font-Bold="True" ValidationGroup="Reg" ></asp:CompareValidator>
                            </div>
                             <div>
                                <asp:TextBox runat="server" ID="RegEmail" placeholder="Email" style="margin-bottom:10px;width:75%"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Email is required." ControlToValidate="RegEmail" Display="Dynamic"  CssClass="alert-text" ForeColor="Red" Font-Bold="True" ValidationGroup="Reg" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Email must be valid." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" CssClass="alert-text" ForeColor="Red" Font-Bold="True" ControlToValidate="RegEmail" ValidationGroup="Reg"></asp:RegularExpressionValidator>
                            </div>
                             <div>
                                <asp:TextBox runat="server" ID="RegScrName" placeholder="Screen Name" style="margin-bottom:10px;width:75%"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorScrName" runat="server" ErrorMessage="Screen name is required." ControlToValidate="RegScrName" Display="Dynamic"  CssClass="alert-text" ForeColor="Red" Font-Bold="True" ValidationGroup="Reg" />
                            </div>
                            <div>
                                <asp:Button runat="server" ID="BtnReg" Text="Register" OnClick="BtnReg_Click" ValidationGroup="Reg" />
                            </div>
                            <br />
                            <div class="alert alert-danger" style="width:75%" id="DivReg" runat="server">
                                 <asp:Label ID="DivLabel" runat="server" Text=""></asp:Label>
                            </div>
                        </div>

                </asp:View>
                </asp:MultiView>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
    </form>




</body>
</html>
