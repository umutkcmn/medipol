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
    public partial class cvpver : System.Web.UI.Page
    {
        private void Vericek()
        {
            string kulad = Session["sgiris"].ToString();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
            baglanti.Open();
            OleDbCommand sql = new OleDbCommand("select * from sorular  ", baglanti);
            
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
            protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Vericek();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ogrtmnanasyf.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("kulgiris.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            
            if (TextBox2.Text == "")
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
                    idsil.Parameters.AddWithValue("vid", TextBox2.Text);
                    idsil.ExecuteNonQuery();
                    baglanti.Close();

                    Response.Redirect("ogrtmnanasyf.aspx");
                }
                else
                {
                    MessageBox.Show("Veri Silinmedi");
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text == "")
            {
                DialogResult dialog2 = new DialogResult();
                dialog2 = MessageBox.Show("Lütfen silmek istediğiniz sorunun ID'sini giriniz!!!", "HATA", MessageBoxButtons.YesNo);
            }
            else
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
                baglanti.Open();
                string ysorr = TextBox1.Text;
                OleDbCommand idekle = new OleDbCommand("update sorular set cevap='" + ysorr + "' where id=yid;", baglanti);
                idekle.Parameters.AddWithValue("yid", Convert.ToInt32(TextBox3.Text));

                idekle.ExecuteNonQuery();
                baglanti.Close();

                Response.Redirect("ogrtmnanasyf.aspx");
            }
        }
    }
}