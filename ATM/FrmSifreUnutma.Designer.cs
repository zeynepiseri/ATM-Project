namespace ATM
{
    partial class FrmSifreUnutma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifreUnutma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnTelefon = new System.Windows.Forms.Button();
            this.BtnInternet = new System.Windows.Forms.Button();
            this.BtnMobil = new System.Windows.Forms.Button();
            this.LblTel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblInternet = new System.Windows.Forms.Label();
            this.LblMobil1 = new System.Windows.Forms.Label();
            this.LblMobil2 = new System.Windows.Forms.Label();
            this.BtnAtm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(198, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre Güncelleme İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(152, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÜVEN BANKASI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre Değişikliği için Yapmak İstediğiniz İşlemi Seçin";
            // 
            // BtnTelefon
            // 
            this.BtnTelefon.BackColor = System.Drawing.Color.Silver;
            this.BtnTelefon.Location = new System.Drawing.Point(98, 322);
            this.BtnTelefon.Name = "BtnTelefon";
            this.BtnTelefon.Size = new System.Drawing.Size(393, 46);
            this.BtnTelefon.TabIndex = 3;
            this.BtnTelefon.Text = "Telefon Bankacılığı";
            this.BtnTelefon.UseVisualStyleBackColor = false;
            this.BtnTelefon.Click += new System.EventHandler(this.BtnTelefon_Click);
            // 
            // BtnInternet
            // 
            this.BtnInternet.BackColor = System.Drawing.Color.Silver;
            this.BtnInternet.Location = new System.Drawing.Point(98, 422);
            this.BtnInternet.Name = "BtnInternet";
            this.BtnInternet.Size = new System.Drawing.Size(393, 46);
            this.BtnInternet.TabIndex = 4;
            this.BtnInternet.Text = "İnternet Bankacılığı";
            this.BtnInternet.UseVisualStyleBackColor = false;
            this.BtnInternet.Click += new System.EventHandler(this.BtnInternet_Click);
            // 
            // BtnMobil
            // 
            this.BtnMobil.BackColor = System.Drawing.Color.Silver;
            this.BtnMobil.Location = new System.Drawing.Point(98, 527);
            this.BtnMobil.Name = "BtnMobil";
            this.BtnMobil.Size = new System.Drawing.Size(393, 46);
            this.BtnMobil.TabIndex = 5;
            this.BtnMobil.Text = "Mobil Bankacılık";
            this.BtnMobil.UseVisualStyleBackColor = false;
            this.BtnMobil.Click += new System.EventHandler(this.BtnMobil_Click);
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(172, 381);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(248, 26);
            this.LblTel.TabIndex = 8;
            this.LblTel.Text = "Telefon: 0224 333 3333";
            this.LblTel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(348, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 26);
            this.label6.TabIndex = 6;
            this.label6.Visible = false;
            // 
            // LblInternet
            // 
            this.LblInternet.AutoSize = true;
            this.LblInternet.Location = new System.Drawing.Point(166, 482);
            this.LblInternet.Name = "LblInternet";
            this.LblInternet.Size = new System.Drawing.Size(267, 26);
            this.LblInternet.TabIndex = 9;
            this.LblInternet.Text = "www.guvenbank.com.tr";
            this.LblInternet.Visible = false;
            // 
            // LblMobil1
            // 
            this.LblMobil1.AutoSize = true;
            this.LblMobil1.Location = new System.Drawing.Point(104, 586);
            this.LblMobil1.Name = "LblMobil1";
            this.LblMobil1.Size = new System.Drawing.Size(387, 26);
            this.LblMobil1.TabIndex = 10;
            this.LblMobil1.Text = "Güven Bankası Mobil / Google Play";
            this.LblMobil1.Visible = false;
            // 
            // LblMobil2
            // 
            this.LblMobil2.AutoSize = true;
            this.LblMobil2.Location = new System.Drawing.Point(348, 612);
            this.LblMobil2.Name = "LblMobil2";
            this.LblMobil2.Size = new System.Drawing.Size(117, 26);
            this.LblMobil2.TabIndex = 11;
            this.LblMobil2.Text = "App Store";
            this.LblMobil2.Visible = false;
            // 
            // BtnAtm
            // 
            this.BtnAtm.BackColor = System.Drawing.Color.Silver;
            this.BtnAtm.Location = new System.Drawing.Point(98, 228);
            this.BtnAtm.Name = "BtnAtm";
            this.BtnAtm.Size = new System.Drawing.Size(393, 46);
            this.BtnAtm.TabIndex = 12;
            this.BtnAtm.Text = "ATM ile Değiştir";
            this.BtnAtm.UseVisualStyleBackColor = false;
            this.BtnAtm.Click += new System.EventHandler(this.BtnAtm_Click);
            // 
            // FrmSifreUnutma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(578, 667);
            this.Controls.Add(this.BtnAtm);
            this.Controls.Add(this.LblMobil2);
            this.Controls.Add(this.LblMobil1);
            this.Controls.Add(this.LblInternet);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnMobil);
            this.Controls.Add(this.BtnInternet);
            this.Controls.Add(this.BtnTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSifreUnutma";
            this.Text = "FrmSifreUnutma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTelefon;
        private System.Windows.Forms.Button BtnInternet;
        private System.Windows.Forms.Button BtnMobil;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblInternet;
        private System.Windows.Forms.Label LblMobil1;
        private System.Windows.Forms.Label LblMobil2;
        private System.Windows.Forms.Button BtnAtm;
    }
}