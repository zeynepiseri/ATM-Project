namespace ATM
{
    partial class FrmBakSifre4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBakSifre4));
            this.BtnGiris = new System.Windows.Forms.Button();
            this.MskYeniSifre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.PnlPc4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlPc4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.Navy;
            this.BtnGiris.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGiris.Location = new System.Drawing.Point(324, 420);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(192, 55);
            this.BtnGiris.TabIndex = 45;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // MskYeniSifre
            // 
            this.MskYeniSifre.Location = new System.Drawing.Point(372, 335);
            this.MskYeniSifre.Mask = "0000";
            this.MskYeniSifre.Name = "MskYeniSifre";
            this.MskYeniSifre.Size = new System.Drawing.Size(81, 45);
            this.MskYeniSifre.TabIndex = 44;
            this.MskYeniSifre.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(80, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(682, 88);
            this.label2.TabIndex = 43;
            this.label2.Text = "YENİ ŞİFRENİZİ GİRDİKTEN SONRA GİRİŞ                    BUTONUNA BASINIZ\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 100);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(200, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÜVEN BANKASI";
            // 
            // lblid
            // 
            this.lblid.ForeColor = System.Drawing.Color.Crimson;
            this.lblid.Location = new System.Drawing.Point(12, 106);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 44);
            this.lblid.TabIndex = 46;
            this.lblid.Text = "-";
            this.lblid.Visible = false;
            // 
            // PnlPc4
            // 
            this.PnlPc4.BackColor = System.Drawing.Color.Navy;
            this.PnlPc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPc4.Controls.Add(this.pictureBox5);
            this.PnlPc4.Controls.Add(this.label5);
            this.PnlPc4.Location = new System.Drawing.Point(2, 531);
            this.PnlPc4.Name = "PnlPc4";
            this.PnlPc4.Size = new System.Drawing.Size(303, 83);
            this.PnlPc4.TabIndex = 49;
            this.PnlPc4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlPc4_MouseClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(24, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(112, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 47);
            this.label5.TabIndex = 11;
            this.label5.Text = "İPTAL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmBakSifre4
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(829, 615);
            this.Controls.Add(this.PnlPc4);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.MskYeniSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "FrmBakSifre4";
            this.Text = "FrmBakSifre4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlPc4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.MaskedTextBox MskYeniSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel PnlPc4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
    }
}