using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class mailgonder_form : Form
    {
        public mailgonder_form()
        {
            InitializeComponent();
        }

        string DosyaYolu;
        MySqlCommand komut = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi
        MySqlCommand komut2 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi
        MySqlCommand komut3 = new MySqlCommand();//işlemlerimiz içinde bir komut nesnesi
        public MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection baglan2 = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        MySqlDataAdapter baglayici = new MySqlDataAdapter();
        MySqlDataAdapter baglayici2 = new MySqlDataAdapter();
        public void temizle()
        {
            txt_gonderilenmesaj.Text = "";
            txt_mail_konu.Text = "";
            txt_mailadres_sifrem.Text = "";
            txt_mail_adresim.Text = "";
            DosyaYolu = "";
            cmb_mailtoadd.Text = "";

        }
           
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (DosyaYolu==null)
            {
                DosyaYolu = Application.StartupPath.ToString() + "\\dt_img\\doctor\\hospital.jpg";
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                string kime = cmb_mailtoadd.Text;
                string konu = txt_mail_konu.Text;
                string icerik = txt_gonderilenmesaj.Text;

                sc.Credentials = new NetworkCredential(txt_mail_adresim.Text, txt_mailadres_sifrem.Text);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("hastanadeneme@gmail.com", "Halil Kazan");
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                mail.Attachments.Add(new Attachment(DosyaYolu));
                sc.Send(mail);
                MessageBox.Show("Mail Gönderildi");
                temizle();
            }
            else
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                string kime = cmb_mailtoadd.Text;
                string konu = txt_mail_konu.Text;
                string icerik = txt_gonderilenmesaj.Text;

                sc.Credentials = new NetworkCredential(txt_mail_adresim.Text, txt_mailadres_sifrem.Text);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("hastanadeneme@gmail.com", "Halil Kazan");
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                mail.Attachments.Add(new Attachment(DosyaYolu));
                sc.Send(mail);
                MessageBox.Show("Mail Gönderildi");
                temizle();
            }
  


  
           
        }

        private void btn_dosyayukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "Dosya Seç";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            lbl_dosya.Text = "Dosya Eklendi";
        }

        private void mailgonder_form_Load(object sender, EventArgs e)
        {
            
            baglan2.Open();
            DataTable tablo1 = new DataTable();
            string sqlsorgusu1 = "Select alan,pol_no from doktor where tc='"+Login.giris_id+"'";
            komut3.CommandText = sqlsorgusu1;
            komut3.Connection = baglan2;
            MySqlDataReader polnoad;
            polnoad = komut3.ExecuteReader();
            while (polnoad.Read())
            {
                DataTable tablo = new DataTable();
                string sqlsorgusu = "Select distinct randevular.ad as Hasta_Adı,randevular.soyad as Hasta_Soyadı,randevular.tc as Hasta_TC,randevular.e_posta as Hasta_ePosta,randevular.r_pol_ad as Randevu_Pol_Adı,randevular.r_pol_no as Randevu_Pol_No,randevular.r_tarihi as Randevu_Tarihi,randevular.r_durum as İşlem from doktor,randevular where '" + polnoad["alan"] + "'=randevular.r_pol_ad and '" + polnoad["pol_no"] + "'=randevular.r_pol_no";
                komut2.CommandText = sqlsorgusu;
                komut2.Connection = baglan;

                baglayici.SelectCommand = komut2;
                baglan.Open();
                baglayici.Fill(tablo);
                baglan.Close();
                this.bunifuCustomDataGrid1.DataSource = tablo;
            }
        }

        
        

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            cmb_mailtoadd.Text = bunifuCustomDataGrid1.Rows[secilen].Cells[3].Value.ToString();
        }
    }
}
