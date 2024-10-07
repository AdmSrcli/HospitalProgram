namespace HastahaneProjesi
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            label3 = new Label();
            btngiris = new Button();
            txtsifre = new TextBox();
            msktc = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Forte", 18F, FontStyle.Bold);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(119, 18);
            label3.Name = "label3";
            label3.Size = new Size(279, 32);
            label3.TabIndex = 17;
            label3.Text = "Doktor Giriş Paneli";
            // 
            // btngiris
            // 
            btngiris.BackColor = Color.FromArgb(255, 224, 192);
            btngiris.Location = new Point(254, 230);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(158, 44);
            btngiris.TabIndex = 16;
            btngiris.Text = "GİRİŞ";
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(192, 170);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(274, 36);
            txtsifre.TabIndex = 13;
            txtsifre.Text = "9999";
            // 
            // msktc
            // 
            msktc.Location = new Point(192, 94);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(274, 36);
            msktc.TabIndex = 12;
            msktc.Text = "44444444444";
            msktc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 173);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 15;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 97);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 14;
            label1.Text = "Doktor TC:";
            // 
            // FrmDoktorGiris
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(516, 298);
            Controls.Add(label3);
            Controls.Add(btngiris);
            Controls.Add(txtsifre);
            Controls.Add(msktc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDoktorGiris";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btngiris;
        private TextBox txtsifre;
        private MaskedTextBox msktc;
        private Label label2;
        private Label label1;
    }
}