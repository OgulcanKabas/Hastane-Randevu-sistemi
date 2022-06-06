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
    public partial class Login : Form
    {
        int Move;
        int Mouse_X;
        int Mouse_Y;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=hastane;user=root;Pwd=;");
        }

        public static long giris_id;
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Yönetici")
            {
                string user = txt_tc.Text;
                string pass = txt_sifre.Text;
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM yonetici where tc='" + txt_tc.Text + "' AND sifre='" + txt_sifre.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    giris_id = Convert.ToInt64(txt_tc.Text);
                        Yonetici form2sec = new Yonetici();
                    form2sec.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                }
                con.Close();
            }

            if (comboBox1.Text == "Doktor")
            {
                string user = txt_tc.Text;
                string pass = txt_sifre.Text;
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM doktor where tc='" + txt_tc.Text + "' AND sifre='" + txt_sifre.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    giris_id = Convert.ToInt64( txt_tc.Text);
                    doktor_paneli_form doctorpanel = new doktor_paneli_form();
                    doctorpanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                }
                con.Close();
            }

            if (comboBox1.Text == "Danışman")
            {
                string user = txt_tc.Text;
                string pass = txt_sifre.Text;
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM danısman where tc='" + txt_tc.Text + "' AND sifre='" + txt_sifre.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    giris_id = Convert.ToInt64(txt_tc.Text);
                    danısman_panel danismanpanel = new danısman_panel();
                    danismanpanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                }
                con.Close();
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Doktor");
            comboBox1.Items.Add("Danışman");
            comboBox1.Items.Add("Yönetici");

            
         


        }

        private void bunifuGradientPanel4_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void bunifuGradientPanel4_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void bunifuGradientPanel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void txt_sifre_OnValueChanged(object sender, EventArgs e)
        {
            txt_sifre.isPassword = true;
        }
    }
}
