namespace Login
{
    partial class mailgonder_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mailgonder_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_mailadres_sifrem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_dosya = new System.Windows.Forms.Label();
            this.btn_dosyayukle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_gonderilenmesaj = new System.Windows.Forms.RichTextBox();
            this.cmb_mailtoadd = new System.Windows.Forms.ComboBox();
            this.btn_mailgonder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_mail_konu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_mail_adresim = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.bunifuGradientPanel1.Controls.Add(this.btn_close);
            this.bunifuGradientPanel1.Controls.Add(this.txt_mailadres_sifrem);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_dosya);
            this.bunifuGradientPanel1.Controls.Add(this.btn_dosyayukle);
            this.bunifuGradientPanel1.Controls.Add(this.txt_gonderilenmesaj);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_mailtoadd);
            this.bunifuGradientPanel1.Controls.Add(this.btn_mailgonder);
            this.bunifuGradientPanel1.Controls.Add(this.txt_mail_konu);
            this.bunifuGradientPanel1.Controls.Add(this.txt_mail_adresim);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.GreenYellow;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1030, 494);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.PaleTurquoise;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Azure;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(22, 164);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(996, 292);
            this.bunifuCustomDataGrid1.TabIndex = 12;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.ErrorImage = null;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.InitialImage = null;
            this.btn_close.Location = new System.Drawing.Point(12, 462);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 29);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 11;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_mailadres_sifrem
            // 
            this.txt_mailadres_sifrem.BackColor = System.Drawing.Color.Azure;
            this.txt_mailadres_sifrem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mailadres_sifrem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_mailadres_sifrem.ForeColor = System.Drawing.Color.Black;
            this.txt_mailadres_sifrem.HintForeColor = System.Drawing.Color.Empty;
            this.txt_mailadres_sifrem.HintText = "Şifre";
            this.txt_mailadres_sifrem.isPassword = false;
            this.txt_mailadres_sifrem.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txt_mailadres_sifrem.LineIdleColor = System.Drawing.Color.YellowGreen;
            this.txt_mailadres_sifrem.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_mailadres_sifrem.LineThickness = 3;
            this.txt_mailadres_sifrem.Location = new System.Drawing.Point(22, 46);
            this.txt_mailadres_sifrem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mailadres_sifrem.Name = "txt_mailadres_sifrem";
            this.txt_mailadres_sifrem.Size = new System.Drawing.Size(270, 34);
            this.txt_mailadres_sifrem.TabIndex = 7;
            this.txt_mailadres_sifrem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_dosya
            // 
            this.lbl_dosya.AutoSize = true;
            this.lbl_dosya.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lbl_dosya.Location = new System.Drawing.Point(10, 325);
            this.lbl_dosya.Name = "lbl_dosya";
            this.lbl_dosya.Size = new System.Drawing.Size(0, 17);
            this.lbl_dosya.TabIndex = 6;
            // 
            // btn_dosyayukle
            // 
            this.btn_dosyayukle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_dosyayukle.BackColor = System.Drawing.Color.Azure;
            this.btn_dosyayukle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dosyayukle.BorderRadius = 0;
            this.btn_dosyayukle.ButtonText = "Dosya Yükle";
            this.btn_dosyayukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dosyayukle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dosyayukle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dosyayukle.Iconimage = global::Login.Properties.Resources.file_upload;
            this.btn_dosyayukle.Iconimage_right = null;
            this.btn_dosyayukle.Iconimage_right_Selected = null;
            this.btn_dosyayukle.Iconimage_Selected = null;
            this.btn_dosyayukle.IconMarginLeft = 0;
            this.btn_dosyayukle.IconMarginRight = 0;
            this.btn_dosyayukle.IconRightVisible = true;
            this.btn_dosyayukle.IconRightZoom = 0D;
            this.btn_dosyayukle.IconVisible = true;
            this.btn_dosyayukle.IconZoom = 50D;
            this.btn_dosyayukle.IsTab = false;
            this.btn_dosyayukle.Location = new System.Drawing.Point(602, 12);
            this.btn_dosyayukle.Name = "btn_dosyayukle";
            this.btn_dosyayukle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_dosyayukle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_dosyayukle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_dosyayukle.selected = false;
            this.btn_dosyayukle.Size = new System.Drawing.Size(141, 33);
            this.btn_dosyayukle.TabIndex = 5;
            this.btn_dosyayukle.Text = "Dosya Yükle";
            this.btn_dosyayukle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dosyayukle.Textcolor = System.Drawing.Color.Black;
            this.btn_dosyayukle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dosyayukle.Click += new System.EventHandler(this.btn_dosyayukle_Click);
            // 
            // txt_gonderilenmesaj
            // 
            this.txt_gonderilenmesaj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_gonderilenmesaj.Location = new System.Drawing.Point(310, 4);
            this.txt_gonderilenmesaj.Name = "txt_gonderilenmesaj";
            this.txt_gonderilenmesaj.Size = new System.Drawing.Size(286, 154);
            this.txt_gonderilenmesaj.TabIndex = 4;
            this.txt_gonderilenmesaj.Text = "Mesajınız....";
            // 
            // cmb_mailtoadd
            // 
            this.cmb_mailtoadd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_mailtoadd.FormattingEnabled = true;
            this.cmb_mailtoadd.Location = new System.Drawing.Point(22, 133);
            this.cmb_mailtoadd.Name = "cmb_mailtoadd";
            this.cmb_mailtoadd.Size = new System.Drawing.Size(270, 25);
            this.cmb_mailtoadd.TabIndex = 3;
            this.cmb_mailtoadd.Text = "Kime";
            // 
            // btn_mailgonder
            // 
            this.btn_mailgonder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_mailgonder.BackColor = System.Drawing.Color.Azure;
            this.btn_mailgonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mailgonder.BorderRadius = 0;
            this.btn_mailgonder.ButtonText = "Gönder";
            this.btn_mailgonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mailgonder.DisabledColor = System.Drawing.Color.Gray;
            this.btn_mailgonder.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_mailgonder.Iconimage = global::Login.Properties.Resources.send_icon;
            this.btn_mailgonder.Iconimage_right = null;
            this.btn_mailgonder.Iconimage_right_Selected = null;
            this.btn_mailgonder.Iconimage_Selected = null;
            this.btn_mailgonder.IconMarginLeft = 5;
            this.btn_mailgonder.IconMarginRight = 0;
            this.btn_mailgonder.IconRightVisible = true;
            this.btn_mailgonder.IconRightZoom = 0D;
            this.btn_mailgonder.IconVisible = true;
            this.btn_mailgonder.IconZoom = 65D;
            this.btn_mailgonder.IsTab = false;
            this.btn_mailgonder.Location = new System.Drawing.Point(602, 51);
            this.btn_mailgonder.Name = "btn_mailgonder";
            this.btn_mailgonder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_mailgonder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_mailgonder.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_mailgonder.selected = false;
            this.btn_mailgonder.Size = new System.Drawing.Size(141, 33);
            this.btn_mailgonder.TabIndex = 2;
            this.btn_mailgonder.Text = "Gönder";
            this.btn_mailgonder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mailgonder.Textcolor = System.Drawing.Color.Black;
            this.btn_mailgonder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mailgonder.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txt_mail_konu
            // 
            this.txt_mail_konu.BackColor = System.Drawing.Color.Azure;
            this.txt_mail_konu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mail_konu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_mail_konu.ForeColor = System.Drawing.Color.Black;
            this.txt_mail_konu.HintForeColor = System.Drawing.Color.Empty;
            this.txt_mail_konu.HintText = "Konu";
            this.txt_mail_konu.isPassword = false;
            this.txt_mail_konu.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txt_mail_konu.LineIdleColor = System.Drawing.Color.YellowGreen;
            this.txt_mail_konu.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_mail_konu.LineThickness = 3;
            this.txt_mail_konu.Location = new System.Drawing.Point(22, 88);
            this.txt_mail_konu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mail_konu.Name = "txt_mail_konu";
            this.txt_mail_konu.Size = new System.Drawing.Size(270, 33);
            this.txt_mail_konu.TabIndex = 1;
            this.txt_mail_konu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_mail_adresim
            // 
            this.txt_mail_adresim.BackColor = System.Drawing.Color.Azure;
            this.txt_mail_adresim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mail_adresim.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_mail_adresim.ForeColor = System.Drawing.Color.Black;
            this.txt_mail_adresim.HintForeColor = System.Drawing.Color.Empty;
            this.txt_mail_adresim.HintText = "E-posta";
            this.txt_mail_adresim.isPassword = false;
            this.txt_mail_adresim.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txt_mail_adresim.LineIdleColor = System.Drawing.Color.YellowGreen;
            this.txt_mail_adresim.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_mail_adresim.LineThickness = 3;
            this.txt_mail_adresim.Location = new System.Drawing.Point(22, 4);
            this.txt_mail_adresim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mail_adresim.Name = "txt_mail_adresim";
            this.txt_mail_adresim.Size = new System.Drawing.Size(270, 34);
            this.txt_mail_adresim.TabIndex = 0;
            this.txt_mail_adresim.Text = "Gönderen";
            this.txt_mail_adresim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mailgonder_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 494);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mailgonder_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mailgonder";
            this.Load += new System.EventHandler(this.mailgonder_form_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_mailgonder;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_mail_konu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_mail_adresim;
        private System.Windows.Forms.ComboBox cmb_mailtoadd;
        private System.Windows.Forms.RichTextBox txt_gonderilenmesaj;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dosyayukle;
        private System.Windows.Forms.Label lbl_dosya;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_mailadres_sifrem;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}