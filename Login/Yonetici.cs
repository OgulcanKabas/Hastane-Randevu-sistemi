using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Yonetici : Form
    {
        int Move;
        int Mouse_X;
        int Mouse_Y;
        bool kontrol;
        public Yonetici()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection con = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection con2 = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection mysqlbaglanpol = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection mysqlbaglandanisman = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection mysqlbaglanuye = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection mysqlbaglann = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlDataAdapter baglayici = new MySqlDataAdapter();
        MySqlCommand komut = new MySqlCommand();

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Doktor_ekle doktor_ekle = new Doktor_ekle();
            doktor_ekle.ShowDialog();
           
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Danısman daısman_ekle = new Danısman();
            daısman_ekle.ShowDialog();
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            poliklinik_ekle poliklinik_ekle = new poliklinik_ekle();
            poliklinik_ekle.ShowDialog();
            poliklinik_ekle.Activate();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            sil_guncelle sil_guncelle = new sil_guncelle();
            sil_guncelle.ShowDialog();
        }

        private void pnl_yonetici_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void pnl_yonetici_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void pnl_yonetici_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            pnl_logout.Visible = false;
            ackapa = true;
            //grafiğe değer eklediğim kısım 
            chart1.Titles.Add("Birimlere Göre Alınan Randevu Sayısı(Bugüne kadar her gün)");
            con.Open();
            MySqlCommand chart = new MySqlCommand();
            chart.CommandText = "SELECT doktor.ad,doktor.soyad,doktor.alan,doktor.pol_no,COUNT(randevular.r_pol_ad) from doktor,randevular where doktor.alan=randevular.r_pol_ad and randevular.r_pol_no=doktor.pol_no GROUP BY doktor.ad,doktor.soyad";
            chart.Connection = con;
            MySqlDataReader chartoku = chart.ExecuteReader();
            while (chartoku.Read())
            {
                chart1.Series["Birimler"].Points.AddXY(chartoku["alan"], chartoku["COUNT(randevular.r_pol_ad)"]);
            }
            con.Close();




            // toplam doktor sayısı için kullandığım kod dizini
            mysqlbaglanuye.Open();
            MySqlCommand komutuye = new MySqlCommand();

            MySqlDataReader druye;
            komutuye.CommandText = "SELECT count(*) from uyeler";
            komutuye.Connection = mysqlbaglanuye;
            komutuye.CommandType = CommandType.Text;
            druye = komutuye.ExecuteReader();

            while (druye.Read())
            {
                lbl_uye_say.Text = druye["COUNT(*)"].ToString();
            }
            mysqlbaglanuye.Close();


            // toplam doktor sayısı için kullandığım kod dizini
            mysqlbaglann.Open();
            MySqlCommand komutt = new MySqlCommand();

            MySqlDataReader drr;
            komutt.CommandText = "SELECT count(*) from doktor";
            komutt.Connection = mysqlbaglann;
            komutt.CommandType = CommandType.Text;
            drr = komutt.ExecuteReader();

            while (drr.Read())
            {
                label_doktor_say.Text = drr["COUNT(*)"].ToString();
            }
            mysqlbaglann.Close();

            // toplam danışman için kullandığım kod dizini

            mysqlbaglandanisman.Open();
            MySqlCommand komutdanisman = new MySqlCommand();

            MySqlDataReader drdanisman;
            komutdanisman.CommandText = "SELECT count(*) from danisman";
            komutdanisman.Connection = mysqlbaglandanisman;
            komutdanisman.CommandType = CommandType.Text;
            drdanisman = komutdanisman.ExecuteReader();

            while (drdanisman.Read())
            {
                lbl_danismansay.Text = drdanisman["COUNT(*)"].ToString();
            }
            mysqlbaglandanisman.Close();
            //-------------------------------------------------------------------------///

            mysqlbaglanpol.Open();
            MySqlCommand komutpol = new MySqlCommand();

            MySqlDataReader drpol;
            komutpol.CommandText = "SELECT count(*) from poliklinik";
            komutpol.Connection = mysqlbaglanpol;
            komutpol.CommandType = CommandType.Text;
            drpol = komutpol.ExecuteReader();

            while (drpol.Read())
            {
                lbl_polsay.Text = drpol["COUNT(*)"].ToString();
            }
            mysqlbaglanpol.Close();

            //////////////----------------------------------------

            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand();

            MySqlDataReader dr;
            komut.CommandText = "SELECT *FROM yonetici where tc='" + Login.giris_id + "'";
            komut.Connection = mysqlbaglan;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                giris_yapan.Text = dr["ad"].ToString()+" " + dr["soyad"].ToString();
                if (dr["fotograf"]!=null)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dr["fotograf"]);
                    MemoryStream mem = new MemoryStream(data);
                    minifoto.Image = Image.FromStream(mem);
                    minifoto.SizeMode = PictureBoxSizeMode.Zoom;
                }

            }
           

            mysqlbaglan.Close();

            /////////////////////
            

            kontrol = false;
            if (kontrol==false)
            {
                gizlegoster.Visible = false;
                kontrol = true;
            }
            timer1.Start();
            

        }

      



        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_zaman.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gizlegos_picturebox_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                ac_stil.ShowSync(gizlegoster);
                gizlegoster.Visible = true;
                gizlegos_picturebox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                gizlegos_picturebox.Refresh();
                kontrol = false;
            }
            else
            {
                ac_stil.HideSync(gizlegoster);
                gizlegoster.Visible = false;
                gizlegos_picturebox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                gizlegos_picturebox.Refresh();
                kontrol = true;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Doktor_ekle doktor_ekle = new Doktor_ekle();
            doktor_ekle.ShowDialog();
        }

        private void arkaplan_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (soru == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {
            yoneticiekle yntekle = new yoneticiekle();
            yntekle.ShowDialog();

        }

        bool ackapa;
        private void minifoto_Click(object sender, EventArgs e)
        {

            if (ackapa == true)
            {
                pnl_logout.Visible = true;
                ackapa = false;
            }
            else
            {

                pnl_logout.Visible = false;
                ackapa = true;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
