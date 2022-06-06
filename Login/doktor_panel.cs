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
   
    public partial class doktor_paneli_form : Form
    {
        bool ackapa;
        int kayitsayisi;
        int i;
        double ekks = 99.99;
        public doktor_paneli_form()
        {
            InitializeComponent();
        }

        MySqlConnection baglan = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection baglan5 = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlDataAdapter baglayici = new MySqlDataAdapter();
        MySqlCommand kmt = new MySqlCommand();
        MySqlDataReader dr;
        MySqlConnection baglan1 = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlDataAdapter baglayici1 = new MySqlDataAdapter();
        MySqlDataAdapter baglayici11 = new MySqlDataAdapter();
        MySqlCommand kmt1 = new MySqlCommand();
        DataTable tablo = new DataTable();
        DataTable tabloz = new DataTable();
        DataTable tabloz1 = new DataTable();
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        private void d_minifoto_Click(object sender, EventArgs e)
        {
            
            if (ackapa==true)
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

        private void doktor_paneli_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer_tablo_icin.Start();
          
            main_r_liste_datagrid.ReadOnly = true;

            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand();        
            komut.CommandText = "SELECT *FROM doktor where tc='" + Login.giris_id + "'";
            komut.Connection = mysqlbaglan;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                lbl_girisyapan.Text = dr["ad"].ToString() + " " + dr["soyad"].ToString();
                string sqlsorgusu = "Select distinct randevular.id, randevular.ad as Hasta_Adı,randevular.soyad as Hasta_Soyadı,randevular.tc as Hasta_TC,randevular.e_posta as Hasta_Eposta,randevular.r_pol_ad as Hasta_PoliklinikAdı,randevular.r_pol_no as Hasta_PoliklinikNo,randevular.r_tarihi as RandevuTarihi,randevular.r_saat as Randevu_Saati from randevular,doktor where '" + dr["alan"] + "'=randevular.r_pol_ad and '" + dr["pol_no"] + "'=randevular.r_pol_no and randevular.r_durum=0 and r_tarihi='"+dateTimePicker1.Text+"'" ;
                
                kmt.CommandText = sqlsorgusu;
                kmt.Connection = baglan;
                baglayici.SelectCommand = kmt;
                baglan.Open();
                baglayici.Fill(tablo);
                baglan.Close();
                this.main_r_liste_datagrid.DataSource = tablo;
                baglan.Close();
                if (dr["fotograff"] != null)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dr["fotograff"]);
                    MemoryStream mem = new MemoryStream(data);
                    d_minifoto.Image = Image.FromStream(mem);
                    d_minifoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
           

            pnl_logout.Visible = false;
            mysqlbaglan.Close();
            kayitsayisi = main_r_liste_datagrid.RowCount;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (soru == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void randevuonay()
        {

            string sqlsorgusu1 = "Update randevular set r_durum=1 where id='"+ main_r_liste_datagrid.CurrentRow.Cells[0].Value +"'";
            DataTable tablo1 = new DataTable();

            kmt1.CommandText = sqlsorgusu1;
            kmt1.Connection = baglan1;

            baglayici1.SelectCommand = kmt1;
            baglan1.Open();
            baglayici1.Fill(tablo1);
            baglan1.Close();
           
            this.main_r_liste_datagrid.DataSource = tablo1;


            string sqlsorgusu = "Select * from randevular where r_durum=0";
            DataTable tablo = new DataTable();

            kmt.CommandText = sqlsorgusu;
            kmt.Connection = baglan;

            baglayici.SelectCommand = kmt;
            baglan.Open();
            baglayici.Fill(tablo);
            baglan.Close();
            this.main_r_liste_datagrid.DataSource = tablo;

  



        }
        private void btn_randevu_oonay_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Randevuyu onaylamak istiyor musunuz?", "Randevu Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (soru == DialogResult.Yes)
            {
                randevuonay();
            }
            ekks = 99.99;
            

        }
        private void tablodoldur()
        {
            baglan1.Open();
            MySqlCommand listele = new MySqlCommand();  
            MySqlCommand listele1 = new MySqlCommand();  
            listele.CommandType = CommandType.Text;
            listele.CommandText = "SELECT *FROM doktor where tc='" + Login.giris_id + "'";
            listele.Connection = baglan1;
             MySqlDataReader drz;
            drz = listele.ExecuteReader();
            

            if (cmb_rndv_durum.Text == "Tamamlanan Randevular")
            {

                while (drz.Read())
                {

                    string sqlsorgusu = "Select distinct randevular.id, randevular.ad as Hasta_Adı,randevular.soyad as Hasta_Soyadı,randevular.tc as Hasta_TC,randevular.e_posta as Hasta_Eposta,randevular.r_pol_ad as Hasta_PoliklinikAdı,randevular.r_pol_no as Hasta_PoliklinikNo,Date(randevular.r_tarihi) as RandevuTarihi,randevular.r_saat as Randevu_Saati from randevular,doktor where '" + drz["alan"] + "'=randevular.r_pol_ad and '" + drz["pol_no"] + "'=randevular.r_pol_no and randevular.r_durum=1 and r_tarihi='" + dateTimePicker1.Text + "'";
                    tabloz1.Clear();
                    listele1.CommandText = sqlsorgusu;
                    listele1.Connection = baglan5;
                    baglayici1.SelectCommand = listele1;
                    baglan5.Open();
                    baglayici1.Fill(tabloz1);
                    baglan5.Close();
                    this.main_r_liste_datagrid.DataSource = tabloz1;

                }
            }

            if (cmb_rndv_durum.Text == "Bekleyen Randevular")
            {
                while (drz.Read())
                {

                    string sqlsorgusu = "Select distinct randevular.id, randevular.ad as Hasta_Adı,randevular.soyad as Hasta_Soyadı,randevular.tc as Hasta_TC,randevular.e_posta as Hasta_Eposta,randevular.r_pol_ad as Hasta_PoliklinikAdı,randevular.r_pol_no as Hasta_PoliklinikNo,Date(randevular.r_tarihi) as RandevuTarihi,randevular.r_saat as Randevu_Saati from randevular,doktor where '" + drz["alan"] + "'=randevular.r_pol_ad and '" + drz["pol_no"] + "'=randevular.r_pol_no and randevular.r_durum=0 and r_tarihi='" + dateTimePicker1.Text + "'";
                    tabloz1.Clear();
                    listele1.CommandText = sqlsorgusu;
                    listele1.Connection = baglan5;
                    baglayici1.SelectCommand = listele1;
                    baglan5.Open();
                    baglayici1.Fill(tabloz1);
                    baglan5.Close();
                    this.main_r_liste_datagrid.DataSource = tabloz1;

                }
            }

            baglan1.Close();
            
        }

        private void cmb_rndv_durum_SelectedIndexChanged(object sender, EventArgs e)
        {

            tablodoldur();

        }

        private void btn_mailgonder_Click(object sender, EventArgs e)
        {
            mailgonder_form mail_gonder = new mailgonder_form();
            mail_gonder.ShowDialog();

            
        }

        private void lbl_kisisel_ayarlar_Click(object sender, EventArgs e)
        {
            doktor_kisisel_ayarlar d_k_ayar = new doktor_kisisel_ayarlar();
            d_k_ayar.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_zamann.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();

       
            if (ekks == 99.99)
            {
                if (kayitsayisi > 0)
                {
                    for (i = 0; i < kayitsayisi; i++)
                    {
                        if (ekks > Convert.ToDouble(main_r_liste_datagrid.Rows[i].Cells[8].Value))
                        {
                            ekks = Convert.ToDouble(main_r_liste_datagrid.Rows[i].Cells[8].Value);
                            if (ekks.ToString() == DateTime.Now.Hour.ToString() + "," + DateTime.Now.Minute.ToString())
                            {
                                MessageBox.Show("Sıradaki Randevu : " + main_r_liste_datagrid.Rows[i].Cells[1].Value.ToString() + " " + main_r_liste_datagrid.Rows[i].Cells[2].Value.ToString());
                            }
                        }
                    }
                }
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablodoldur();
        }

        private void timer_tablo_icin_Tick(object sender, EventArgs e)
        {

            //if (ekks == 99.99)
            //{
                
            //    label3.Text = (kayitsayisi).ToString();
            //    if ( kayitsayisi  > 0)
             
            //    {
            //        for (int i = 0; i < kayitsayisi ; i++)
            //        {
            //            if (ekks > Convert.ToDouble(main_r_liste_datagrid.Rows[i].Cells[8].Value))
            //            {
            //                ekks = Convert.ToDouble(main_r_liste_datagrid.Rows[i].Cells[8].Value);
            //                label4.Text = DateTime.Now.Hour.ToString() + "," + DateTime.Now.Minute.ToString()+"," +DateTime.Now.Second.ToString();
            //                label5.Text = ekks.ToString();

            //                if ( ekks.ToString()== DateTime.Now.Hour.ToString() + "," + DateTime.Now.Minute.ToString())
            //                {
            //                    MessageBox.Show("Sıradaki Randevu : " + main_r_liste_datagrid.Rows[i].Cells[1].Value.ToString() + " " + main_r_liste_datagrid.Rows[i].Cells[2].Value.ToString());
            //                }
            //            }

                        
            //        }
            //    }
            //}

                
            
            

        }
    }
    }

