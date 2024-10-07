namespace HastahaneProjesi
{
    partial class FrmHastaDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            groupBox1 = new GroupBox();
            lbladsoyad = new Label();
            lbltc = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtrandevuid = new TextBox();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            btnrandevual = new Button();
            rchsikayet = new RichTextBox();
            cmbdoktor = new ComboBox();
            cmbbrans = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbladsoyad);
            groupBox1.Controls.Add(lbltc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(24, 17);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(611, 295);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgi:";
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Location = new Point(195, 172);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(72, 28);
            lbladsoyad.TabIndex = 3;
            lbladsoyad.Text = "label7";
            // 
            // lbltc
            // 
            lbltc.AutoSize = true;
            lbltc.Location = new Point(193, 87);
            lbltc.Name = "lbltc";
            lbltc.Size = new Size(74, 28);
            lbltc.TabIndex = 2;
            lbltc.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 172);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 1;
            label5.Text = "Ad Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 87);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 0;
            label4.Text = "Hasta Tc:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtrandevuid);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(linkLabel1);
            groupBox2.Controls.Add(btnrandevual);
            groupBox2.Controls.Add(rchsikayet);
            groupBox2.Controls.Add(cmbdoktor);
            groupBox2.Controls.Add(cmbbrans);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(24, 330);
            groupBox2.Margin = new Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 4, 5, 4);
            groupBox2.Size = new Size(611, 570);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Paneli:";
            // 
            // txtrandevuid
            // 
            txtrandevuid.Location = new Point(226, 51);
            txtrandevuid.Name = "txtrandevuid";
            txtrandevuid.Size = new Size(354, 36);
            txtrandevuid.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 59);
            label6.Name = "label6";
            label6.Size = new Size(131, 28);
            label6.TabIndex = 8;
            label6.Text = "Randevu Id:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BorderStyle = BorderStyle.FixedSingle;
            linkLabel1.Location = new Point(6, 495);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(189, 30);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bilgileri Güncelle:";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnrandevual
            // 
            btnrandevual.BackColor = Color.FromArgb(255, 224, 192);
            btnrandevual.Location = new Point(291, 476);
            btnrandevual.Name = "btnrandevual";
            btnrandevual.Size = new Size(211, 49);
            btnrandevual.TabIndex = 5;
            btnrandevual.Text = "Randevu Al";
            btnrandevual.UseVisualStyleBackColor = false;
            btnrandevual.Click += btnrandevual_Click;
            // 
            // rchsikayet
            // 
            rchsikayet.Location = new Point(230, 247);
            rchsikayet.Name = "rchsikayet";
            rchsikayet.Size = new Size(350, 215);
            rchsikayet.TabIndex = 4;
            rchsikayet.Text = "";
            // 
            // cmbdoktor
            // 
            cmbdoktor.FormattingEnabled = true;
            cmbdoktor.Location = new Point(226, 182);
            cmbdoktor.Name = "cmbdoktor";
            cmbdoktor.Size = new Size(354, 36);
            cmbdoktor.TabIndex = 3;
            cmbdoktor.SelectedIndexChanged += cmbdoktor_SelectedIndexChanged;
            // 
            // cmbbrans
            // 
            cmbbrans.FormattingEnabled = true;
            cmbbrans.Location = new Point(226, 111);
            cmbbrans.Name = "cmbbrans";
            cmbbrans.Size = new Size(354, 36);
            cmbbrans.TabIndex = 2;
            cmbbrans.SelectedIndexChanged += cmbbrans_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 249);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 2;
            label3.Text = "Hasta Şikayet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 190);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 1;
            label2.Text = "Doktor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 119);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 0;
            label1.Text = "Branş:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(653, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1259, 434);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aktif Randevular:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1253, 399);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(653, 457);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1256, 443);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Randevu Geçmişi:";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 32);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1250, 408);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1916, 906);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmHastaDetay";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmHastaDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbladsoyad;
        private Label lbltc;
        private Label label5;
        private Label label4;
        private RichTextBox rchsikayet;
        private ComboBox cmbdoktor;
        private ComboBox cmbbrans;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private LinkLabel linkLabel1;
        private Button btnrandevual;
        private TextBox txtrandevuid;
        private Label label6;
    }
}