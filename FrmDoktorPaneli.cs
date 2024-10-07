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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            baglan.Open();                  // DATAGRİDE DOKTORLARIN BİLGİLERİNİ GETİRME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select DoktorAd,DoktorSoyad,DoktorBrans,DoktorSifre,DoktorTc from tbl_doktorlar order by DoktorId desc", baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

            baglan.Open();              //COMBOBAXA BRANŞLARI GETİRME
            SqlCommand cmd1 = new SqlCommand("select*from tbl_branslar", baglan);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cmbbrans.Items.Add(dr1[1]);
            }
            baglan.Close();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİD ÇİFT TIKLANDIĞINDA VERİLERİ ARAÇLARA AKTARMA

            int satır = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[satır].Cells[0].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[satır].Cells[1].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[satır].Cells[2].Value.ToString();
            msktc.Text = dataGridView1.Rows[satır].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[satır].Cells[3].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
                                //EKLE BUTONU 
            baglan.Open();
            SqlCommand cmd2 = new SqlCommand("insert into tbl_doktorlar (doktorad,doktorsoyad,doktorbrans,doktorsifre,doktortc) values (@p1,@p2,@p3,@p4,@p5)", baglan);
            cmd2.Parameters.AddWithValue("@p1", txtad.Text);
            cmd2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            cmd2.Parameters.AddWithValue("@P3", cmbbrans.Text);
            cmd2.Parameters.AddWithValue("@p4", txtsifre.Text);
            cmd2.Parameters.AddWithValue("@p5", msktc.Text);
            cmd2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayır Gerçekleştirldi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
                                 //SİL BUTONU 
            baglan.Open();
            SqlCommand cmd3 = new SqlCommand("delete tbl_doktorlar where doktortc=@p1", baglan);
            cmd3.Parameters.AddWithValue("@p1", msktc.Text);
            cmd3.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silme İşlemi Tamamlandı!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay fr = new FrmSekreterDetay();
            fr.Show();
            this.Hide();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
                             //GÜNCELLE BUTONU
            baglan.Open();
            SqlCommand cmd4 = new SqlCommand("update tbl_doktorlar set Doktorad=@p1,doktorsoyad=@p2,DoktorBrans=@p3,doktorsifre=@p4 where doktortc=@p5", baglan);
            cmd4.Parameters.AddWithValue("@p1", txtad.Text);
            cmd4.Parameters.AddWithValue("@p2",txtsoyad.Text);
            cmd4.Parameters.AddWithValue("@p3",cmbbrans.Text);
            cmd4.Parameters.AddWithValue("@p4",txtsifre.Text);
            cmd4.Parameters.AddWithValue("@p5",msktc.Text);
            cmd4.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Bilgiler Başarılı Şekilde Güncellendi","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
