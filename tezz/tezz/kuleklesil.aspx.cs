using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace tezz
{
    public partial class kuleklesil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnekle_Click(object sender, EventArgs e)
        {
            string kim = DropDownList1.SelectedValue.ToString();
            if (txtkul1.Text == "" || txtpar1.Text == "")
            {
                DialogResult dialog2 = new DialogResult();
                dialog2 = MessageBox.Show("Lütfen Boş Alan Bırakmayınızz!!!", "HATA", MessageBoxButtons.YesNo);
            }
            else
            {
                try
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
                    baglanti.Open();
                    OleDbCommand kulekle = new OleDbCommand("insert into kul_adi(kuladi,parola,tur)values(kuladi,parola,kimm)", baglanti);
                    kulekle.Parameters.AddWithValue("kuladi", txtkul1.Text);
                    kulekle.Parameters.AddWithValue("parola", txtpar1.Text);
                    kulekle.Parameters.AddWithValue("kimm", kim);

                    kulekle.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch
                {
                    Label1.Text = "Bilinmeyen bir sorun oluştu tekrar deneyiniz!!!";
                }
                Response.Redirect("arasayfa.aspx");
            }
        }

        protected void btnsil_Click(object sender, EventArgs e)
        {
            if (txtkul1.Text == "")
            {
                DialogResult dialog2 = new DialogResult();
                dialog2 = MessageBox.Show("Lütfen silmek istediğiniz sorunun ID'sini giriniz!!!", "HATA", MessageBoxButtons.YesNo);
            }
            else
            {
                try
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
                    baglanti.Open();
                    OleDbCommand kulekle = new OleDbCommand("delete from kul_adi where kuladi=kullanici", baglanti);
                    kulekle.Parameters.AddWithValue("kullanici", txtkul1.Text);
                    kulekle.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch
                {
                    Label1.Text = "Bilinmeyen bir sorun oluştu tekrar deneyiniz!!!";
                }
                Response.Redirect("arasayfa.aspx");
            }
        }
    }
}