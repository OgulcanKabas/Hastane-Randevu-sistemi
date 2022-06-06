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
    public partial class Doktor_ekle : Form
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection mysqlbaglan2 = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection mysqlbaglan3 = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        DataTable table = new DataTable();//bir adette datatable
        MySqlCommand kmt = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi
        MySqlCommand kmt2 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi
        MySqlCommand kmt3 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi



        string resimyol;
        public Doktor_ekle()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

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





            //}


        }
        private void temizle()
        {
            txt_ad_doktor.Text = "";
            txt_sifre_dktr.Text = "";
            txt_tc_doktor.Text = "";
            txt_soyad_doktor.Text = "";
            cmb_sex.Text = "Cinsiyet";
            cmb_poliklinikad.Text = "Poliklinik Adı";
            cmb_poliklinikno.Text = "Poliklinik No";
            cmb_bulkat.Text = "Bulunduğu Kat";
            pictureBox1.ImageLocation = Application.StartupPath + "\\dt_img\\img_yükle.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (txt_ad_doktor.Text!="" && txt_soyad_doktor.Text!=""&& txt_tc_doktor.Text!=""&&cmb_sex.Text!="Cinsiyet"&&cmb_poliklinikno.Text!="Poliklinik No"&&cmb_poliklinikad.Text!="Poliklinik Adı"&&cmb_bulkat.Text!="Bulunduğu Kat")
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

                        kmt.CommandText = ((((((((("INSERT INTO doktor(ad,soyad,tc,sifre,cinsiyet,alan,pol_no,b_kat,e_posta,fotograff) VALUES ('" + txt_ad_doktor.Text + "','") + txt_soyad_doktor.Text + "','") + txt_tc_doktor.Text + "','") + txt_sifre_dktr.Text + "','") + cmb_sex.Text + "','")+ cmb_poliklinikad.Text + "','")+ cmb_poliklinikno.Text + "','")+ cmb_bulkat.Text + "','")+ txt_ad_doktor.Text + "." + txt_soyad_doktor.Text + "@hastane" )+ "',@image)";
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



            if (txt_tc_doktor.Text!="" && txt_ad_doktor.Text!="" && txt_soyad_doktor.Text!="")
            {
                string imagefile = Path.GetFileName(pictureBox1.ImageLocation);
                string imagepath = Path.Combine(Application.StartupPath + "\\dt_img\\doctor\\" + imagefile);
                File.Copy(pictureBox1.ImageLocation, imagepath, true);

                
            }


            mysqlbaglan.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Doktor_ekle_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\yukle.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi

            MySqlDataReader dr;
            komut.CommandText = "SELECT *FROM poliklinik";
            komut.Connection = mysqlbaglan;
            komut.CommandType = CommandType.Text;
            


          
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_bulkat.Items.Add(dr["p_kat"]);

                
            }
            
            mysqlbaglan.Close();
           
           



            cmb_sex.Items.Add("Erkek");
            cmb_sex.Items.Add("Kadın");

        }

        private void cmb_poliklinikad_TextChanged(object sender, EventArgs e)
        {

           
        }
        private void cmb_poliklinikad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_poliklinikad.Text != "Poliklinik Adı")
            {
                mysqlbaglan3.Open();
                MySqlCommand komut3 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi
                MySqlDataReader dr3;
                komut3.CommandText = "SELECT (p_no) FROM poliklinik where p_ad='" + cmb_poliklinikad.Text.ToString() + "'";
                komut3.Connection = mysqlbaglan3;
                komut3.CommandType = CommandType.Text;
                dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    cmb_poliklinikno.Items.Clear();

                    cmb_poliklinikno.Items.Add(dr3["p_no"]);
                }
                mysqlbaglan3.Close();
            }
        }
        private void cmb_poliklinikno_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_sifre_dktr_OnValueChanged(object sender, EventArgs e)
        {
            txt_sifre_dktr.isPassword = true;
        }

        private void txt_tc_doktor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_ad_doktor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
    && !char.IsSeparator(e.KeyChar);
        }

        private void txt_soyad_doktor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
    && !char.IsSeparator(e.KeyChar);
        }

        private void cmb_bulkat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_bulkat.Text != "Bulunduğu Kat")
            {
                mysqlbaglan2.Open();
                MySqlCommand komut2 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi
                MySqlDataReader dr2;
                komut2.CommandText = "SELECT (p_ad) FROM poliklinik where p_kat='" + cmb_bulkat.Text.ToString() + "'";
                komut2.Connection = mysqlbaglan2;
                komut2.CommandType = CommandType.Text;
                dr2 = komut2.ExecuteReader();
                cmb_poliklinikad.Items.Clear();
                while (dr2.Read())
                {
                    
                    cmb_poliklinikad.Items.Add(dr2["p_ad"]);
                }

                mysqlbaglan2.Close();
            }

        }
    }
}
