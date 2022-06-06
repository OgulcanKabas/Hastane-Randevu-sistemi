namespace Login
{
    partial class doktor_paneli_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktor_paneli_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.d_minifoto = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_logout = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_kisisel_ayarlar = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_mailgonder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_rndv_durum = new System.Windows.Forms.ComboBox();
            this.btn_randevu_oonay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.main_r_liste_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_ustkisim = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_zamann = new System.Windows.Forms.Label();
            this.lbl_girisyapan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_tablo_icin = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.d_minifoto)).BeginInit();
            this.pnl_logout.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_r_liste_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.panel_ustkisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this.d_minifoto;
            // 
            // d_minifoto
            // 
            this.d_minifoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d_minifoto.Location = new System.Drawing.Point(929, 3);
            this.d_minifoto.Name = "d_minifoto";
            this.d_minifoto.Size = new System.Drawing.Size(62, 60);
            this.d_minifoto.TabIndex = 0;
            this.d_minifoto.TabStop = false;
            this.d_minifoto.Click += new System.EventHandler(this.d_minifoto_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this.pnl_logout;
            // 
            // pnl_logout
            // 
            this.pnl_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_logout.BackgroundImage")));
            this.pnl_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_logout.Controls.Add(this.label2);
            this.pnl_logout.Controls.Add(this.lbl_kisisel_ayarlar);
            this.pnl_logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_logout.GradientBottomLeft = System.Drawing.Color.White;
            this.pnl_logout.GradientBottomRight = System.Drawing.Color.White;
            this.pnl_logout.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.pnl_logout.GradientTopRight = System.Drawing.Color.YellowGreen;
            this.pnl_logout.Location = new System.Drawing.Point(901, 80);
            this.pnl_logout.Name = "pnl_logout";
            this.pnl_logout.Quality = 10;
            this.pnl_logout.Size = new System.Drawing.Size(91, 69);
            this.pnl_logout.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çıkış Yap";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_kisisel_ayarlar
            // 
            this.lbl_kisisel_ayarlar.AutoSize = true;
            this.lbl_kisisel_ayarlar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kisisel_ayarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_kisisel_ayarlar.ForeColor = System.Drawing.Color.Black;
            this.lbl_kisisel_ayarlar.Location = new System.Drawing.Point(1, 12);
            this.lbl_kisisel_ayarlar.Name = "lbl_kisisel_ayarlar";
            this.lbl_kisisel_ayarlar.Size = new System.Drawing.Size(71, 13);
            this.lbl_kisisel_ayarlar.TabIndex = 0;
            this.lbl_kisisel_ayarlar.Text = "Kişisel Ayarlar";
            this.lbl_kisisel_ayarlar.Click += new System.EventHandler(this.lbl_kisisel_ayarlar_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dateTimePicker1);
            this.bunifuGradientPanel1.Controls.Add(this.btn_mailgonder);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_rndv_durum);
            this.bunifuGradientPanel1.Controls.Add(this.btn_randevu_oonay);
            this.bunifuGradientPanel1.Controls.Add(this.main_r_liste_datagrid);
            this.bunifuGradientPanel1.Controls.Add(this.btn_close);
            this.bunifuGradientPanel1.Controls.Add(this.pnl_logout);
            this.bunifuGradientPanel1.Controls.Add(this.panel_ustkisim);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.GreenYellow;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1003, 606);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 27);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_mailgonder
            // 
            this.btn_mailgonder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_mailgonder.BackColor = System.Drawing.Color.Transparent;
            this.btn_mailgonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mailgonder.BorderRadius = 0;
            this.btn_mailgonder.ButtonText = "Mail Gönder";
            this.btn_mailgonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mailgonder.DisabledColor = System.Drawing.Color.Gray;
            this.btn_mailgonder.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_mailgonder.Iconimage = global::Login.Properties.Resources.Mail_03;
            this.btn_mailgonder.Iconimage_right = null;
            this.btn_mailgonder.Iconimage_right_Selected = null;
            this.btn_mailgonder.Iconimage_Selected = null;
            this.btn_mailgonder.IconMarginLeft = 0;
            this.btn_mailgonder.IconMarginRight = 0;
            this.btn_mailgonder.IconRightVisible = true;
            this.btn_mailgonder.IconRightZoom = 0D;
            this.btn_mailgonder.IconVisible = true;
            this.btn_mailgonder.IconZoom = 120D;
            this.btn_mailgonder.IsTab = false;
            this.btn_mailgonder.Location = new System.Drawing.Point(746, 114);
            this.btn_mailgonder.Name = "btn_mailgonder";
            this.btn_mailgonder.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_mailgonder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_mailgonder.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_mailgonder.selected = false;
            this.btn_mailgonder.Size = new System.Drawing.Size(149, 35);
            this.btn_mailgonder.TabIndex = 3;
            this.btn_mailgonder.Text = "Mail Gönder";
            this.btn_mailgonder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mailgonder.Textcolor = System.Drawing.Color.Black;
            this.btn_mailgonder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mailgonder.Click += new System.EventHandler(this.btn_mailgonder_Click);
            // 
            // cmb_rndv_durum
            // 
            this.cmb_rndv_durum.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmb_rndv_durum.FormattingEnabled = true;
            this.cmb_rndv_durum.Items.AddRange(new object[] {
            "Tamamlanan Randevular",
            "Bekleyen Randevular"});
            this.cmb_rndv_durum.Location = new System.Drawing.Point(20, 120);
            this.cmb_rndv_durum.Name = "cmb_rndv_durum";
            this.cmb_rndv_durum.Size = new System.Drawing.Size(267, 29);
            this.cmb_rndv_durum.TabIndex = 13;
            this.cmb_rndv_durum.Text = "Bekleyen Randevular";
            this.cmb_rndv_durum.SelectedIndexChanged += new System.EventHandler(this.cmb_rndv_durum_SelectedIndexChanged);
            // 
            // btn_randevu_oonay
            // 
            this.btn_randevu_oonay.ActiveBorderThickness = 1;
            this.btn_randevu_oonay.ActiveCornerRadius = 20;
            this.btn_randevu_oonay.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_randevu_oonay.ActiveForecolor = System.Drawing.Color.White;
            this.btn_randevu_oonay.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_randevu_oonay.BackColor = System.Drawing.SystemColors.Control;
            this.btn_randevu_oonay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_randevu_oonay.BackgroundImage")));
            this.btn_randevu_oonay.ButtonText = "Randevuyu Tamamla";
            this.btn_randevu_oonay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_randevu_oonay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_randevu_oonay.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_randevu_oonay.IdleBorderThickness = 1;
            this.btn_randevu_oonay.IdleCornerRadius = 20;
            this.btn_randevu_oonay.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_randevu_oonay.IdleForecolor = System.Drawing.Color.Black;
            this.btn_randevu_oonay.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_randevu_oonay.Location = new System.Drawing.Point(525, 117);
            this.btn_randevu_oonay.Margin = new System.Windows.Forms.Padding(5);
            this.btn_randevu_oonay.Name = "btn_randevu_oonay";
            this.btn_randevu_oonay.Size = new System.Drawing.Size(213, 29);
            this.btn_randevu_oonay.TabIndex = 12;
            this.btn_randevu_oonay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_randevu_oonay.Click += new System.EventHandler(this.btn_randevu_oonay_Click);
            // 
            // main_r_liste_datagrid
            // 
            this.main_r_liste_datagrid.AllowUserToAddRows = false;
            this.main_r_liste_datagrid.AllowUserToDeleteRows = false;
            this.main_r_liste_datagrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.main_r_liste_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.main_r_liste_datagrid.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.main_r_liste_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_r_liste_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.main_r_liste_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.main_r_liste_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_r_liste_datagrid.DoubleBuffered = true;
            this.main_r_liste_datagrid.EnableHeadersVisualStyles = false;
            this.main_r_liste_datagrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.main_r_liste_datagrid.HeaderBgColor = System.Drawing.Color.Turquoise;
            this.main_r_liste_datagrid.HeaderForeColor = System.Drawing.Color.DarkSlateGray;
            this.main_r_liste_datagrid.Location = new System.Drawing.Point(20, 155);
            this.main_r_liste_datagrid.Name = "main_r_liste_datagrid";
            this.main_r_liste_datagrid.ReadOnly = true;
            this.main_r_liste_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.main_r_liste_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.main_r_liste_datagrid.Size = new System.Drawing.Size(971, 413);
            this.main_r_liste_datagrid.TabIndex = 11;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.ErrorImage = null;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.InitialImage = null;
            this.btn_close.Location = new System.Drawing.Point(12, 574);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 29);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 10;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel_ustkisim
            // 
            this.panel_ustkisim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_ustkisim.BackgroundImage")));
            this.panel_ustkisim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_ustkisim.Controls.Add(this.lbl_zamann);
            this.panel_ustkisim.Controls.Add(this.lbl_girisyapan);
            this.panel_ustkisim.Controls.Add(this.d_minifoto);
            this.panel_ustkisim.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ustkisim.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_ustkisim.GradientBottomRight = System.Drawing.Color.White;
            this.panel_ustkisim.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.panel_ustkisim.GradientTopRight = System.Drawing.Color.YellowGreen;
            this.panel_ustkisim.Location = new System.Drawing.Point(0, 0);
            this.panel_ustkisim.Name = "panel_ustkisim";
            this.panel_ustkisim.Quality = 10;
            this.panel_ustkisim.Size = new System.Drawing.Size(1003, 82);
            this.panel_ustkisim.TabIndex = 0;
            // 
            // lbl_zamann
            // 
            this.lbl_zamann.AutoSize = true;
            this.lbl_zamann.BackColor = System.Drawing.Color.Transparent;
            this.lbl_zamann.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_zamann.ForeColor = System.Drawing.Color.White;
            this.lbl_zamann.Location = new System.Drawing.Point(35, 30);
            this.lbl_zamann.Name = "lbl_zamann";
            this.lbl_zamann.Size = new System.Drawing.Size(67, 22);
            this.lbl_zamann.TabIndex = 2;
            this.lbl_zamann.Text = "label1";
            // 
            // lbl_girisyapan
            // 
            this.lbl_girisyapan.AutoSize = true;
            this.lbl_girisyapan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_girisyapan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lbl_girisyapan.Location = new System.Drawing.Point(898, 65);
            this.lbl_girisyapan.Name = "lbl_girisyapan";
            this.lbl_girisyapan.Size = new System.Drawing.Size(47, 17);
            this.lbl_girisyapan.TabIndex = 1;
            this.lbl_girisyapan.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_tablo_icin
            // 
            this.timer_tablo_icin.Enabled = true;
            this.timer_tablo_icin.Tick += new System.EventHandler(this.timer_tablo_icin_Tick);
            // 
            // doktor_paneli_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 606);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doktor_paneli_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doktor_panel";
            this.Load += new System.EventHandler(this.doktor_paneli_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.d_minifoto)).EndInit();
            this.pnl_logout.ResumeLayout(false);
            this.pnl_logout.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_r_liste_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.panel_ustkisim.ResumeLayout(false);
            this.panel_ustkisim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_ustkisim;
        private System.Windows.Forms.Label lbl_girisyapan;
        private System.Windows.Forms.PictureBox d_minifoto;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_mailgonder;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_kisisel_ayarlar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuCustomDataGrid main_r_liste_datagrid;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_randevu_oonay;
        private System.Windows.Forms.ComboBox cmb_rndv_durum;
        private System.Windows.Forms.Label lbl_zamann;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer_tablo_icin;
    }
}