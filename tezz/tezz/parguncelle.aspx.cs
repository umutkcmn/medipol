using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tezz
{
    public partial class parguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnguncelle_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
            baglanti1.Open();
            string kull = txtkul2.Text;
            string mpar = txtpar3.Text;
            string sql = "SELECT * FROM kul_adi where kuladi='" + kull + "'";
            OleDbCommand veri1 = new OleDbCommand(sql, baglanti1);
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
            if (kulsor[2] == mpar)
            {

                try
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
                    baglanti.Open();
                    string gnkul = txtkul2.Text;
                    string gnpar = txtpar2.Text;
                    OleDbCommand guncel = new OleDbCommand("Update kul_adi set parola='" + gnpar + "' where kuladi='" + gnkul + "'", baglanti);


                    guncel.ExecuteNonQuery();
                    baglanti.Close();

                }
                catch
                {
                    Label1.Text = "Bilinmeyen bir sorun oluştu tekrar deneyiniz!!!!";
                }
                Response.Redirect("arasayfa.aspx");
            }
            else
            {
                Label1.Text = "Mevcut Parola Yanlış Girildi!!!!!!!";
            }
        }
    }
}
            
            
            

            
            
            

            
        
    
