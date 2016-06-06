using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class multicolor_AboutMonster : System.Web.UI.Page
{
    ServRef.Service1Client client = new ServRef.Service1Client();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] == null)
            Response.Redirect("Register.aspx");

        Bind();



     
    }

    protected void Bind()
    {
        try {
            DataSet ds = client.Geomon(Session["Name"].ToString());
            geomon.DataSource = ds.Tables[0];
            geomon.DataBind();
        }
        catch
        {
            noGeomon.Visible = true;
        }
    }

    protected void geomon_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        if (e.Item.ItemType == ListViewItemType.DataItem)
        {
            string stars = @"<img src=""images/star.gif""/>";
            Label lbl = (Label)e.Item.FindControl("geomonRarity");
            Label lbl2 = (Label)e.Item.FindControl("star");

            lbl2.Text = string.Join("", Enumerable.Repeat(stars, Int32.Parse(lbl.Text)));
        }
    }
}