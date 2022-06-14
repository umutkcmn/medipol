using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tezz
{
    public partial class sorubank : System.Web.UI.Page
    {
        public int dsayi = 0;
        public int bsayi = 0;
        public int ysayi = 0;
        public string Ss1;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Başarılar " + Session["sgiris"].ToString();
        }

    

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("arasayfa.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
            baglanti.Open();
            string kladi = Session["sgiris"].ToString();
            string sql = "SELECT * FROM kul_adi where kuladi='" + kladi + "'";
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
            if (kulsor[1] == "ogrtmn")
            { Response.Redirect("ogrtmnanasyf.aspx"); baglanti.Close(); }
            else
            { Response.Redirect("ogrencianasyf.aspx"); baglanti.Close(); }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string s1 = RadioButtonList1.SelectedValue.ToString();
            Ss1 = s1;
            string s2 = RadioButtonList2.SelectedValue.ToString();
            string s3 = RadioButtonList3.SelectedValue.ToString();
            string s4 = RadioButtonList4.SelectedValue.ToString();
            string s5 = RadioButtonList5.SelectedValue.ToString();
            string s6 = RadioButtonList6.SelectedValue.ToString();
            string s7 = RadioButtonList7.SelectedValue.ToString();
            string s8 = RadioButtonList8.SelectedValue.ToString();
            string s9 = RadioButtonList9.SelectedValue.ToString();
            string s10 = RadioButtonList10.SelectedValue.ToString();
            string s11 = RadioButtonList11.SelectedValue.ToString();
            string s12 = RadioButtonList12.SelectedValue.ToString();
            string s13 = RadioButtonList13.SelectedValue.ToString();
            string s14 = RadioButtonList14.SelectedValue.ToString();
            string s15 = RadioButtonList15.SelectedValue.ToString();
            string s16 = RadioButtonList16.SelectedValue.ToString();
            string s17 = RadioButtonList17.SelectedValue.ToString();
            string s18 = RadioButtonList18.SelectedValue.ToString();
            string s19 = RadioButtonList19.SelectedValue.ToString();
            string s20 = RadioButtonList20.SelectedValue.ToString();
            Label2.Text = s1;
            Label3.Text = s2;
            Label4.Text = s3;
            Label5.Text = s4;
            Label6.Text = s5;
            Label7.Text = s6;
            Label8.Text = s7;
            Label9.Text = s8;
            Label10.Text = s9;
            Label11.Text = s10;
            Label22.Text = s11;
            Label23.Text = s12;
            Label24.Text = s13;
            Label25.Text = s14;
            Label26.Text = s15;
            Label27.Text = s16;
            Label28.Text = s17;
            Label29.Text = s18;
            Label30.Text = s19;
            Label31.Text = s20;
            
            if(s1=="b")
            { dsayi++; Label12.ForeColor = System.Drawing.Color.Green; Label12.Text = "DOĞRU"; }
            else if(s1=="")
            { bsayi++; Label12.ForeColor = System.Drawing.Color.Blue; Label12.Text = "BOŞ"; }
            else
            { ysayi++; Label12.ForeColor = System.Drawing.Color.Red; Label12.Text = "B"; }

            if (s2 == "c")
            { dsayi++; Label13.ForeColor = System.Drawing.Color.Green; Label13.Text = "DOĞRU"; }
            else if (s2 == "")
            { bsayi++; Label13.ForeColor = System.Drawing.Color.Blue; Label13.Text = "BOŞ"; }
            else
            { ysayi++; Label13.ForeColor = System.Drawing.Color.Red; Label13.Text = "C"; }

            if (s3 == "d")
            { dsayi++; Label14.ForeColor = System.Drawing.Color.Green; Label14.Text = "DOĞRU"; }
            else if (s3 == "")
            { bsayi++; Label14.ForeColor = System.Drawing.Color.Blue; Label14.Text = "BOŞ"; }
            else
            { ysayi++; Label14.ForeColor = System.Drawing.Color.Red; Label14.Text = "D"; }

            if (s4 == "d")
            { dsayi++; Label15.ForeColor = System.Drawing.Color.Green; Label15.Text = "DOĞRU"; }
            else if (s4 == "")
            { bsayi++; Label15.ForeColor = System.Drawing.Color.Blue; Label15.Text = "BOŞ"; }
            else
            { ysayi++; Label15.ForeColor = System.Drawing.Color.Red; Label15.Text = "D"; }

            if (s5 == "c")
            { dsayi++; Label16.ForeColor = System.Drawing.Color.Green; Label16.Text = "DOĞRU"; }
            else if (s5 == "")
            { bsayi++; Label16.ForeColor = System.Drawing.Color.Blue; Label16.Text = "BOŞ"; }
            else
            { ysayi++; Label16.ForeColor = System.Drawing.Color.Red; Label16.Text = "C"; }

            if (s6 == "a")
            { dsayi++; Label17.ForeColor = System.Drawing.Color.Green; Label17.Text = "DOĞRU"; }
            else if (s6 == "")
            { bsayi++; Label17.ForeColor = System.Drawing.Color.Blue; Label17.Text = "BOŞ"; }
            else
            { ysayi++; Label17.ForeColor = System.Drawing.Color.Red; Label17.Text = "A"; }

            if (s7 == "a")
            { dsayi++; Label18.ForeColor = System.Drawing.Color.Green; Label18.Text = "DOĞRU"; }
            else if (s7 == "")
            { bsayi++; Label18.ForeColor = System.Drawing.Color.Blue; Label18.Text = "BOŞ"; }
            else
            { ysayi++; Label18.ForeColor = System.Drawing.Color.Red; Label18.Text = "A"; }

            if (s8 == "d")
            { dsayi++; Label19.ForeColor = System.Drawing.Color.Green; Label19.Text = "DOĞRU"; }
            else if (s8 == "")
            { bsayi++; Label19.ForeColor = System.Drawing.Color.Blue; Label19.Text = "BOŞ"; }
            else
            { ysayi++; Label19.ForeColor = System.Drawing.Color.Red; Label19.Text = "D"; }

            if (s9 == "d")
            { dsayi++; Label20.ForeColor = System.Drawing.Color.Green; Label20.Text = "DOĞRU"; }
            else if (s9 == "")
            { bsayi++; Label20.ForeColor = System.Drawing.Color.Blue; Label20.Text = "BOŞ"; }
            else
            { ysayi++; Label20.ForeColor = System.Drawing.Color.Red; Label20.Text = "D"; }

            if (s10 == "c")
            { dsayi++; Label21.ForeColor = System.Drawing.Color.Green; Label21.Text = "DOĞRU"; }
            else if (s10 == "")
            { bsayi++; Label21.ForeColor = System.Drawing.Color.Blue; Label21.Text = "BOŞ"; }
            else
            { ysayi++; Label21.ForeColor = System.Drawing.Color.Red; Label21.Text = "C"; }

            if (s11 == "b")
            { dsayi++; Label32.ForeColor = System.Drawing.Color.Green; Label32.Text = "DOĞRU"; }
            else if (s11 == "")
            { bsayi++; Label32.ForeColor = System.Drawing.Color.Blue; Label32.Text = "BOŞ"; }
            else
            { ysayi++; Label32.ForeColor = System.Drawing.Color.Red; Label32.Text = "B"; }

            if (s12 == "a")
            { dsayi++; Label33.ForeColor = System.Drawing.Color.Green; Label33.Text = "DOĞRU"; }
            else if (s12 == "")
            { bsayi++; Label33.ForeColor = System.Drawing.Color.Blue; Label33.Text = "BOŞ"; }
            else
            { ysayi++; Label33.ForeColor = System.Drawing.Color.Red; Label33.Text = "A"; }

            if (s13 == "c")
            { dsayi++; Label34.ForeColor = System.Drawing.Color.Green; Label34.Text = "DOĞRU"; }
            else if (s13 == "")
            { bsayi++; Label34.ForeColor = System.Drawing.Color.Blue; Label34.Text = "BOŞ"; }
            else
            { ysayi++; Label34.ForeColor = System.Drawing.Color.Red; Label34.Text = "C"; }

            if (s14 == "b")
            { dsayi++; Label35.ForeColor = System.Drawing.Color.Green; Label35.Text = "DOĞRU"; }
            else if (s14 == "")
            { bsayi++; Label35.ForeColor = System.Drawing.Color.Blue; Label35.Text = "BOŞ"; }
            else
            { ysayi++; Label35.ForeColor = System.Drawing.Color.Red; Label35.Text = "B"; }

            if (s15 == "d")
            { dsayi++; Label36.ForeColor = System.Drawing.Color.Green; Label36.Text = "DOĞRU"; }
            else if (s15 == "")
            { bsayi++; Label36.ForeColor = System.Drawing.Color.Blue; Label36.Text = "BOŞ"; }
            else
            { ysayi++; Label36.ForeColor = System.Drawing.Color.Red; Label36.Text = "D"; }

            if (s16 == "d")
            { dsayi++; Label37.ForeColor = System.Drawing.Color.Green; Label37.Text = "DOĞRU"; }
            else if (s16 == "")
            { bsayi++; Label37.ForeColor = System.Drawing.Color.Blue; Label37.Text = "BOŞ"; }
            else
            { ysayi++; Label37.ForeColor = System.Drawing.Color.Red; Label37.Text = "D"; }

            if (s17 == "b")
            { dsayi++; Label38.ForeColor = System.Drawing.Color.Green; Label38.Text = "DOĞRU"; }
            else if (s17 == "")
            { bsayi++; Label38.ForeColor = System.Drawing.Color.Blue; Label38.Text = "BOŞ"; }
            else
            { ysayi++; Label38.ForeColor = System.Drawing.Color.Red; Label38.Text = "B"; }

            if (s18 == "c")
            { dsayi++; Label39.ForeColor = System.Drawing.Color.Green; Label39.Text = "DOĞRU"; }
            else if (s18 == "")
            { bsayi++; Label39.ForeColor = System.Drawing.Color.Blue; Label39.Text = "BOŞ"; }
            else
            { ysayi++; Label39.ForeColor = System.Drawing.Color.Red; Label39.Text = "C"; }

            if (s19 == "b")
            { dsayi++; Label40.ForeColor = System.Drawing.Color.Green; Label40.Text = "DOĞRU"; }
            else if (s19 == "")
            { bsayi++; Label40.ForeColor = System.Drawing.Color.Blue; Label40.Text = "BOŞ"; }
            else
            { ysayi++; Label40.ForeColor = System.Drawing.Color.Red; Label40.Text = "B"; }

            if (s20 == "c")
            { dsayi++; Label41.ForeColor = System.Drawing.Color.Green; Label41.Text = "DOĞRU"; }
            else if (s20 == "")
            { bsayi++; Label41.ForeColor = System.Drawing.Color.Blue; Label41.Text = "BOŞ"; }
            else
            { ysayi++; Label41.ForeColor = System.Drawing.Color.Red; Label41.Text = "C"; }

            int spuan = dsayi * 5;

            Label42.Text = "Alınan puan " + spuan + " toplam doğru sayısı " + dsayi + " toplam yanlış sayısı " + ysayi + " toplam boş sayısı " + bsayi;
        }
    }
}