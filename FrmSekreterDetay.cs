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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        public string sectc;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblsekretertc.Text = sectc;

            baglan.Open();                      // SEKRETERİN ADININ ÇEKİLDİĞİ ALAN
            SqlCommand k1 = new SqlCommand("select*from tbl_sekreter where sekretertc=@p1", baglan);
            k1.Parameters.AddWithValue("@p1", lblsekretertc.Text);
            SqlDataReader dr1 = k1.ExecuteReader();
            while (dr1.Read())
            {
                lblsekreteradsoyad.Text = dr1[1].ToString();
            }

            baglan.Close();

            baglan.Open();              // BRANLARI DATAGRİDE AKTARMA 
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select*from tbl_branslar", baglan);
            da1.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

            baglan.Open();          // DOKTORLARI DATAGRİDE AKTARMA 
            DataTable dt1 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select*from tbl_doktorlar order by doktorId desc", baglan);
            da2.Fill(dt1);
            dataGridView2.DataSource = dt1;
            baglan.Close();

            baglan.Open();              // BRANŞLARI COMBOBOXA ÇEKME
            SqlCommand z1 = new SqlCommand("select * from tbl_branslar", baglan);
            SqlDataReader d2 = z1.ExecuteReader();
            while (d2.Read())
            {
                cmbbrans.Items.Add(d2[1]);
            }
            baglan.Close();


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();  // RANDEVU KAYDET PANELİ

            SqlCommand K2 = new SqlCommand("insert into tbl_randevular  (Randevutarih,randevusaat,randevubrans,randevudoktor,randevudurum) values (@r1,@r2,@r3,@r4,@p5)", baglan);
            K2.Parameters.AddWithValue("@r1", msktarih.Text);
            K2.Parameters.AddWithValue("@r2", msksaat.Text);
            K2.Parameters.AddWithValue("@r3", cmbbrans.Text);
            K2.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            if (checkBox1.Checked) 
            {
                K2.Parameters.AddWithValue("@p5", 1);
            }
            else
            {
                K2.Parameters.AddWithValue("@p5", 0);
            }
            K2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Randevu Kayıt Edildi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();              // RANDEVU GÜNCELLEME 
            SqlCommand K3 = new SqlCommand("update tbl_Randevular set RandevuTarih=@w1,randevusaat=@w2,randevubrans=@w3,randevudoktor=@w4,Hastatc=w5, where RandevuId=@w6", baglan);
            K3.Parameters.AddWithValue("@w1", msktarih.Text);
            K3.Parameters.AddWithValue("@w2", msksaat.Text);
            K3.Parameters.AddWithValue("@w3", cmbbrans.Text);
            K3.Parameters.AddWithValue("@w4", cmbdoktor.Text);
            K3.Parameters.AddWithValue("@w5", msktc.Text);
            K3.Parameters.AddWithValue("@w6", txtid.Text);
             K3.ExecuteNonQuery();
            baglan.Close();
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            baglan.Open();          // DOKTORLARI COMBOBOXA ÇEKME
            SqlCommand kom1 = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where Doktorbrans=@p1", baglan);
            kom1.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader d1 = kom1.ExecuteReader();
            while (d1.Read())
            {
                cmbdoktor.Items.Add(d1[0] + " " + d1[1]);
            }
            baglan.Close();

        }

        private void btnrandolustur_Click(object sender, EventArgs e)
        {
            baglan.Open();                  //DUYURU OLUŞTURMA
            SqlCommand x1 = new SqlCommand("insert into tbl_duyurular ( duyurular) values (@p1) ", baglan);
            x1.Parameters.AddWithValue("@p1", rchduyuru.Text.ToString());
            x1.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Duyuru Kaydedildi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frdp = new FrmDoktorPaneli();
            frdp.Show();
            this.Hide();
        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();
            this.Hide();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr2 = new FrmDuyurular();
            fr2.Show();
        }
    }
}
