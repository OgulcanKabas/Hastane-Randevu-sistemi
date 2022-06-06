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
    public partial class poliklinik_ekle : Form
    {

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=hastane;Uid=root;Pwd='';");
        DataTable table = new DataTable();
        MySqlCommand kmt = new MySqlCommand();
        public poliklinik_ekle()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();



        }

        private void poliklinik_ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text!="Bulunduğu Kat" && txt_p_ad.Text!="" && txt_p_no.Text!="" )
            {
                try
                {
                    mysqlbaglan.Open(); 
                    if (mysqlbaglan.State != ConnectionState.Closed) 
                    {
                        kmt.Connection = mysqlbaglan;

                        kmt.CommandText = (("INSERT INTO poliklinik(p_kat,p_no,p_ad) VALUES ('" + comboBox1.Text + "','") + txt_p_no.Text + "','") + txt_p_ad.Text+ "')";
                       
                        kmt.ExecuteNonQuery();
                        
                        MessageBox.Show("Kayıt İşlemi Başarılı");
                        comboBox1.Text = "Bulunduğu Kat";
                        txt_p_ad.Text = "";
                        txt_p_no.Text = "";
                        mysqlbaglan.Close();

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
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
                }
        }

        private void poliklinik_ekle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Zemin Kat");
            comboBox1.Items.Add("1.Kat");
            comboBox1.Items.Add("2.Kat");
            comboBox1.Items.Add("3.Kat");
            comboBox1.Items.Add("4.Kat");

        }

        private void txt_p_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
       


            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
    && !char.IsSeparator(e.KeyChar);
        }

        private void txt_p_no_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_p_no_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
