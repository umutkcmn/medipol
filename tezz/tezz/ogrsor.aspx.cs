using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace tezz
{
    public partial class ogrsor : System.Web.UI.Page
    {
        public string yazid { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

                /*string fotyol = Image1.ImageUrl;
                byte[] imageArray = System.IO.File.ReadAllBytes(Server.MapPath(fotyol));
                string resimkod = Convert.ToBase64String(imageArray);*/
                string yzsor = TextBox1.Text;
                string ogkul = Session["sgiris"].ToString();
               // TextBox1.Text = resimkod;
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("kullaniciler.accdb"));
                baglanti.Open();
                string sql2 = "SELECT top 1 id FROM sorular order by id desc;";
                OleDbCommand veri2 = new OleDbCommand(sql2, baglanti);
                OleDbDataReader dr = null;
                dr = veri2.ExecuteReader();
                string[] Dbid = new string[1];
                while (dr.Read())
                {
                if (dr[0].ToString() != "")
                    {
                        Dbid[0] = dr[0].ToString();
                    }
                    else
                    {
                        break;
                    }
                    
                
                }
            int yazid = Convert.ToInt32(Dbid[0]);
            if (yazid == 0)
            {
                yazid = 1;
            }
            else
            {
                yazid++;
            }

            OleDbCommand sorekle = new OleDbCommand("insert into sorular(id,soru,ogrkul)values(yid,ysor,ogkul)", baglanti);
            sorekle.Parameters.AddWithValue("yid", yazid);
            sorekle.Parameters.AddWithValue("ysor", yzsor);
            sorekle.Parameters.AddWithValue("okul", ogkul);

            sorekle.ExecuteNonQuery();
            baglanti.Close();
            Response.Write("<script>confirm('Soru Numaranız= " + yazid + "')</script>");
            Response.Redirect("ogrencianasyf.aspx");
           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          /*  string folderPath = Server.MapPath("~/Images/");

            if (!Directory.Exists(folderPath))
            {

                Directory.CreateDirectory(folderPath);
            }
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
            if (FileUpload1.HasFile)
            {
                try
                {
                    if (FileUpload1.PostedFile.ContentType == "image/jpeg" ||
                        FileUpload1.PostedFile.ContentType == "image/jpg" ||
                        FileUpload1.PostedFile.ContentType == "image/png")
                    {

                        string filename = Path.GetFileName(FileUpload1.FileName);
                        if (filename != "")
                        {
                            Image1.ImageUrl = "~/Images/" + Path.GetFileName(FileUpload1.FileName);
                            Label1.Text = filename + " dosyası yüklendi!";

                        }


                    }
                    else
                        Label1.Text = "Sadece JPEG JPG PNG formatı kabul edilir.";
                }
                catch (Exception ex)
                {
                    Label1.Text = "Dosya yüklenemedi: " + ex.Message;
                }
            }
          */

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ogrencianasyf.aspx");
        }
    }
}

   
 

    
