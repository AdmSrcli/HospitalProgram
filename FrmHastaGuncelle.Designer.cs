namespace HastahaneProjesi
{
    partial class HastaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGuncelle));
            cmbcinsiyet = new ComboBox();
            btnguncelle = new Button();
            msktelefon = new MaskedTextBox();
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
            label7 = new Label();
            SuspendLayout();
            // 
            // cmbcinsiyet
            // 
            cmbcinsiyet.FormattingEnabled = true;
            cmbcinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbcinsiyet.Location = new Point(227, 380);
            cmbcinsiyet.Name = "cmbcinsiyet";
            cmbcinsiyet.Size = new Size(276, 36);
            cmbcinsiyet.TabIndex = 6;
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.FromArgb(255, 224, 192);
            btnguncelle.Location = new Point(292, 438);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(136, 48);
            btnguncelle.TabIndex = 7;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // msktelefon
            // 
            msktelefon.Location = new Point(227, 267);
            msktelefon.Mask = "(999) 000-0000";
            msktelefon.Name = "msktelefon";
            msktelefon.Size = new Size(276, 36);
            msktelefon.TabIndex = 4;
            // 
            // msktc
            // 
            msktc.Location = new Point(227, 208);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(276, 36);
            msktc.TabIndex = 3;
            msktc.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(227, 322);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(276, 36);
            txtsifre.TabIndex = 5;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(227, 153);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(276, 36);
            txtsoyad.TabIndex = 2;
            // 
            // txtad
            // 
            txtad.Location = new Point(227, 90);
            txtad.Name = "txtad";
            txtad.Size = new Size(276, 36);
            txtad.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 388);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 19;
            label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 330);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 18;
            label5.Text = "Şİfre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 275);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 17;
            label4.Text = "Telefon No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 211);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 16;
            label3.Text = "TC No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 153);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 15;
            label2.Text = "Hasta Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 94);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 14;
            label1.Text = "Hasta Ad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(83, 24);
            label7.Name = "label7";
            label7.Size = new Size(336, 37);
            label7.TabIndex = 27;
            label7.Text = "Hasta Güncelleme Paneli";
            // 
            // HastaGuncelle
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(537, 510);
            Controls.Add(label7);
            Controls.Add(cmbcinsiyet);
            Controls.Add(btnguncelle);
            Controls.Add(msktelefon);
            Controls.Add(msktc);
            Controls.Add(txtsifre);
            Controls.Add(txtsoyad);
            Controls.Add(txtad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HastaGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Load += HastaGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbcinsiyet;
        private Button btnguncelle;
        private MaskedTextBox msktelefon;
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
        private Label label7;
    }
}