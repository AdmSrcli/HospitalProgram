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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_Branslar", baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay frsd = new FrmSekreterDetay();
            frsd.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int say = dataGridView1.SelectedCells[0].RowIndex;
            txtbransid.Text = dataGridView1.Rows[say].Cells[0].Value.ToString();
            txtbransad.Text = dataGridView1.Rows[say].Cells[1].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand d1 = new SqlCommand("insert into tbl_Branslar (bransad) values (@p1) ", baglan);
            d1.Parameters.AddWithValue("@p1", txtbransad.Text);
            d1.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Başarılı Şekilde Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand d2 = new SqlCommand("delete tbl_branslar where BransId=@p1", baglan);
            d2.Parameters.AddWithValue("@p1", txtbransid.Text);
            d2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Baarılı Şekilde Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand d3 = new SqlCommand("update tbl_branslar set bransad=@p1 where bransId=@p2", baglan);
            d3.Parameters.AddWithValue("@p1", txtbransad.Text);
            d3.Parameters.AddWithValue("@p2",txtbransid.Text);
            d3.ExecuteNonQuery();
            baglan.Close() ;
            MessageBox.Show("Kayıtlar Başarılı Şekilde Güncellendi!","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
