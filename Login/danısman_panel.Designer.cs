namespace Login
{
    partial class danısman_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(danısman_panel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pct_dnsmn_foto = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_rndv_durum = new System.Windows.Forms.ComboBox();
            this.btn_fis_kes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.main_r_liste_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_dnsmn_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_r_liste_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_close);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pct_dnsmn_foto);
            this.bunifuGradientPanel1.Controls.Add(this.dateTimePicker1);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_rndv_durum);
            this.bunifuGradientPanel1.Controls.Add(this.btn_fis_kes);
            this.bunifuGradientPanel1.Controls.Add(this.main_r_liste_datagrid);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.GreenYellow;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1020, 614);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.ErrorImage = null;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.InitialImage = null;
            this.btn_close.Location = new System.Drawing.Point(3, 582);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 29);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 26;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // pct_dnsmn_foto
            // 
            this.pct_dnsmn_foto.BackColor = System.Drawing.Color.Transparent;
            this.pct_dnsmn_foto.Location = new System.Drawing.Point(3, 3);
            this.pct_dnsmn_foto.Name = "pct_dnsmn_foto";
            this.pct_dnsmn_foto.Size = new System.Drawing.Size(54, 52);
            this.pct_dnsmn_foto.TabIndex = 24;
            this.pct_dnsmn_foto.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 27);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 27, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmb_rndv_durum
            // 
            this.cmb_rndv_durum.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmb_rndv_durum.FormattingEnabled = true;
            this.cmb_rndv_durum.Items.AddRange(new object[] {
            "Fiş Kesilen Randevular",
            "Bekleyen Randevular"});
            this.cmb_rndv_durum.Location = new System.Drawing.Point(484, 43);
            this.cmb_rndv_durum.Name = "cmb_rndv_durum";
            this.cmb_rndv_durum.Size = new System.Drawing.Size(224, 29);
            this.cmb_rndv_durum.TabIndex = 22;
            this.cmb_rndv_durum.Text = "Bekleyen Randevular";
            this.cmb_rndv_durum.SelectedIndexChanged += new System.EventHandler(this.cmb_rndv_durum_SelectedIndexChanged);
            // 
            // btn_fis_kes
            // 
            this.btn_fis_kes.ActiveBorderThickness = 1;
            this.btn_fis_kes.ActiveCornerRadius = 20;
            this.btn_fis_kes.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_fis_kes.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_fis_kes.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btn_fis_kes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_fis_kes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fis_kes.BackgroundImage")));
            this.btn_fis_kes.ButtonText = "Fiş Kes";
            this.btn_fis_kes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fis_kes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fis_kes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_fis_kes.IdleBorderThickness = 1;
            this.btn_fis_kes.IdleCornerRadius = 20;
            this.btn_fis_kes.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_fis_kes.IdleForecolor = System.Drawing.Color.Black;
            this.btn_fis_kes.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_fis_kes.Location = new System.Drawing.Point(745, 43);
            this.btn_fis_kes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_fis_kes.Name = "btn_fis_kes";
            this.btn_fis_kes.Size = new System.Drawing.Size(213, 29);
            this.btn_fis_kes.TabIndex = 21;
            this.btn_fis_kes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_fis_kes.Click += new System.EventHandler(this.btn_fis_kes_Click);
            // 
            // main_r_liste_datagrid
            // 
            this.main_r_liste_datagrid.AllowUserToAddRows = false;
            this.main_r_liste_datagrid.AllowUserToDeleteRows = false;
            this.main_r_liste_datagrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.main_r_liste_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.main_r_liste_datagrid.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.main_r_liste_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_r_liste_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.main_r_liste_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.main_r_liste_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_r_liste_datagrid.DoubleBuffered = true;
            this.main_r_liste_datagrid.EnableHeadersVisualStyles = false;
            this.main_r_liste_datagrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.main_r_liste_datagrid.HeaderBgColor = System.Drawing.Color.Turquoise;
            this.main_r_liste_datagrid.HeaderForeColor = System.Drawing.Color.DarkSlateGray;
            this.main_r_liste_datagrid.Location = new System.Drawing.Point(12, 85);
            this.main_r_liste_datagrid.Name = "main_r_liste_datagrid";
            this.main_r_liste_datagrid.ReadOnly = true;
            this.main_r_liste_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.main_r_liste_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.main_r_liste_datagrid.Size = new System.Drawing.Size(971, 491);
            this.main_r_liste_datagrid.TabIndex = 20;
            this.main_r_liste_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.main_r_liste_datagrid_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // danısman_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "danısman_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "danısman_panel";
            this.Load += new System.EventHandler(this.danısman_panel_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_dnsmn_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_r_liste_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_rndv_durum;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_fis_kes;
        private Bunifu.Framework.UI.BunifuCustomDataGrid main_r_liste_datagrid;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox pct_dnsmn_foto;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
    }
}