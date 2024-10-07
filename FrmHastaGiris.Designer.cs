namespace HastahaneProjesi
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            label1 = new Label();
            label2 = new Label();
            msktc = new MaskedTextBox();
            txtsifre = new TextBox();
            btngiris = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 114);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Hasta TC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 194);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // msktc
            // 
            msktc.Location = new Point(238, 115);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(274, 36);
            msktc.TabIndex = 1;
            msktc.Text = "11223344556";
            msktc.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(238, 191);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(274, 36);
            txtsifre.TabIndex = 2;
            txtsifre.Text = "112233";
            // 
            // btngiris
            // 
            btngiris.Location = new Point(354, 271);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(158, 44);
            btngiris.TabIndex = 3;
            btngiris.Text = "GİRİŞ";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += btngiris_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BorderStyle = BorderStyle.FixedSingle;
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Location = new Point(537, 195);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(81, 30);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Üye Ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Forte", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(216, 33);
            label3.Name = "label3";
            label3.Size = new Size(271, 32);
            label3.TabIndex = 5;
            label3.Text = "Hasta Giriş Paneli";
            // 
            // FrmHastaGiris
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(661, 343);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
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
            Name = "FrmHastaGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmHastaGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox msktc;
        private TextBox txtsifre;
        private Button btngiris;
        private LinkLabel linkLabel1;
        private Label label3;
    }
}