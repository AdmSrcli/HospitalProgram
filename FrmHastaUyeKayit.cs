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
    public partial class FrmHastaUyeKayit : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        public FrmHastaUyeKayit()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)

        {
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("insert into tbl_hastalar (hastaad,hastasoyad,hastatc,hastatelefon,hastasifre,hastacinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglan);
            komut1.Parameters.AddWithValue("@p1",txtad.Text);
            komut1.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut1.Parameters.AddWithValue("@p3", msktc.Text);
            komut1.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut1.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut1.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
            komut1.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Kayıt Başarılı Şekilde Oluşturuldu!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
