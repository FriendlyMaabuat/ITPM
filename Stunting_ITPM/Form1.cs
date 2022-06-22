using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stunting_ITPM
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked == true)
            {
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '*';
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text != "tes" || textBox_password.Text != "123")
            {
                MessageBox.Show("Username atau password yang dimasukkan salah");
            }
            else
            {
                panel_pilih.Visible = true;
                panel_pilih.BringToFront();
                panel_login.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*listPanel.Add(panel_login);
            listPanel.Add(panel_pilih);
            listPanel.Add(panel_inputMengandung);
            listPanel[index].BringToFront();*/
            panel_pilih.Visible = false;
            panel_inputMengandung.Visible = false;
            panel_inputMengandung.Visible = false;
            panel_inputOrtuAnak.Visible = false;
            panel_anakTidakStunting.Visible = false;
            panel_janinSehat.Visible = false;
            panel_login.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            /*if (index > 0)
                listPanel[--index].BringToFront();*/
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton_mengandung.Checked = true;
        }

        private void pictureBox_ortuAnak_Click(object sender, EventArgs e)
        {
            radioButton_ortuAnak.Checked = true;
        }

        private void button_lanjutPilih_Click(object sender, EventArgs e)
        {
            if(radioButton_mengandung.Checked != true && radioButton_ortuAnak.Checked != true)
            {
                MessageBox.Show("Silahkan pilih kategori yang cocok terlebih dahulu sebelum lanjut");
            }
            else
            {
                if(radioButton_mengandung.Checked == true)
                {
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.Visible = true;
                    panel_pilih.Visible = false;
                }
                if(radioButton_ortuAnak.Checked == true)
                {
                    panel_inputOrtuAnak.BringToFront();
                    panel_inputOrtuAnak.BringToFront();
                    panel_inputOrtuAnak.BringToFront();
                    panel_inputOrtuAnak.BringToFront();
                    panel_inputOrtuAnak.BringToFront();
                    panel_inputOrtuAnak.BringToFront();
                    panel_inputOrtuAnak.BringToFront();
                    panel_inputOrtuAnak.BringToFront();
                    panel_inputOrtuAnak.Visible = true;
                    panel_pilih.Visible = false;
                }
            }

        }

        private void pictureBox_backInputMengandung_Click(object sender, EventArgs e)
        {
            panel_pilih.BringToFront();
            panel_pilih.Visible = true;
            panel_inputMengandung.Visible = false;
        }

        private void pictureBox_backInputPilih_Click(object sender, EventArgs e)
        {
            panel_login.BringToFront();
            panel_login.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button_lanjutInputOrtuAnak_Click(object sender, EventArgs e)
        {
            panel_anakTidakStunting.BringToFront();
            panel_anakTidakStunting.BringToFront();
            panel_anakTidakStunting.Visible = true;
            panel_inputOrtuAnak.Visible = false;
        }

        private void button_lanjutMengandung_Click(object sender, EventArgs e)
        {
            panel_janinSehat.BringToFront();
            panel_janinSehat.BringToFront();
            panel_janinSehat.Visible = true;
            panel_inputMengandung.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel_pilih.BringToFront();
            panel_pilih.BringToFront();
            panel_pilih.Visible = true;
            panel_inputOrtuAnak.Visible = false;
        }

        private void button_resetInputOrtuAnak_Click(object sender, EventArgs e)
        {
            textBox_umurTahun.Clear();
            textBox_umurBulan.Clear();
            textBox_lingkarKepala.Clear();
            textBox_beratKg.Clear();
            textBox_panjangBayi.Clear();
            radioButton_perempuan.Checked = false;
            radioButton_lakiLaki.Checked = false;
        }

        private void pictureBox_backJaninSehat_Click(object sender, EventArgs e)
        {
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.Visible = true;
            panel_janinSehat.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel_inputOrtuAnak.BringToFront();
            panel_inputOrtuAnak.BringToFront();
            panel_inputOrtuAnak.Visible = true;
            panel_anakTidakStunting.Visible = false;
        }

        private void panel_inputOrtuAnak_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_janinSehat_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
