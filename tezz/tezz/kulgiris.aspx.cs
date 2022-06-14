using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;



namespace tezz
{
    public partial class kulgiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btngiris_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
            baglanti.Open(); 
            string kul = txtkul.Text;
            string par = txtpar.Text;
            string sql = "SELECT * FROM kul_adi where kuladi='" + kul + "'";
            OleDbCommand veri1 = new OleDbCommand(sql, baglanti);
            OleDbDataReader dr = null;
            dr = veri1.ExecuteReader();
            string[] kulsor = new string[3];
            while (dr.Read())
            {
                if (dr[0].ToString() != "")
                {
                    kulsor[0] = dr[0].ToString();
                    kulsor[1] = dr[1].ToString();
                    kulsor[2] = dr[2].ToString();
                    
                }
                else
                {
                    break;
                }
            }
            Session.Add("sgiris", kulsor[0]);
            if(kul==kulsor[0]&&par==kulsor[2])
            {
                if(kulsor[1]=="ogrtmn")
                { Response.Redirect("ogrtmnanasyf.aspx");baglanti.Close(); }
                else
                { Response.Redirect("ogrencianasyf.aspx");baglanti.Close(); }
            }
            else
            {
                Label1.Text = "Kullanıcı adı veya parola hatalı tekrar deneyiniz!!!!";
                baglanti.Close();
            }
          
        }
      

        protected void btneklesil_Click(object sender, EventArgs e)
        {
            Response.Redirect("kuleklesil.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("parguncelle.aspx");
        }
    }

    
}