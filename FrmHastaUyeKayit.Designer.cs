namespace HastahaneProjesi
{
    partial class FrmHastaUyeKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaUyeKayit));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtad = new TextBox();
            txtsoyad = new TextBox();
            txtsifre = new TextBox();
            msktc = new MaskedTextBox();
            msktelefon = new MaskedTextBox();
            btnkaydet = new Button();
            cmbcinsiyet = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 83);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "Hasta Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 142);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 1;
            label2.Text = "Hasta Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 200);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 2;
            label3.Text = "TC No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 264);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 3;
            label4.Text = "Telefon No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 319);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 4;
            label5.Text = "Şİfre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 377);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 5;
            label6.Text = "Cinsiyet:";
            // 
            // txtad
            // 
            txtad.Location = new Point(241, 79);
            txtad.Name = "txtad";
            txtad.Size = new Size(276, 36);
            txtad.TabIndex = 1;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(241, 142);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(276, 36);
            txtsoyad.TabIndex = 2;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(241, 311);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(276, 36);
            txtsifre.TabIndex = 5;
            // 
            // msktc
            // 
            msktc.Location = new Point(241, 197);
            msktc.Name = "msktc";
            msktc.Size = new Size(276, 36);
            msktc.TabIndex = 3;
            msktc.ValidatingType = typeof(int);
            // 
            // msktelefon
            // 
            msktelefon.Location = new Point(241, 256);
            msktelefon.Mask = "(999) 000-0000";
            msktelefon.Name = "msktelefon";
            msktelefon.Size = new Size(276, 36);
            msktelefon.TabIndex = 4;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.FromArgb(255, 224, 192);
            btnkaydet.Location = new Point(263, 437);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(227, 48);
            btnkaydet.TabIndex = 7;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // cmbcinsiyet
            // 
            cmbcinsiyet.FormattingEnabled = true;
            cmbcinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbcinsiyet.Location = new Point(241, 369);
            cmbcinsiyet.Name = "cmbcinsiyet";
            cmbcinsiyet.Size = new Size(276, 36);
            cmbcinsiyet.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(138, 18);
            label7.Name = "label7";
            label7.Size = new Size(251, 37);
            label7.TabIndex = 14;
            label7.Text = "Hasta Kayıt Paneli";
            // 
            // FrmHastaUyeKayit
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(576, 495);
            Controls.Add(label7);
            Controls.Add(cmbcinsiyet);
            Controls.Add(btnkaydet);
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
            Name = "FrmHastaUyeKayit";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtad;
        private TextBox txtsoyad;
        private TextBox txtsifre;
        private TextBox textBox4;
        private MaskedTextBox msktc;
        private MaskedTextBox msktelefon;
        private Button btnkaydet;
        private ComboBox cmbcinsiyet;
        private Label label7;
    }
}