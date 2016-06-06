using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class multicolor_Collection : System.Web.UI.Page
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

    protected void ButtonAll_Click(object sender, EventArgs e)
    {
        Bind();
    }

    protected void ButtonRare_Click(object sender, EventArgs e)
    {
        try
        {
            string slc = "Rarity > 2";
            DataSet ds = client.Collection(Session["Username"].ToString());

            ds.Tables[0].DefaultView.RowFilter = slc;
            collectionList.DataSource = ds.Tables[0];
            collectionList.DataBind();
        }
        catch
        {
            DivErr.Visible = true;
        }
        

    }

    protected void ButtonCommon_Click(object sender, EventArgs e)
    {
        try
        {
            string slc = "Rarity < 3";
            DataSet ds = client.Collection(Session["Username"].ToString());

            ds.Tables[0].DefaultView.RowFilter = slc;
            collectionList.DataSource = ds.Tables[0];

            collectionList.DataBind();
        }
        catch
        {
            DivErr.Visible = true;
        }
        


    }

    protected void Bind()
    {
        try
        {
            DataSet ds = client.Collection(Session["Username"].ToString());
            collectionList.DataSource = ds.Tables[0];
            collectionList.DataBind();

            if (ds.Tables[0].Rows.Count != 0)
            {
                int cur = ds.Tables[0].Rows.Count;
                int max = Int32.Parse(ds.Tables[0].Rows[0]["Max"].ToString());

                int prog = (cur * 100) / max;


                ProgBar.Attributes["style"] = "width:" + prog.ToString() + "%";
                ProgBar.Attributes["aria-valuenow"] = prog.ToString();
                ProgressLabel.Text = cur + "/" + max;
            }
            
        }
        catch
        {
            DivErr.Visible = true;
        }
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


    protected void ButtonGeomon_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btn = (ImageButton)(sender);
            string name = btn.CommandArgument;
            Session["Name"] = name;
            Response.Redirect("AboutMonster.aspx");
        }
        catch (Exception e2)
        {
            Console.WriteLine(e2.ToString());
        }
       
    }
}