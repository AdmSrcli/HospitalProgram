namespace HastahaneProjesi
{
    partial class FrmDoktorPaneli
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            groupBox1 = new GroupBox();
            btnguncelle = new Button();
            btnsil = new Button();
            btnekle = new Button();
            cmbbrans = new ComboBox();
            msktc = new MaskedTextBox();
            txtsifre = new TextBox();
            txtsoyad = new TextBox();
            txtad = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnekle);
            groupBox1.Controls.Add(cmbbrans);
            groupBox1.Controls.Add(msktc);
            groupBox1.Controls.Add(txtsifre);
            groupBox1.Controls.Add(txtsoyad);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 418);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi:";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.Lime;
            btnguncelle.Location = new Point(167, 373);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(135, 36);
            btnguncelle.TabIndex = 8;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.FromArgb(255, 224, 192);
            btnsil.Location = new Point(244, 331);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(135, 36);
            btnsil.TabIndex = 7;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.RoyalBlue;
            btnekle.ForeColor = Color.White;
            btnekle.Location = new Point(103, 331);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(135, 36);
            btnekle.TabIndex = 6;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // cmbbrans
            // 
            cmbbrans.FormattingEnabled = true;
            cmbbrans.Location = new Point(102, 158);
            cmbbrans.Name = "cmbbrans";
            cmbbrans.Size = new Size(282, 36);
            cmbbrans.TabIndex = 3;
            // 
            // msktc
            // 
            msktc.Location = new Point(102, 213);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(282, 36);
            msktc.TabIndex = 4;
            msktc.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(102, 270);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(282, 36);
            txtsifre.TabIndex = 5;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(102, 104);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(282, 36);
            txtsoyad.TabIndex = 2;
            // 
            // txtad
            // 
            txtad.Location = new Point(102, 51);
            txtad.Name = "txtad";
            txtad.Size = new Size(282, 36);
            txtad.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 278);
            label6.Name = "label6";
            label6.Size = new Size(66, 28);
            label6.TabIndex = 4;
            label6.Text = "Şİfre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 221);
            label5.Name = "label5";
            label5.Size = new Size(44, 28);
            label5.TabIndex = 3;
            label5.Text = "TC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 2;
            label4.Text = "Branş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 112);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 1;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 59);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 0;
            label2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(407, 19);
            label1.Name = "label1";
            label1.Size = new Size(253, 41);
            label1.TabIndex = 1;
            label1.Text = "Doktor Paneli";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(404, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(947, 418);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Doktor  Bilgileri";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Corbel", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 383);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Location = new Point(1225, 19);
            button1.Name = "button1";
            button1.Size = new Size(124, 38);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmDoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1355, 504);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDoktorPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmDoktorPaneli_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox msktc;
        private TextBox txtsifre;
        private TextBox txtsoyad;
        private TextBox txtad;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnguncelle;
        private Button btnsil;
        private Button btnekle;
        private ComboBox cmbbrans;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}