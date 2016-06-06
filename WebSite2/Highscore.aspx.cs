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

        

        DivErr.Visible = false;
        DivNoUser.Visible = false;

        if (!IsPostBack)

        {
            Bind();
        }
    }

    protected void Bind()
    {
        try
        {
            DataSet ds = client.Highscore();
            GridViewHighscore.DataSource = ds.Tables[0];
            GridViewHighscore.DataBind();
        }
        catch
        {
            DivErr.Visible = true;
        }
        
    }

    protected void GridViewHighscore_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewHighscore.PageIndex = e.NewPageIndex;

        Bind();
    }

    protected void GridViewHighscore_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            string person = TBSearch.Text.Trim();
            DataSet ds = client.Highscore();
            DataView view = new DataView();
            view.Table = ds.Tables[0];
            view.RowFilter = "ScrName = '" + person + "'";
            GridViewHighscore.DataSource = view;
            GridViewHighscore.DataBind();
            if (view.Count == 0)
            {
                DivNoUser.Visible = true;
            }
            
           
        }
        catch
        {

        }
       

    }
}