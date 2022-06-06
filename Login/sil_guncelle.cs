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

namespace Login
{
    public partial class sil_guncelle : Form
    {
        public sil_guncelle()
        {
            InitializeComponent();
        }
        MySqlConnection baglan = new MySqlConnection("Server=Localhost; Database=hastane; uid=root; Password=;");
        MySqlDataAdapter baglayici = new MySqlDataAdapter();
        MySqlCommand komut = new MySqlCommand();

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection mysqlbaglan2 = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        public MySqlConnection mysqlbaglan3 = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        DataTable table = new DataTable();
        MySqlCommand kmt = new MySqlCommand();
        MySqlCommand kmt2 = new MySqlCommand();
        MySqlCommand kmt3 = new MySqlCommand();



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
               
        }

        private void sil_guncelle_Load(object sender, EventArgs e)
        {



            comboBox5.Text = "Doktorlar";
            comboBox5.Items.Add("Doktorlar");
            comboBox5.Items.Add("Danışmanlar");
            comboBox5.Items.Add("Poliklinikler");
            if (comboBox5.Text == "Doktorlar")
            {
                string sqlsorgusu = "Select * from doktor";
                DataTable tablo = new DataTable();

                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;
                baglan.Open();
                baglayici.Fill(tablo);
                baglan.Close();
                this.tablo.DataSource = tablo;

                mysqlbaglan.Open();
                MySqlCommand komutt = new MySqlCommand();

                MySqlDataReader dr;
                komutt.CommandText = "SELECT *FROM poliklinik";
                komutt.Connection = mysqlbaglan;
                komutt.CommandType = CommandType.Text;




                dr = komutt.ExecuteReader();
                while (dr.Read())
                {



                }

                mysqlbaglan.Close();

            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (comboBox5.Text == "Doktorlar")
                {
                    string sqlsorgusu = "Select * from doktor";
                    DataTable tablo = new DataTable();

                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;
                    baglan.Open();
                    baglayici.Fill(tablo);
                    baglan.Close();
                    this.tablo.DataSource = tablo;


                }
                if (comboBox5.Text == "Danışmanlar")
                {
                    string sqlsorgusu = "Select * from danısman";
                    DataTable tablo = new DataTable();

                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;
                    baglan.Open();
                    baglayici.Fill(tablo);
                    baglan.Close();
                    this.tablo.DataSource = tablo;

                }
                if (comboBox5.Text == "Poliklinikler")
                {
                    string sqlsorgusu = "Select * from poliklinik";
                    DataTable tablo = new DataTable();

                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;
                    baglan.Open();
                    baglayici.Fill(tablo);
                    baglan.Close();
                    this.tablo.DataSource = tablo;

                }


            }
        }
        
        private void tablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void tablo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox5.Text == "Doktorlar")
            {
                int secilen = tablo.SelectedCells[0].RowIndex;
                
                txt_doktor_ad.Text = tablo.Rows[secilen].Cells[1].Value.ToString();
                txt_doktor_soyad.Text = tablo.Rows[secilen].Cells[2].Value.ToString();
                txt_doktor_eposta.Text = tablo.Rows[secilen].Cells[9].Value.ToString();
            }
            if (comboBox5.Text=="Danışmanlar")
            {
                int secilen = tablo.SelectedCells[0].RowIndex;
                txt_doktor_ad.Text = tablo.Rows[secilen].Cells[2].Value.ToString();
                txt_doktor_soyad.Text = tablo.Rows[secilen].Cells[3].Value.ToString();
                txt_doktor_eposta.Text = tablo.Rows[secilen].Cells[12].Value.ToString();

            }
            if (comboBox5.Text=="Poliklinikler")
            {
                int secilen = tablo.SelectedCells[0].RowIndex;
                txt_doktor_ad.Text = tablo.Rows[secilen].Cells[1].Value.ToString();
                txt_doktor_soyad.Text = tablo.Rows[secilen].Cells[2].Value.ToString();
                txt_doktor_eposta.Text = tablo.Rows[secilen].Cells[3].Value.ToString();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Doktorlar")
            {
                int secilen = tablo.SelectedCells[0].RowIndex;
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = con;
                comm.CommandText="update doktor set ad='" + txt_doktor_ad.Text + "',soyad='"+ txt_doktor_soyad.Text + "',eposta='"+ txt_doktor_eposta.Text + "' where='"+ tablo.Rows[secilen].Cells[0].Value.ToString() +"'";
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();

            }
            if (comboBox5.Text == "Danışmanlar")
            {
                int secilen = tablo.SelectedCells[0].RowIndex;
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = con;
                comm.CommandText = "update danisman set ad='" + txt_doktor_ad.Text + "',soyad='" + txt_doktor_soyad.Text + "',e_posta='" + txt_doktor_eposta.Text + "' where='" + tablo.Rows[secilen].Cells[0].Value.ToString() + "'";
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();

            }
            if (comboBox5.Text == "Poliklinikler")
            {
                int secilen = tablo.SelectedCells[0].RowIndex;
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = con;
                comm.CommandText = "update poliklinik set p_kat='" + txt_doktor_ad.Text + "',p_no='" + txt_doktor_soyad.Text + "',p_ad='" + txt_doktor_eposta.Text + "' where='" + tablo.Rows[secilen].Cells[0].Value.ToString() + "'";
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
