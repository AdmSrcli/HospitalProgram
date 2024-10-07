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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da=  new SqlDataAdapter("Select*from tbl_randevular order by RandevuId desc",baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
            
        }
    }
}
