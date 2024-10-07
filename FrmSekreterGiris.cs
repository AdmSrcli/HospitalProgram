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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");


        private void btngiris_Click(object sender, EventArgs e)

        {


            baglan.Open();
            SqlCommand k1 = new SqlCommand("select*from tbl_sekreter where sekretertc=@p1 and sekretersifre=@p2", baglan);
            k1.Parameters.AddWithValue("@p1", msktc.Text);
            k1.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader d1 = k1.ExecuteReader();
            if (d1.Read())
            {
                FrmSekreterDetay frsd = new FrmSekreterDetay();
                frsd.sectc = msktc.Text;
                frsd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Tc veya Şifre Girdiniz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            baglan.Close();





        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
