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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        private void btngiris_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand k1 = new SqlCommand("select*from tbl_doktorlar where doktortc=@p1 and doktorsifre=@p2", baglan);
            k1.Parameters.AddWithValue("@p1",msktc.Text.ToString());
            k1.Parameters.AddWithValue("@p2",txtsifre.Text.ToString());
            SqlDataReader dr1= k1.ExecuteReader();
            if (dr1.Read())
            {
                FrmDoktorDetay frdt = new FrmDoktorDetay();
                frdt.doktc=msktc.Text;
                frdt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Tc yada Şifre Kontrol Ediniz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglan.Close();
        }
    }
}
