using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tezz
{
    public partial class ogrtmnanasyf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Sayın " + Session["sgiris"].ToString() + " Hoşgeldiniz.";
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("kulgiris.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("cvpver.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("sbarasyf.aspx");
        }
    }
}