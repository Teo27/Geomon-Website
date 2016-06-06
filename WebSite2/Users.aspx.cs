using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class multicolor_Empty : System.Web.UI.Page
{
    ServRef.Service1Client client = new ServRef.Service1Client();

    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)

        //{
        //    Bind();

        //}
    }

    //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    //{


    //}

    //protected void GridViewHighscore_PageIndexChanging(object sender, EventArgs e)
    //{

    //}

    //protected void Bind()
    //{
    //    DataSet ds = client.Users();
    //    GridViewUsers.DataSource = ds.Tables[0];
    //    GridViewUsers.DataBind();
    //}

    //protected void ButtonAddFriend_Click(object sender, EventArgs e)
    //{
    //    Button btn = (Button)(sender);
    //    string FriendUsername = btn.CommandArgument;
    //    Session["FriendUsername"] = FriendUsername;
    //    string Username = Session["Username"].ToString();
    //    client.AddFriend(Username, FriendUsername);
    //}


}