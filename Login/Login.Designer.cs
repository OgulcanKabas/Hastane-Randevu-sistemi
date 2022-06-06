namespace Login
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_girisyap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_sifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_tc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_close);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(168, 433);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.ErrorImage = null;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.InitialImage = null;
            this.btn_close.Location = new System.Drawing.Point(12, 381);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(43, 40);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 5;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.comboBox1);
            this.bunifuGradientPanel4.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel4.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel4.Controls.Add(this.btn_girisyap);
            this.bunifuGradientPanel4.Controls.Add(this.txt_sifre);
            this.bunifuGradientPanel4.Controls.Add(this.txt_tc);
            this.bunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(168, 0);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(475, 433);
            this.bunifuGradientPanel4.TabIndex = 3;
            this.bunifuGradientPanel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel4_MouseDown);
            this.bunifuGradientPanel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel4_MouseMove);
            this.bunifuGradientPanel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel4_MouseUp);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Azure;
            this.comboBox1.Font = new System.Drawing.Font("Corbel", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 27);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Lütfen Seçiniz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(102, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.ActiveBorderThickness = 1;
            this.btn_girisyap.ActiveCornerRadius = 20;
            this.btn_girisyap.ActiveFillColor = System.Drawing.Color.Indigo;
            this.btn_girisyap.ActiveForecolor = System.Drawing.Color.White;
            this.btn_girisyap.ActiveLineColor = System.Drawing.Color.Indigo;
            this.btn_girisyap.BackColor = System.Drawing.SystemColors.Control;
            this.btn_girisyap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_girisyap.BackgroundImage")));
            this.btn_girisyap.ButtonText = "Giriş";
            this.btn_girisyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_girisyap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_girisyap.ForeColor = System.Drawing.Color.Black;
            this.btn_girisyap.IdleBorderThickness = 1;
            this.btn_girisyap.IdleCornerRadius = 20;
            this.btn_girisyap.IdleFillColor = System.Drawing.Color.White;
            this.btn_girisyap.IdleForecolor = System.Drawing.Color.Indigo;
            this.btn_girisyap.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_girisyap.Location = new System.Drawing.Point(146, 279);
            this.btn_girisyap.Margin = new System.Windows.Forms.Padding(5);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(183, 36);
            this.btn_girisyap.TabIndex = 4;
            this.btn_girisyap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.Color.Azure;
            this.txt_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifre.ForeColor = System.Drawing.Color.Black;
            this.txt_sifre.HintForeColor = System.Drawing.Color.Black;
            this.txt_sifre.HintText = "Şifre";
            this.txt_sifre.isPassword = false;
            this.txt_sifre.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_sifre.LineIdleColor = System.Drawing.Color.YellowGreen;
            this.txt_sifre.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_sifre.LineThickness = 3;
            this.txt_sifre.Location = new System.Drawing.Point(146, 200);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(183, 37);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_sifre.OnValueChanged += new System.EventHandler(this.txt_sifre_OnValueChanged);
            // 
            // txt_tc
            // 
            this.txt_tc.BackColor = System.Drawing.Color.Azure;
            this.txt_tc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tc.Font = new System.Drawing.Font("Corbel", 12F);
            this.txt_tc.ForeColor = System.Drawing.Color.Black;
            this.txt_tc.HintForeColor = System.Drawing.Color.Black;
            this.txt_tc.HintText = "TC";
            this.txt_tc.isPassword = false;
            this.txt_tc.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_tc.LineIdleColor = System.Drawing.Color.YellowGreen;
            this.txt_tc.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_tc.LineThickness = 3;
            this.txt_tc.Location = new System.Drawing.Point(146, 155);
            this.txt_tc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(183, 37);
            this.txt_tc.TabIndex = 0;
            this.txt_tc.Text = "TC/E-posta";
            this.txt_tc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 433);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_girisyap;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_sifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tc;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

