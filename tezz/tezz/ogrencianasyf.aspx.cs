using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tezz
{
    public partial class ogrencianasyf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Sayın " + Session["sgiris"].ToString() + " Hoşgeldiniz.";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("arasayfa.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("sbarasyf.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ogrsor.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ogrtgelcvp.aspx");
        }
    }
}