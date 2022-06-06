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
    public partial class Danısman : Form
    {
        public Danısman()
        {
            InitializeComponent();
        }
        string resimyol;
        
        DataTable table = new DataTable();//bir adette datatable

        
        MySqlCommand kmt2 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection mysqlbaglan2 = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection mysqlbaglan3 = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection mysqlbaglan4 = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection mysqlbaglan5 = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");


        


        private void btn_close_Click(object sender, EventArgs e)

        {
            this.Close();
        }
        private void temizle()
        {
            txt_ad_dnsmn.Text = "";
            txt_soyad_dnsmn.Text = "";
            txt_sifre_dnsmn.Text = "";
            txt_tc_dnsmn.Text = "";
            cmb_sex_dnsmn.Text = "Cinsiyet";
            pol_1_ad.Text = "Poliklinik Adı";
            pol_1_kat.Text = "Bulunduğu Kat";
            pol_1_no.Text = "Poliklinik No";
            pol_2_ad.Text = "Poliklinik Adı";
            pol_2_no.Text = "Poliklinik No";
            pol_3_ad.Text = "Poliklinik Adı";
            pol_3_no.Text = "Poliklinik No";
            txt_eposta.Text = "";
        
            pictureBox1.ImageLocation = Application.StartupPath + "\\dt_img\\img_yükle.png";

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (txt_ad_dnsmn.Text != "" && txt_soyad_dnsmn.Text != "" && txt_tc_dnsmn.Text != "" && cmb_sex_dnsmn.Text != "Cinsiyet" && pol_1_no.Text != "Poliklinik No" && pol_1_ad.Text != "Poliklinik Adı" && pol_1_kat.Text != "Bulunduğu Kat")
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
                        MySqlCommand kmt = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi
                        kmt.Connection = mysqlbaglan;//bağlantı yolunu verdik

                        kmt.CommandText = ((((((((((((("INSERT INTO danisman(tc,sifre,ad,soyad,cinsiyet,bulundugu_kat,pol1_ad,pol1_no,pol2_ad,pol2_no,pol3_ad,pol3_no,e_posta,fotograf) VALUES ('" + txt_tc_dnsmn.Text+ "','") + txt_sifre_dnsmn.Text + "','") + txt_ad_dnsmn.Text + "','") + txt_soyad_dnsmn.Text + "','") + cmb_sex_dnsmn.Text + "','")  + pol_1_kat.Text + "','") + pol_1_ad.Text + "','") + pol_1_no.Text + "','") + pol_2_ad.Text + "','") + pol_2_no.Text + "','")   + pol_3_ad.Text + "','") + pol_3_no.Text + "','" )+ txt_ad_dnsmn.Text + "." + txt_soyad_dnsmn.Text + "@hastane" )+"',@image)"; 


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






            if (txt_tc_dnsmn.Text != "" && txt_ad_dnsmn.Text != "" && txt_soyad_dnsmn.Text != "")
            {
                string imagefile = Path.GetFileName(pictureBox1.ImageLocation);
                string imagepath = Path.Combine(Application.StartupPath + "\\dt_img\\doctor\\" + imagefile);
                File.Copy(pictureBox1.ImageLocation, imagepath, true);


            }

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
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

        }

        private void Danısman_Load(object sender, EventArgs e)
        {

            //mysqlbaglan.Open();
            //MySqlCommand komut = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi

            //MySqlDataReader dr;
            //komut.CommandText = "SELECT *FROM poliklinik" ;
            //komut.Connection = mysqlbaglan;
            //komut.CommandType = CommandType.Text;




            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    pol_1_kat.Items.Add(dr["p_kat"]);



            //}

            //mysqlbaglan.Close();
            pol_1_kat.Items.Add("Zemin Kat");
            pol_1_kat.Items.Add("1.Kat");
            pol_1_kat.Items.Add("2.Kat");
            pol_1_kat.Items.Add("3.Kat");
            pol_1_kat.Items.Add("4.Kat");



            cmb_sex_dnsmn.Items.Add("Erkek");
            cmb_sex_dnsmn.Items.Add("Kadın");
        }

        private void pol_1_kat_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void pol_1_kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            pol_1_ad.Items.Clear();
            pol_2_ad.Items.Clear();
            pol_3_ad.Items.Clear();
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi

            MySqlDataReader dr;
            komut.CommandText = "SELECT *FROM poliklinik where p_kat='" + pol_1_kat.Text.ToString() + "'";
            komut.Connection = mysqlbaglan;
            komut.CommandType = CommandType.Text;




            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                pol_1_ad.Items.Add(dr["p_ad"]);
                pol_2_ad.Items.Add(dr["p_ad"]);
                pol_3_ad.Items.Add(dr["p_ad"]);


            }

            mysqlbaglan.Close();
        }

        private void pol_1_ad_SelectedIndexChanged(object sender, EventArgs e)
        {

            pol_1_no.Items.Clear();
            mysqlbaglan3.Open();
            MySqlCommand komut3 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi

            MySqlDataReader dr3;
            komut3.CommandText = "SELECT *FROM poliklinik where p_ad='" + pol_1_ad.Text.ToString() + "'";
            komut3.Connection = mysqlbaglan3;
            komut3.CommandType = CommandType.Text;




            dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                pol_1_no.Items.Add(dr3["p_no"]);



            }

            mysqlbaglan3.Close();
        }

        private void pol_2_ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            pol_2_no.Items.Clear();
            mysqlbaglan4.Open();
            MySqlCommand komut4 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi

            MySqlDataReader dr4;
            komut4.CommandText = "SELECT *FROM poliklinik where p_ad='" + pol_2_ad.Text.ToString() + "'";
            komut4.Connection = mysqlbaglan4;
            komut4.CommandType = CommandType.Text;




            dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                pol_2_no.Items.Add(dr4["p_no"]);



            }

            mysqlbaglan4.Close();
        }

        private void pol_3_ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            pol_3_no.Items.Clear();
            mysqlbaglan5.Open();
            MySqlCommand komut5 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi

            MySqlDataReader dr5;
            komut5.CommandText = "SELECT *FROM poliklinik where p_ad='" + pol_3_ad.Text.ToString() + "'";
            komut5.Connection = mysqlbaglan5;
            komut5.CommandType = CommandType.Text;




            dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                pol_3_no.Items.Add(dr5["p_no"]);



            }

            mysqlbaglan5.Close();
        }

        private void txt_soyad_dnsmn_Leave(object sender, EventArgs e)
        {
            txt_eposta.Text = txt_ad_dnsmn.Text + "." + txt_soyad_dnsmn.Text + "@hastane";
        }

        private void txt_sifre_dnsmn_OnValueChanged(object sender, EventArgs e)
        {
            txt_sifre_dnsmn.isPassword = true;
        }

        private void Danısman_MouseUp(object sender, MouseEventArgs e)
        {
            //Move = 0;
        }

        private void txt_tc_dnsmn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_ad_dnsmn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
    && !char.IsSeparator(e.KeyChar);
        }

        private void txt_soyad_dnsmn_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_soyad_dnsmn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
    && !char.IsSeparator(e.KeyChar);
        }
    }
}

