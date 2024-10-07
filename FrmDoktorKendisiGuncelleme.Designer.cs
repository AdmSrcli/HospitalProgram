namespace HastahaneProjesi
{
    partial class FrmDoktorKendisiGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorKendisiGuncelleme));
            groupBox1 = new GroupBox();
            btnguncelle = new Button();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnguncelle);
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
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 399);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi:";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.Lime;
            btnguncelle.Location = new Point(157, 340);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(135, 36);
            btnguncelle.TabIndex = 8;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
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
            // FrmDoktorKendisiGuncelleme
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(404, 424);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDoktorKendisiGuncelleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Bilgi Güncelleme";
            Load += FrmDoktorKendisiGuncelleme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnguncelle;
        private ComboBox cmbbrans;
        private MaskedTextBox msktc;
        private TextBox txtsifre;
        private TextBox txtsoyad;
        private TextBox txtad;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}