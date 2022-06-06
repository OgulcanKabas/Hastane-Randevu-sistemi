namespace Login
{
    partial class Doktor_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor_ekle));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txt_sifre_dktr = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_poliklinikno = new System.Windows.Forms.ComboBox();
            this.cmb_bulkat = new System.Windows.Forms.ComboBox();
            this.cmb_poliklinikad = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.txt_soyad_doktor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_ad_doktor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_tc_doktor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txt_sifre_dktr);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_poliklinikno);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_bulkat);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_poliklinikad);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_sex);
            this.bunifuGradientPanel1.Controls.Add(this.txt_soyad_doktor);
            this.bunifuGradientPanel1.Controls.Add(this.txt_ad_doktor);
            this.bunifuGradientPanel1.Controls.Add(this.txt_tc_doktor);
            this.bunifuGradientPanel1.Controls.Add(this.btn_close);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(464, 541);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // txt_sifre_dktr
            // 
            this.txt_sifre_dktr.BackColor = System.Drawing.Color.Azure;
            this.txt_sifre_dktr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre_dktr.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_sifre_dktr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sifre_dktr.HintForeColor = System.Drawing.Color.Empty;
            this.txt_sifre_dktr.HintText = "Şifre";
            this.txt_sifre_dktr.isPassword = false;
            this.txt_sifre_dktr.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_sifre_dktr.LineIdleColor = System.Drawing.Color.YellowGreen;
            this.txt_sifre_dktr.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_sifre_dktr.LineThickness = 3;
            this.txt_sifre_dktr.Location = new System.Drawing.Point(145, 218);
            this.txt_sifre_dktr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre_dktr.Name = "txt_sifre_dktr";
            this.txt_sifre_dktr.Size = new System.Drawing.Size(172, 33);
            this.txt_sifre_dktr.TabIndex = 22;
            this.txt_sifre_dktr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_sifre_dktr.OnValueChanged += new System.EventHandler(this.txt_sifre_dktr_OnValueChanged);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Crimson;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(147, 465);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(44, 45);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 20;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(203, 465);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(114, 45);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 19;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(140, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(179, 31);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Doktor Ekle";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // cmb_poliklinikno
            // 
            this.cmb_poliklinikno.BackColor = System.Drawing.Color.Azure;
            this.cmb_poliklinikno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_poliklinikno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_poliklinikno.FormattingEnabled = true;
            this.cmb_poliklinikno.Location = new System.Drawing.Point(145, 434);
            this.cmb_poliklinikno.Name = "cmb_poliklinikno";
            this.cmb_poliklinikno.Size = new System.Drawing.Size(172, 25);
            this.cmb_poliklinikno.TabIndex = 17;
            this.cmb_poliklinikno.Text = "Poliklinik No";
            this.cmb_poliklinikno.SelectedIndexChanged += new System.EventHandler(this.cmb_poliklinikno_SelectedIndexChanged);
            // 
            // cmb_bulkat
            // 
            this.cmb_bulkat.BackColor = System.Drawing.Color.Azure;
            this.cmb_bulkat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_bulkat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_bulkat.FormattingEnabled = true;
            this.cmb_bulkat.Location = new System.Drawing.Point(145, 372);
            this.cmb_bulkat.Name = "cmb_bulkat";
            this.cmb_bulkat.Size = new System.Drawing.Size(172, 25);
            this.cmb_bulkat.TabIndex = 16;
            this.cmb_bulkat.Text = "Bulunduğu Kat";
            this.cmb_bulkat.SelectedIndexChanged += new System.EventHandler(this.cmb_bulkat_SelectedIndexChanged);
            // 
            // cmb_poliklinikad
            // 
            this.cmb_poliklinikad.BackColor = System.Drawing.Color.Azure;
            this.cmb_poliklinikad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_poliklinikad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_poliklinikad.FormattingEnabled = true;
            this.cmb_poliklinikad.Location = new System.Drawing.Point(145, 403);
            this.cmb_poliklinikad.Name = "cmb_poliklinikad";
            this.cmb_poliklinikad.Size = new System.Drawing.Size(172, 25);
            this.cmb_poliklinikad.TabIndex = 15;
            this.cmb_poliklinikad.Text = "Poliklinik Adı";
            this.cmb_poliklinikad.SelectedIndexChanged += new System.EventHandler(this.cmb_poliklinikad_SelectedIndexChanged);
            this.cmb_poliklinikad.TextChanged += new System.EventHandler(this.cmb_poliklinikad_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Login.Properties.Resources.img_yükle;
            this.pictureBox1.Location = new System.Drawing.Point(145, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 124);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmb_sex
            // 
            this.cmb_sex.BackColor = System.Drawing.Color.Azure;
            this.cmb_sex.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Location = new System.Drawing.Point(145, 341);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(172, 25);
            this.cmb_sex.TabIndex = 13;
            this.cmb_sex.Text = "Cinsiyet";
            // 
            // txt_soyad_doktor
            // 
            this.txt_soyad_doktor.BackColor = System.Drawing.Color.Azure;
            this.txt_soyad_doktor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soyad_doktor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_soyad_doktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_soyad_doktor.HintForeColor = System.Drawing.Color.Empty;
            this.txt_soyad_doktor.HintText = "Soyad";
            this.txt_soyad_doktor.isPassword = false;
            this.txt_soyad_doktor.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_soyad_doktor.LineIdleColor = System.Drawing.Color.YellowGreen;
            this.txt_soyad_doktor.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_soyad_doktor.LineThickness = 3;
            this.txt_soyad_doktor.Location = new System.Drawing.Point(145, 300);
            this.txt_soyad_doktor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soyad_doktor.Name = "txt_soyad_doktor";
            this.txt_soyad_doktor.Size = new System.Drawing.Size(172, 33);
            this.txt_soyad_doktor.TabIndex = 12;
            this.txt_soyad_doktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_soyad_doktor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soyad_doktor_KeyPress);
            // 
            // txt_ad_doktor
            // 
            this.txt_ad_doktor.BackColor = System.Drawing.Color.Azure;
            this.txt_ad_doktor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ad_doktor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ad_doktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ad_doktor.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ad_doktor.HintText = "Ad";
            this.txt_ad_doktor.isPassword = false;
            this.txt_ad_doktor.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_ad_doktor.LineIdleColor = System.Drawing.Color.YellowGreen;
            this.txt_ad_doktor.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_ad_doktor.LineThickness = 3;
            this.txt_ad_doktor.Location = new System.Drawing.Point(145, 259);
            this.txt_ad_doktor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ad_doktor.Name = "txt_ad_doktor";
            this.txt_ad_doktor.Size = new System.Drawing.Size(172, 33);
            this.txt_ad_doktor.TabIndex = 11;
            this.txt_ad_doktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ad_doktor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ad_doktor_KeyPress);
            // 
            // txt_tc_doktor
            // 
            this.txt_tc_doktor.BackColor = System.Drawing.Color.Azure;
            this.txt_tc_doktor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tc_doktor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_tc_doktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tc_doktor.HintForeColor = System.Drawing.Color.Empty;
            this.txt_tc_doktor.HintText = "TC";
            this.txt_tc_doktor.isPassword = false;
            this.txt_tc_doktor.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_tc_doktor.LineIdleColor = System.Drawing.Color.YellowGreen;
            this.txt_tc_doktor.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_tc_doktor.LineThickness = 3;
            this.txt_tc_doktor.Location = new System.Drawing.Point(145, 177);
            this.txt_tc_doktor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tc_doktor.Name = "txt_tc_doktor";
            this.txt_tc_doktor.Size = new System.Drawing.Size(172, 33);
            this.txt_tc_doktor.TabIndex = 10;
            this.txt_tc_doktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tc_doktor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tc_doktor_KeyPress);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.ErrorImage = null;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.InitialImage = null;
            this.btn_close.Location = new System.Drawing.Point(421, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 29);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 9;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Doktor_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 541);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Doktor_ekle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doktor_ekle";
            this.Load += new System.EventHandler(this.Doktor_ekle_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cmb_poliklinikno;
        private System.Windows.Forms.ComboBox cmb_bulkat;
        private System.Windows.Forms.ComboBox cmb_poliklinikad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_sex;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_soyad_doktor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ad_doktor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tc_doktor;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_sifre_dktr;
    }
}