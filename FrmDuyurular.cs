﻿using System;
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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=HastaneProje;Integrated Security=True");
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select*from tbl_duyurular",baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }
    }
}
