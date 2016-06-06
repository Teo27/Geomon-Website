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

        Bind();


    }

    public void Bind()
    {
        try
        {

            DataSet ds = client.Achievements(Session["Username"].ToString());
            ListAch.DataSource = ds.Tables[0];
            ListAch.DataBind();

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
            DivErr.Visible=true;
        }

    }

   
}