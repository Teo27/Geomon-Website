using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;

public partial class multicolor_ProfileView : System.Web.UI.Page
{
    ServRef.Service1Client client = new ServRef.Service1Client();

    protected void Page_Load(object sender, EventArgs e)
    {

        DivErr.Visible = false;

        if (!Page.IsPostBack)
        {
            Bind();
        }
    }

   

    protected void ListView_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        if (e.Item.ItemType == ListViewItemType.DataItem)
        {
            int prog = 50;
            HtmlGenericControl myDiv = e.Item.FindControl("ProgBar") as HtmlGenericControl;
            myDiv.Attributes["style"] = "width:" + prog.ToString() + "%";
            myDiv.Attributes["aria-valuenow"] = prog.ToString();
        }
    }

    protected void Bind()
    {
        try
        {
            DataSet ds = client.GetEggs(Session["Username"].ToString());
            ListView.DataSource = ds.Tables[0];
            ListView.DataBind();
        }
        catch
        {
            DivErr.Visible = true;
        }
        
    }

}