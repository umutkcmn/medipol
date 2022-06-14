using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace tezz
{
    public partial class ogrtgelcvp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Vericek();
            }
        }

        private void Vericek()
        {
            string kulad = Session["sgiris"].ToString();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
            baglanti.Open();
            OleDbCommand sql = new OleDbCommand("select * from sorular where ogrkul=kuladi ", baglanti);
            sql.Parameters.AddWithValue("kuladi", kulad);
            OleDbDataReader dr;
            try
            {
                dr = sql.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                dr.Close();

            }
            catch
            {
                Response.Write("Bir hata oluştu");
            }
            finally
            {
                baglanti.Close();
            }
            
        }


     

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                DialogResult dialog2 = new DialogResult();
                dialog2 = MessageBox.Show("Lütfen silmek istediğiniz sorunun ID'sini giriniz!!!", "HATA", MessageBoxButtons.YesNo);
            }
            else
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Veri Silinsin mi?", "ÇIKIŞ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
                    baglanti.Open();
                    OleDbCommand idsil = new OleDbCommand("delete from sorular where id=vid", baglanti);
                    idsil.Parameters.AddWithValue("vid", TextBox1.Text);
                    idsil.ExecuteNonQuery();
                    baglanti.Close();
                    Response.Redirect("ogrencianasyf.aspx");
                }
                else
                {
                    MessageBox.Show("Veri Silinmedi");
                }
            }
        }
    }
}