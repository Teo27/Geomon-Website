using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class multicolor_Register : System.Web.UI.Page
{
    ServRef.Service1Client ser = new ServRef.Service1Client();

    protected void Page_Load(object sender, EventArgs e)
    {
        DivReg.Visible = false;

        DivLog.Visible = false;
        if(!IsPostBack)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }

    protected void BtnLoginView_Click(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View1);
    }

    protected void btnRegisterView_Click(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View2);
    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        DivLog.Visible = true;
        int success = ser.Login(LogUser.Text, LogPass.Text);
        if (success == 0)
        {
            Session["Username"] = LogUser.Text;
            Response.Redirect("Home.aspx");
            
        }  
        else
        {
            DivLogLabel.Text = "Username or password are incorrect or don't exist";
        }
    }

    protected void BtnReg_Click(object sender, EventArgs e)
    {
        
        int success = ser.CreateCustomer(RegScrName.Text, RegUser.Text, RegPass.Text, RegEmail.Text, DateTime.Now);
        
        DivReg.Visible = true;
        if(success == 0)
        {
            DivLogLabel.Text = "Registration was sucessful";
            DivLog.Attributes["class"] = "alert alert-success";
            MultiView1.SetActiveView(View1);
            DivLog.Visible = true;
        }
        else if(success == -1)
        {
            DivLabel.Text = "Email is already taken";
        }
        else if(success == -2)
        {
            DivLabel.Text = "Screen name is already taken";
        }
        else if(success == -3)
        {
            DivLabel.Text = "Username is already taken";
        }
        else
        {
            DivLabel.Text = "There was a problem, please try again later";
        }
    }
}