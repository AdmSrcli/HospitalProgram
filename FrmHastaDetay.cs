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
    public partial class FrmHastaDetay : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        public string hastatc;
        public FrmHastaDetay()
        {
            InitializeComponent();
        }




        private void FrmHastaDetay_Load(object sender, EventArgs e)     // FORM AÇILDIĞINDA
        {
            lbltc.Text = hastatc;

            baglan.Open();
            SqlCommand kmt1 = new SqlCommand("select hastaad,hastasoyad from tbl_hastalar where hastatc=@p1", baglan);
            kmt1.Parameters.AddWithValue("@p1", hastatc);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString() + " " + dr1[1].ToString();
            }
            baglan.Close();



            baglan.Open();
            SqlCommand kmt2 = new SqlCommand("Select*from tbl_branslar", baglan);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[1].ToString());
            }
            baglan.Close();

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)      // BRANŞ SEÇTİĞİMİZDE 
        {
            cmbdoktor.Items.Clear();
            baglan.Open();
            SqlCommand cm1 = new SqlCommand("Select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@z1", baglan);
            cm1.Parameters.AddWithValue("@z1", cmbbrans.Text.ToString());
            SqlDataReader d5 = cm1.ExecuteReader();
            while (d5.Read())
            {
                cmbdoktor.Items.Add(d5[0] + " " + d5[1]);
            }
            baglan.Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)     // DOKTOR SEÇTİĞİMİZDE 
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where Randevubrans ='" + cmbbrans.Text + "'" + " " + "and randevudoktor ='" + cmbdoktor.Text + "'" + " " + "and randevudurum ='0'", baglan);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglan.Close();

            baglan.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Randevular where  randevudurum ='1' and hastatc='" + lbltc.Text + "'", baglan);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            baglan.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  // LİNK TIKLANDIĞINDA 
        {
            HastaGuncelle hg = new HastaGuncelle();
            hg.Tcno = lbltc.Text;
            hg.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = dataGridView2.SelectedCells[0].RowIndex;
            txtrandevuid.Text = dataGridView2.Rows[z].Cells[0].Value.ToString();
            cmbbrans.Text = dataGridView2.Rows[z].Cells[3].Value.ToString();
            cmbdoktor.Text = dataGridView2.Rows[z].Cells[4].Value.ToString();
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update tbl_randevular set hastatc=@p1,hastasikayet=@p2,randevudurum=@p3  where RandevuId = @p4", baglan);
            cmd.Parameters.AddWithValue("@p1", lbltc.Text);
            cmd.Parameters.AddWithValue("@p2", rchsikayet.Text);
            cmd.Parameters.AddWithValue("@p3", 1);
            cmd.Parameters.AddWithValue("@p4", txtrandevuid.Text.ToString());
            cmd.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Randevu Başarılı Şekilde Oluşturuldu!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        
    }
}
