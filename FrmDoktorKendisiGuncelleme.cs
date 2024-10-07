using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastahaneProjesi
{
    public partial class FrmDoktorKendisiGuncelleme : Form
    {
        public FrmDoktorKendisiGuncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        public string tcdoc;
        private void FrmDoktorKendisiGuncelleme_Load(object sender, EventArgs e)
        {
            msktc.Text = tcdoc;
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select*from tbl_doktorlar where doktortc=@p1", baglan);
            cmd.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txtad.Text = rdr[1].ToString();
                txtsoyad.Text = rdr[2].ToString();
                cmbbrans.Text = rdr[3].ToString();
                txtsifre.Text = rdr[5].ToString();
            }
            baglan.Close();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kom = new SqlCommand("update tbl_doktorlar set doktorad=@p1,doktorsoyad=@p2,doktorBrans=@p3,doktorsifre=@p4 where doktortc=@p5", baglan);
            kom.Parameters.AddWithValue("@p1",txtad.Text);
            kom.Parameters.AddWithValue("@p2",txtsoyad.Text);
            kom.Parameters.AddWithValue("@p3",cmbbrans.Text);
            kom.Parameters.AddWithValue("@p4",txtsifre.Text);
            kom.Parameters.AddWithValue("@p5", msktc.Text);
            kom.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Başarılı Şekilde Güncellendi!","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
