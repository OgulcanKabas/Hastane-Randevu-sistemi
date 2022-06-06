using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class yoneticiekle : Form
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        MySqlCommand kmt = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi
        string resimyol;
        public yoneticiekle()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            txt_ad_yon.Text = "";
            txt_soyad_yon.Text = "";
            txt_tx_yon.Text = "";
            txt_sifre_yon.Text = "";
            txt_eposta_yon.Text = "";
            pictureBox1.ImageLocation = Application.StartupPath + "\\dt_img\\img_yükle.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void btn_yon_ekle_Click(object sender, EventArgs e)
        {
            if (txt_ad_yon.Text != "" && txt_soyad_yon.Text != "" && txt_tx_yon.Text != "" && txt_sifre_yon.Text != "" )
            {

                try
                {
                    FileStream fileStream = new FileStream(resimyol, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                    binaryReader.Close();
                    fileStream.Close();
                    mysqlbaglan.Open();
                    if (mysqlbaglan.State != ConnectionState.Closed)
                    {
                        kmt.Connection = mysqlbaglan;//bağlantı yolunu verdik

                        kmt.CommandText = ((((("INSERT INTO yonetici(ad,soyad,tc,sifre,e_posta,fotograf) VALUES ('" + txt_ad_yon.Text + "','") + txt_soyad_yon.Text + "','") + txt_tx_yon.Text + "','") + txt_sifre_yon.Text + "','") + txt_ad_yon.Text + "." + txt_soyad_yon.Text + "@hastane") + "',@image)";
                        kmt.Parameters.Add("@image", MySqlDbType.Blob, resim.Length).Value = resim;
                        //komut textini girdik
                        kmt.ExecuteNonQuery();
                        //global olarak tanımladımız mysqlcommand kmt nesnesini çalıştırdık
                        MessageBox.Show("Kayıt İşlemi Başarılı");

                        mysqlbaglan.Close();
                        temizle();

                    }
                    else
                    {
                        MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Yükle";
            openFileDialog1.ShowDialog();
            //openFileDialog1.Filter = "JPEG Dosyaları (*.jpeg)|.jpeg|JPG Dosyaları(*.jpg)|.jpg |PNG Dosyaları(*.png)|.png ";
            //if (openFileDialog1.ShowDialog()==DialogResult.OK)
            //{

            pictureBox1.ImageLocation = openFileDialog1.FileName;
            resimyol = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void txt_tx_yon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_soyad_yon_Leave(object sender, EventArgs e)
        {
            txt_eposta_yon.Text = txt_ad_yon.Text + "." + txt_soyad_yon.Text + "@hastane";
        }

        private void txt_soyad_yon_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
