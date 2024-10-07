namespace HastahaneProjesi
{
    partial class FrmBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            button1 = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnguncelle = new Button();
            btnsil = new Button();
            btnekle = new Button();
            txtbransad = new TextBox();
            txtbransid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            button2 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Location = new Point(994, -67);
            button1.Name = "button1";
            button1.Size = new Size(124, 38);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(407, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(571, 418);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Branş Bilgileri";
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
            dataGridView1.Size = new Size(565, 383);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(176, -67);
            label1.Name = "label1";
            label1.Size = new Size(253, 41);
            label1.TabIndex = 4;
            label1.Text = "Doktor Paneli";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnekle);
            groupBox1.Controls.Add(txtbransad);
            groupBox1.Controls.Add(txtbransid);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 418);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Branş:";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.Lime;
            btnguncelle.Location = new Point(137, 296);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(135, 36);
            btnguncelle.TabIndex = 5;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.FromArgb(255, 224, 192);
            btnsil.Location = new Point(249, 212);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(135, 36);
            btnsil.TabIndex = 4;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.RoyalBlue;
            btnekle.ForeColor = Color.White;
            btnekle.Location = new Point(25, 212);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(135, 36);
            btnekle.TabIndex = 3;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // txtbransad
            // 
            txtbransad.Location = new Point(125, 104);
            txtbransad.Name = "txtbransad";
            txtbransad.Size = new Size(259, 36);
            txtbransad.TabIndex = 2;
            // 
            // txtbransid
            // 
            txtbransid.Location = new Point(125, 51);
            txtbransid.Name = "txtbransid";
            txtbransid.Size = new Size(259, 36);
            txtbransid.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 104);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 1;
            label3.Text = "Brans Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 54);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 0;
            label2.Text = "Brans Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Forte", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(357, 18);
            label4.Name = "label4";
            label4.Size = new Size(236, 32);
            label4.TabIndex = 2;
            label4.Text = "BRANŞ PANELİ";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.Location = new Point(853, 18);
            button2.Name = "button2";
            button2.Size = new Size(122, 38);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FrmBrans
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(982, 498);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBrans";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmBrans_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnguncelle;
        private Button btnsil;
        private Button btnekle;
        private TextBox txtbransad;
        private TextBox txtbransid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
    }
}