namespace Login
{
    partial class sil_guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sil_guncelle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tablo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_doktor_ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_doktor_soyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_doktor_eposta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_ara = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txt_doktor_ad);
            this.bunifuGradientPanel1.Controls.Add(this.tablo);
            this.bunifuGradientPanel1.Controls.Add(this.txt_doktor_soyad);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton21);
            this.bunifuGradientPanel1.Controls.Add(this.txt_ara);
            this.bunifuGradientPanel1.Controls.Add(this.txt_doktor_eposta);
            this.bunifuGradientPanel1.Controls.Add(this.comboBox5);
            this.bunifuGradientPanel1.Controls.Add(this.btn_close);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1000, 378);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // tablo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablo.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.tablo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo.DoubleBuffered = true;
            this.tablo.EnableHeadersVisualStyles = false;
            this.tablo.GridColor = System.Drawing.Color.DarkSalmon;
            this.tablo.HeaderBgColor = System.Drawing.Color.Linen;
            this.tablo.HeaderForeColor = System.Drawing.Color.Black;
            this.tablo.Location = new System.Drawing.Point(266, 44);
            this.tablo.Name = "tablo";
            this.tablo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablo.Size = new System.Drawing.Size(722, 306);
            this.tablo.TabIndex = 27;
            this.tablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablo_CellClick_1);
            // 
            // txt_doktor_ad
            // 
            this.txt_doktor_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_doktor_ad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_doktor_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_doktor_ad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_doktor_ad.HintText = "";
            this.txt_doktor_ad.isPassword = false;
            this.txt_doktor_ad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_doktor_ad.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_doktor_ad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_doktor_ad.LineThickness = 3;
            this.txt_doktor_ad.Location = new System.Drawing.Point(36, 84);
            this.txt_doktor_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doktor_ad.Name = "txt_doktor_ad";
            this.txt_doktor_ad.Size = new System.Drawing.Size(223, 33);
            this.txt_doktor_ad.TabIndex = 27;
            this.txt_doktor_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_doktor_soyad
            // 
            this.txt_doktor_soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_doktor_soyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_doktor_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_doktor_soyad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_doktor_soyad.HintText = "";
            this.txt_doktor_soyad.isPassword = false;
            this.txt_doktor_soyad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_doktor_soyad.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_doktor_soyad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_doktor_soyad.LineThickness = 3;
            this.txt_doktor_soyad.Location = new System.Drawing.Point(36, 125);
            this.txt_doktor_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doktor_soyad.Name = "txt_doktor_soyad";
            this.txt_doktor_soyad.Size = new System.Drawing.Size(223, 33);
            this.txt_doktor_soyad.TabIndex = 28;
            this.txt_doktor_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Güncelle";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(34, 204);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(225, 35);
            this.bunifuThinButton21.TabIndex = 36;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txt_doktor_eposta
            // 
            this.txt_doktor_eposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_doktor_eposta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_doktor_eposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_doktor_eposta.HintForeColor = System.Drawing.Color.Empty;
            this.txt_doktor_eposta.HintText = "";
            this.txt_doktor_eposta.isPassword = false;
            this.txt_doktor_eposta.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_doktor_eposta.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_doktor_eposta.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_doktor_eposta.LineThickness = 3;
            this.txt_doktor_eposta.Location = new System.Drawing.Point(35, 166);
            this.txt_doktor_eposta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doktor_eposta.Name = "txt_doktor_eposta";
            this.txt_doktor_eposta.Size = new System.Drawing.Size(223, 33);
            this.txt_doktor_eposta.TabIndex = 34;
            this.txt_doktor_eposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ara
            // 
            this.txt_ara.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ara.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ara.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ara.HintText = "";
            this.txt_ara.isPassword = false;
            this.txt_ara.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_ara.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ara.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_ara.LineThickness = 3;
            this.txt_ara.Location = new System.Drawing.Point(163, 9);
            this.txt_ara.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(205, 31);
            this.txt_ara.TabIndex = 22;
            this.txt_ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(35, 12);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 28);
            this.comboBox5.TabIndex = 21;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.ErrorImage = null;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.InitialImage = null;
            this.btn_close.Location = new System.Drawing.Point(966, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 29);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 9;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // sil_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 378);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sil_guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sil_guncelle";
            this.Load += new System.EventHandler(this.sil_guncelle_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.ComboBox comboBox5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ara;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_doktor_ad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_doktor_soyad;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_doktor_eposta;
    }
}