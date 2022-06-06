using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace Login
{
    public partial class danısman_panel : Form
    {
        public danısman_panel()
        {
            InitializeComponent();
        }
        PrintDialog PRD = new PrintDialog();

        MySqlConnection mysqlbaglan = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");

        MySqlConnection connec = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlConnection connec2 = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        DataTable tab = new DataTable();
        MySqlDataAdapter baglayan = new MySqlDataAdapter();

        MySqlDataReader dr;
        MySqlConnection baglans = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        DataTable tablodeneme = new DataTable();
        


        MySqlConnection baglan = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlDataAdapter baglayici = new MySqlDataAdapter();
        MySqlCommand kmt = new MySqlCommand();
        DataTable tablo = new DataTable();

        MySqlConnection baglan1 = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlCommand kmt1 = new MySqlCommand();

        MySqlConnection mysqlbaglan1 = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlDataReader dr1;
        MySqlDataAdapter baglayici1 = new MySqlDataAdapter();
        DataTable tablo1 = new DataTable();

        MySqlConnection baglanx = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlDataAdapter baglayicix = new MySqlDataAdapter();
        MySqlCommand kmtx = new MySqlCommand();
        DataTable tablox = new DataTable();

        MySqlConnection baglany = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlCommand kmty = new MySqlCommand();
        MySqlDataAdapter baglayiciy = new MySqlDataAdapter();

        // aldığım anlamsız bir hatadan dolayı bu kadar connection nesnesi var her işlem için ayrı bir connection kullanıldı. Programın en kötü kısmı olabilir belkide :/ 

        string tc, ad, soyad, polad, ransaati;
        private void btn_fis_kes_Click(object sender, EventArgs e)
        {
             

            int secilen = main_r_liste_datagrid.SelectedCells[0].RowIndex;
            tc = main_r_liste_datagrid.Rows[secilen].Cells[3].Value.ToString();
            ad = main_r_liste_datagrid.Rows[secilen].Cells[1].Value.ToString();
            soyad = main_r_liste_datagrid.Rows[secilen].Cells[2].Value.ToString();
            polad = main_r_liste_datagrid.Rows[secilen].Cells[5].Value.ToString();
            ransaati = main_r_liste_datagrid.Rows[secilen].Cells[8].Value.ToString();

            PrintDocument Kagit = new PrintDocument();
            DialogResult yazdirmaislemi;
            yazdirmaislemi = PRD.ShowDialog();
            Kagit.PrintPage += printDocument1_PrintPage;
            if (yazdirmaislemi == DialogResult.OK)
            {
                Kagit.Print();
            }

            fisonay();

            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            Font font = new Font("Arial", 12);
            SolidBrush firca = new SolidBrush(Color.Black);
            
            e.Graphics.DrawString($"Tarih:  {DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 50);
            e.Graphics.DrawString($"TC:  {tc}", font, firca, 50, 75);
            e.Graphics.DrawString($"AD:  {ad}", font, firca, 50, 100);
            e.Graphics.DrawString($"SOYAD:  {soyad}", font, firca, 50, 125);
            e.Graphics.DrawString($"POLİKLİNİK:  {polad}", font, firca, 50, 175);
            e.Graphics.DrawString($"RANDEVU SAATİ:  {ransaati}", font, firca, 50, 200);
            


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        private void fisonay() {
            string sqlsorgusu1 = "Update randevular set fis_durum=1 where id='" + main_r_liste_datagrid.CurrentRow.Cells[0].Value + "'";
            DataTable tablo1 = new DataTable();

            kmt1.CommandText = sqlsorgusu1;
            kmt1.Connection = baglan1;

            baglayici1.SelectCommand = kmt1;
            baglan1.Open();
            baglayici1.Fill(tablo1);
            baglan1.Close();

            this.main_r_liste_datagrid.DataSource = tablo1;

            tablodoldur();

        }
        private void main_r_liste_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void danısman_panel_Load(object sender, EventArgs e)
        {


            
            mysqlbaglan1.Open();
            MySqlCommand komut1 = new MySqlCommand();           
            komut1.CommandText = "SELECT *FROM danisman where tc='" + Login.giris_id + "'";
            komut1.Connection = mysqlbaglan1;
            komut1.CommandType = CommandType.Text;
            dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                
                label1.Text = dr1["ad"].ToString() + " " + dr1["soyad"].ToString();
                string sqlsorgusu = "Select distinct randevular.id as 'Sıra', randevular.ad as 'Hasta Adı' ,randevular.soyad as 'Hasta Soyadı',randevular.tc as 'Hasta TC' ,randevular.e_posta as 'Hasta E-posta',randevular.r_pol_ad as 'Hasta Poliklinik Adı' ,randevular.r_pol_no as 'Hasta Poliklinik No ',randevular.r_tarihi as 'Randevu Tarihi', randevular.r_saat as 'Randevu Saati', randevular.fis_durum as 'Fiş' from randevular,danisman  where '" + dr1["pol1_ad"] + "' =randevular.r_pol_ad and '" + dr1["pol1_no"] + "' =randevular.r_pol_no and fis_durum=0 and randevular.r_durum=0 and r_tarihi = '" + dateTimePicker1.Text + "' ";
           
                kmt1.CommandText = sqlsorgusu;
                kmt1.Connection = baglan1;
                baglayici1.SelectCommand = kmt1;
                baglan1.Open();
                baglayici1.Fill(tablo1);
                baglan1.Close();
                this.main_r_liste_datagrid.DataSource = tablo1;
                baglan1.Close();
                if (dr1["fotograf"] != null)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dr1["fotograf"]);
                    MemoryStream mem = new MemoryStream(data);
                    pct_dnsmn_foto.Image = Image.FromStream(mem);
                    pct_dnsmn_foto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            mysqlbaglan1.Close();
        }
        private void tablodoldur()
        {
            tablo1.Clear();
            connec.Open();
            MySqlCommand command = new MySqlCommand();
            MySqlCommand comman1 = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT *FROM danisman where tc='" + Login.giris_id + "'";
            command.Connection = connec;
            MySqlDataReader datar;
            datar = command.ExecuteReader();


            if (cmb_rndv_durum.Text == "Bekleyen Randevular")
            {

                while (datar.Read())
                {

                    string sqlsorgusu = "Select distinct randevular.id as 'Sıra', randevular.ad as 'Hasta Adı' ,randevular.soyad as 'Hasta Soyadı',randevular.tc as 'Hasta TC' ,randevular.e_posta as 'Hasta E-posta',randevular.r_pol_ad as 'Hasta Poliklinik Adı' ,randevular.r_pol_no as 'Hasta Poliklinik No ',randevular.r_tarihi as 'Randevu Tarihi', randevular.r_saat as 'Randevu Saati' from randevular,danisman where fis_durum=0 and r_tarihi = '" + dateTimePicker1.Text.ToString() + "' and (('" + datar["pol1_ad"] + "' =randevular.r_pol_ad  and '" + datar["pol1_no"] + "' =randevular.r_pol_no) or ('" + datar["pol2_ad"] + "'=randevular.r_pol_ad and '" + datar["pol2_no"] + "'=randevular.r_pol_no) or ('" + datar["pol3_ad"] + "'=randevular.r_pol_ad  and '" + datar["pol3_no"] + "'=randevular.r_pol_no))";
                    tab.Clear();
                    comman1.CommandText = sqlsorgusu;
                    comman1.Connection = connec2;
                    baglayan.SelectCommand = comman1;
                    connec2.Open();
                    baglayan.Fill(tab);
                    connec2.Close();
                    this.main_r_liste_datagrid.DataSource = tab;

                }
            }

            if (cmb_rndv_durum.Text == "Fiş Kesilen Randevular")
            {
                while (datar.Read())
                {
                    string sqlsorgusu = "Select distinct randevular.id as 'Sıra', randevular.ad as 'Hasta Adı' ,randevular.soyad as 'Hasta Soyadı',randevular.tc as 'Hasta TC' ,randevular.e_posta as 'Hasta E-posta',randevular.r_pol_ad as 'Hasta Poliklinik Adı' ,randevular.r_pol_no as 'Hasta Poliklinik No ',randevular.r_tarihi as 'Randevu Tarihi', randevular.r_saat as 'Randevu Saati' from randevular,danisman where fis_durum=1 and r_tarihi = '" + dateTimePicker1.Text.ToString() + "' and (('" + datar["pol1_ad"] + "' =randevular.r_pol_ad  and '" + datar["pol1_no"] + "' =randevular.r_pol_no) or ('" + datar["pol2_ad"] + "'=randevular.r_pol_ad and '" + datar["pol2_no"] + "'=randevular.r_pol_no) or ('" + datar["pol3_ad"] + "'=randevular.r_pol_ad  and '" + datar["pol3_no"] + "'=randevular.r_pol_no))";
                    tab.Clear();
                    comman1.CommandText = sqlsorgusu;
                    comman1.Connection = connec2;
                    baglayan.SelectCommand = comman1;
                    connec2.Open();
                    baglayan.Fill(tab);
                    connec2.Close();
                    this.main_r_liste_datagrid.DataSource = tab;

                }
            }

            connec.Close();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (soru == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cmb_rndv_durum_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablodoldur();
        }
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablodoldur();
        }
    }
}
