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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        public string doktc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbldoktortc.Text = doktc.ToString();
            baglan.Open();
            SqlCommand cmd1 = new SqlCommand("select*from tbl_doktorlar where doktortc=@p1", baglan);
            cmd1.Parameters.AddWithValue("@p1", lbldoktortc.Text);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                lbldoktoradsoyad.Text = dr1[1] + " " + dr1[2];
            }
            baglan.Close();

            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_Randevular where Randevudoktor='" + lbldoktoradsoyad.Text + "'" + " " + "and randevudurum='1'", baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int say = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView1.Rows[say].Cells[7].Value.ToString();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular sf = new FrmDuyurular();
            sf.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbilgiduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorKendisiGuncelleme fd=new FrmDoktorKendisiGuncelleme();
            fd.tcdoc=lbldoktortc.Text;
            fd.Show();
        }
    }
}
