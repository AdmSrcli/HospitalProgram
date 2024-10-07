namespace HastahaneProjesi
{
    partial class FrmDoktorDetay
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            lbldoktoradsoyad = new Label();
            label2 = new Label();
            lbldoktortc = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rchsikayet = new RichTextBox();
            groupBox3 = new GroupBox();
            btncıkıs = new Button();
            btnduyurular = new Button();
            btnbilgiduzenle = new Button();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(lbldoktoradsoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbldoktortc);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi:";
            // 
            // lbldoktoradsoyad
            // 
            lbldoktoradsoyad.AutoSize = true;
            lbldoktoradsoyad.ForeColor = Color.Blue;
            lbldoktoradsoyad.Location = new Point(153, 119);
            lbldoktoradsoyad.Name = "lbldoktoradsoyad";
            lbldoktoradsoyad.Size = new Size(37, 28);
            lbldoktoradsoyad.TabIndex = 3;
            lbldoktoradsoyad.Text = "lbl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(6, 119);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 2;
            label2.Text = "Ad Soyad:";
            // 
            // lbldoktortc
            // 
            lbldoktortc.AutoSize = true;
            lbldoktortc.ForeColor = Color.Blue;
            lbldoktortc.Location = new Point(153, 50);
            lbldoktortc.Name = "lbldoktortc";
            lbldoktortc.Size = new Size(37, 28);
            lbldoktortc.TabIndex = 1;
            lbldoktortc.Text = "lbl";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "Doktor Tc:";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(rchsikayet);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(12, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 305);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hasta Şikayet:";
            // 
            // rchsikayet
            // 
            rchsikayet.Location = new Point(6, 50);
            rchsikayet.Name = "rchsikayet";
            rchsikayet.Size = new Size(361, 220);
            rchsikayet.TabIndex = 1;
            rchsikayet.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(btncıkıs);
            groupBox3.Controls.Add(btnduyurular);
            groupBox3.Controls.Add(btnbilgiduzenle);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(12, 518);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(373, 193);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hızlı Erişim:";
            // 
            // btncıkıs
            // 
            btncıkıs.BackColor = Color.FromArgb(255, 224, 192);
            btncıkıs.Location = new Point(90, 110);
            btncıkıs.Name = "btncıkıs";
            btncıkıs.Size = new Size(171, 46);
            btncıkıs.TabIndex = 2;
            btncıkıs.Text = "Çıkış";
            btncıkıs.UseVisualStyleBackColor = false;
            btncıkıs.Click += btncıkıs_Click;
            // 
            // btnduyurular
            // 
            btnduyurular.BackColor = Color.FromArgb(255, 224, 192);
            btnduyurular.Location = new Point(195, 35);
            btnduyurular.Name = "btnduyurular";
            btnduyurular.Size = new Size(158, 53);
            btnduyurular.TabIndex = 1;
            btnduyurular.Text = "Duyurular";
            btnduyurular.UseVisualStyleBackColor = false;
            btnduyurular.Click += btnduyurular_Click;
            // 
            // btnbilgiduzenle
            // 
            btnbilgiduzenle.BackColor = Color.FromArgb(255, 224, 192);
            btnbilgiduzenle.Location = new Point(6, 35);
            btnbilgiduzenle.Name = "btnbilgiduzenle";
            btnbilgiduzenle.Size = new Size(158, 53);
            btnbilgiduzenle.TabIndex = 0;
            btnbilgiduzenle.Text = "Bilgi Düzenle";
            btnbilgiduzenle.UseVisualStyleBackColor = false;
            btnbilgiduzenle.Click += btnbilgiduzenle_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(400, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1103, 699);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Randevular:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1097, 664);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1515, 728);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmDoktorDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Detay Paneli";
            Load += FrmDoktorDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbldoktoradsoyad;
        private Label label2;
        private Label lbldoktortc;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox rchsikayet;
        private GroupBox groupBox3;
        private Button btncıkıs;
        private Button btnduyurular;
        private Button btnbilgiduzenle;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}