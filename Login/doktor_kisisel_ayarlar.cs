using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace Login
{
    public partial class doktor_kisisel_ayarlar : Form
    {
        public doktor_kisisel_ayarlar()
        {
            InitializeComponent();
        }

        MySqlConnection mysqlbaglan = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection mysqlbaglane = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection mysqlbaglan1 = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection baglan = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlDataReader dr;
        MySqlDataReader dre;
        string resimyol;
        MySqlDataAdapter baglayici = new MySqlDataAdapter();
        MySqlCommand komut = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi    
        MySqlCommand komute = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi    
        MySqlCommand kmt = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi    

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doktor_kisisel_ayarlar_Load(object sender, EventArgs e)
        {
            lbl_uyari.Visible = false;
            mysqlbaglan.Open();
                    
            komut.CommandText = "SELECT *FROM doktor where tc='" + Login.giris_id + "'";
            komut.Connection = mysqlbaglan;
            komut.CommandType = CommandType.Text;

            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                txt_eposta_guncelle.Text = dr["e_posta"].ToString();
                if (dr["fotograff"] != null)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dr["fotograff"]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(mem);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }

            }
           
        }

        private void lbl_foto_degistir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Yükle";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            resimyol = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void temizle()
        {
            mysqlbaglane.Open();

            komute.CommandText = "SELECT *FROM doktor where tc='" + Login.giris_id + "'";
            komute.Connection = mysqlbaglane;
            komute.CommandType = CommandType.Text;

            dre = komute.ExecuteReader();

            while (dre.Read())
            {
                txt_eposta_guncelle.Text = dre["e_posta"].ToString();
                if (dre["fotograff"] != null)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dre["fotograff"]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(mem);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }

            }
            mysqlbaglane.Close();
            txt_sifre_guncelle.Text = "";
            txt_sifre_onay.Text = "";
        }
        private void btn_doktor_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_sifre_guncelle.Text==txt_sifre_onay.Text)
            {
                FileStream fileStream = new FileStream(resimyol, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();
                mysqlbaglan1.Open();
                if (mysqlbaglan1.State != ConnectionState.Closed)
                {
                    kmt.Connection = mysqlbaglan1;

                    kmt.CommandText = "Update doktor set e_posta=@eposta,sifre=@sifre,fotograff=@image where tc=@tcno";

                    kmt.Parameters.AddWithValue("@eposta", txt_eposta_guncelle.Text);
                    kmt.Parameters.AddWithValue("@tcno", Login.giris_id);
                    kmt.Parameters.AddWithValue("@sifre", txt_sifre_guncelle.Text);
                    kmt.Parameters.Add("@image", MySqlDbType.Blob, resim.Length).Value = resim;

                    kmt.ExecuteNonQuery();

                    MessageBox.Show("Güncelleme İşlemi Başarılı");
                    temizle();
                    lbl_uyari.Visible = false;
                    mysqlbaglan1.Close();


                }
                else
                {
                    MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
                }
            }
            else
            {
                lbl_uyari.Visible = true;
                lbl_uyari.Text = "Şifreler uyuşmuyor";
            }
          
                
            
            }
    }
}
