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
using System.Xml.Linq;


namespace HastahaneProjesi
{
    public partial class FrmHastaGiris : Form
    {

        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaUyeKayit fr = new FrmHastaUyeKayit();
            fr.Show();

        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select HastaTC,HastaSifre from Tbl_Hastalar where HastaTC=@p1 and hastasifre=@p2", baglan);
            komut1.Parameters.AddWithValue("@p1", msktc.Text);
            komut1.Parameters.AddWithValue("@p2", txtsifre.Text);

            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                FrmHastaDetay hstd = new FrmHastaDetay();
                hstd.hastatc = Convert.ToString(msktc.Text);
                hstd.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış Tc yada Şifre Girdiniz!" + "\n" + "\n" + " Kontrol Edip Tekrar Deneyin...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglan.Close();


        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
