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

    public partial class HastaGuncelle : Form
    {

        public HastaGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        public string Tcno;
        private void HastaGuncelle_Load(object sender, EventArgs e)
        {
            msktc.Text = Tcno;
            baglan.Open();
            SqlCommand k1 = new SqlCommand("select*from tbl_hastalar where hastatc=@p1", baglan);
            k1.Parameters.AddWithValue("@p1", Tcno);
            SqlDataReader dr = k1.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktelefon.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();
            }
            baglan.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand k2 = new SqlCommand("update tbl_hastalar set hastaad=@a1,hastasoyad=@a2,hastatelefon=@a3,hastasifre=@a4 where Hastatc=@a5", baglan);
            k2.Parameters.AddWithValue("@a1",txtad.Text);
            k2.Parameters.AddWithValue("@a2",txtsoyad.Text);
            k2.Parameters.AddWithValue("@a3",msktelefon.Text.ToString());
            k2.Parameters.AddWithValue("@a4", txtsifre.Text.ToString());
            k2.Parameters.AddWithValue("@a5",msktc.Text.ToString());
            k2.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Kayıtlar Güncellendi!","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
} 
