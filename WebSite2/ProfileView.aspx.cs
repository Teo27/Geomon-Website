using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class multicolor_ProfileView : System.Web.UI.Page
{

    ServRef.Service1Client client = new ServRef.Service1Client();

    protected void Page_Load(object sender, EventArgs e)
    {

        Session["Clicked"] = "Username";
        DivErr.Visible = false;
        // ListView.Sort("Id", SortDirection.Ascending);
        ScrNameLabel.Text = Session["Clicked"].ToString();
        Bind();
        

    }

    protected void ListView_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        if (e.Item.ItemType == ListViewItemType.DataItem)
        {
            string stars = @"<img src=""images/star.gif""/>";
            Label lbl = (Label)e.Item.FindControl("RarityLabel");
            Label lbl2 = (Label)e.Item.FindControl("star");

            lbl2.Text = string.Join("", Enumerable.Repeat(stars, Int32.Parse(lbl.Text)));
        }
    }

    public void Bind()
    {
        try
        {

            DataSet ds = client.ProfileView(Session["Clicked"].ToString());
            ListView.DataSource = ds.Tables[0];
            ListView.DataBind();
            bool hasRows = true;

            foreach (DataTable dt in ds.Tables)
            {
                if (dt.Rows.Count > 0)
                {
                    hasRows = true;
                }

                else
                {
                    hasRows = false;
                }
            }

            if (hasRows == true)
            {
                StepLabel.Text = ds.Tables[0].Rows[0]["Steps"].ToString();
                ScoreLabel.Text = ds.Tables[0].Rows[0]["Score"].ToString();
            }
            else
            {
                DivSuc.Visible = false;
            }

        }
        catch
        {
            DivErr.Visible = true;
        }
    }
}