using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Stunting_ITPM
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Ada kolom yang belum diisi, mohon diisi terlebih dahulu dengan data yang sesuai");
            }
            else
            {
                if (textBox_username.Text != "tes" || textBox_password.Text != "123")
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
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.Visible = true;
            panel_pilih.Visible = false;
        }

        private void pictureBox_ortuAnak_Click(object sender, EventArgs e)
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

        private void button_lanjutPilih_Click(object sender, EventArgs e)
        {
            /*if(radioButton_mengandung.Checked != true && radioButton_ortuAnak.Checked != true)
            {
                MessageBox.Show("Silahkan pilih kategori yang cocok terlebih dahulu sebelum lanjut");
            }
            else
            {
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
                else
                {
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.BringToFront();
                    panel_inputMengandung.Visible = true;
                    panel_pilih.Visible = false;
                }
            }*/

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
            if ((textBox_umurTahun.Text == "" && textBox_umurBulan.Text == "") || (radioButton_lakiLaki.Checked == false && radioButton_perempuan.Checked == false) || (textBox_beratKg.Text == "" && textBox_panjangBayi.Text == ""))
            {
                MessageBox.Show("Ada data yang belum diisi. Mohon isi dulu semua data yang ada lalu lanjut ke tahap berikutnya");
            }
            else
            {
                float umur, beratBadan, tinggiBadan;
                float imt;
                beratBadan = float.Parse(textBox_beratKg.Text);
                tinggiBadan = float.Parse(textBox_panjangBayi.Text) / 100;
                if (textBox_umurBulan.Text == "")
                {
                    textBox_umurBulan.Text = "0";
                }
                if (textBox_umurTahun.Text == "")
                {
                    textBox_umurTahun.Text = "0";
                }
                int umurTahun = Convert.ToInt32(textBox_umurTahun.Text);
                umur = (umurTahun * 12) + Convert.ToInt32(textBox_umurBulan.Text);
                imt = beratBadan / (tinggiBadan * tinggiBadan);

                if (umur == 0)
                {
                    if (imt <= 11.1 || imt >= 16.3)
                    {
                        panel_anakStunting.BringToFront();
                        panel_anakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;

                    }
                    else
                    {
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;
                    }
                }
                else if (umur == 1)
                {
                    if (imt <= 12.4 || imt >= 17.8)
                    {
                        panel_anakStunting.BringToFront();
                        panel_anakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;

                    }
                    else
                    {
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;
                    }
                }
                else if (umur == 2)
                {
                    if (imt <= 13.7 || imt >= 19.4)
                    {
                        panel_anakStunting.BringToFront();
                        panel_anakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;

                    }
                    else
                    {
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;
                    }
                }
                else if (umur >= 3 || umur < 16)
                {
                    if (imt <= 14.3 || imt >= 20.0)
                    {
                        panel_anakStunting.BringToFront();
                        panel_anakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;

                    }
                    else
                    {
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;
                    }
                }
                else if (umur >= 16 || umur < 24)
                {
                    if (imt <= 13.6 || imt >= 19.1)
                    {
                        panel_anakStunting.BringToFront();
                        panel_anakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;

                    }
                    else
                    {
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;
                    }
                }
                else if (umur >= 24 || umur <= 54)
                {
                    if (imt <= 13.5 || imt >= 18.5)
                    {
                        panel_anakStunting.BringToFront();
                        panel_anakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;

                    }
                    else
                    {
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;
                    }
                }
                else if (umur >= 55 || umur <= 60)
                {
                    if (imt <= 12.9 || imt >= 18.2)
                    {
                        panel_anakStunting.BringToFront();
                        panel_anakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;

                    }
                    else
                    {
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.BringToFront();
                        panel_anakTidakStunting.Visible = true;
                        panel_inputOrtuAnak.Visible = false;
                    }
                }
            }
        }

        private void button_lanjutMengandung_Click(object sender, EventArgs e)
        {
            if ((radioButton_tidakMerokok.Checked == false && radioButton_yaMerokok.Checked == false) || (radioButton_yaAlkohol.Checked == false && radioButton_tidakAlkohol.Checked == false) || (radioButton_tidakBuah.Checked == false && radioButton_yaBuah.Checked == false) || (radioButton_tidakSayur.Checked == false && radioButton_yaSayur.Checked == false) || (radioButton_tidakVitamin.Checked == false && radioButton_yaVitamin.Checked == false) || (radioButton_tidakStress.Checked == false && radioButton_yaStress.Checked == false))
            {
                MessageBox.Show("Ada data yang belum diisi. Mohon isi dulu semua data yang ada lalu lanjut ke tahap berikutnya");
            }
            else
            {
                if (radioButton_yaMerokok.Checked == true || radioButton_yaAlkohol.Checked == true || radioButton_yaStress.Checked == true)
                {
                    panel_janinTidakSehat.BringToFront();
                    panel_janinTidakSehat.Visible = true;
                    panel_inputMengandung.Visible = false;
                }
                else
                {
                    panel_janinSehat.BringToFront();
                    panel_janinSehat.BringToFront();
                    panel_janinSehat.BringToFront();
                    panel_janinSehat.BringToFront();
                    panel_janinSehat.Visible = true;
                    panel_inputMengandung.Visible = false;
                }
            }
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_lanjutkanJaninSehat_Click(object sender, EventArgs e)
        {
            panel_solusiJaninSehat.BringToFront();
            panel_solusiJaninSehat.Visible = true;
            panel_janinSehat.Visible = false;
        }

        private void pictureBox_backAnakStunting_Click(object sender, EventArgs e)
        {
            panel_inputOrtuAnak.BringToFront();
            panel_inputOrtuAnak.Visible = true;
            panel_anakStunting.Visible = false;
        }

        private void button_lanjutAnakStunting_Click(object sender, EventArgs e)
        {
            panel_solusiAnakStunting.BringToFront();
            panel_solusiAnakStunting.Visible = true;
            panel_anakStunting.Visible = false;
        }

        private void button_menuAwalJaninTidakSehat_Click(object sender, EventArgs e)
        {
            panel_pilih.BringToFront();
            panel_pilih.Visible = true;
            panel_solusijaninTidakSehat.Visible = false;
        }

        private void button_tentangAplikasiJaninTidakSehat_Click(object sender, EventArgs e)
        {
            panel_tentangAplikasi.BringToFront();
            panel_tentangAplikasi.Visible = true;
            panel_solusijaninTidakSehat.Visible = false;
        }

        private void button_menuAwalAnakSehat_Click(object sender, EventArgs e)
        {
            panel_pilih.BringToFront();
            panel_pilih.Visible = true;
            panel_solusijaninTidakSehat.Visible = false;
        }

        private void button_tentangAplikasiAnakSehat_Click(object sender, EventArgs e)
        {
            panel_tentangAplikasi.BringToFront();
            panel_tentangAplikasi.Visible = true;
            panel_solusiAnakSehat.Visible = false;
        }

        private void pictureBox_backSolusiAnakSehat_Click(object sender, EventArgs e)
        {
            panel_inputOrtuAnak.BringToFront();
            panel_inputOrtuAnak.Visible = true;
            panel_solusiAnakSehat.Visible = false;
        }

        private void pictureBox_backSolusiJaninTidakSehat_Click(object sender, EventArgs e)
        {
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.Visible = true;
            panel_solusijaninTidakSehat.Visible = false;
        }

        private void pictureBox_backSolusiAnakStunting_Click(object sender, EventArgs e)
        {
            panel_inputOrtuAnak.BringToFront();
            panel_inputOrtuAnak.Visible = true;
            panel_solusiAnakStunting.Visible = false;
        }

        private void button_menuAwalAnakStunting_Click(object sender, EventArgs e)
        {
            panel_pilih.BringToFront();
            panel_pilih.Visible = true;
            panel_solusiAnakStunting.Visible = false;
        }

        private void button_tentangAplikasiAnakStunting_Click(object sender, EventArgs e)
        {
            panel_tentangAplikasi.BringToFront();
            panel_tentangAplikasi.Visible = true;
            panel_solusiAnakStunting.Visible = false;
        }

        private void button_menuAwalTentangAplikasi_Click(object sender, EventArgs e)
        {
            panel_pilih.BringToFront();
            panel_pilih.Visible = true;
            panel_tentangAplikasi.Visible = false;
        }

        private void pictureBox_backTentangAplikasi_Click(object sender, EventArgs e)
        {

        }

        private void button_tentangAplikasiSolusiJaninSehat_Click(object sender, EventArgs e)
        {
            panel_tentangAplikasi.BringToFront();
            panel_tentangAplikasi.Visible = true;
            panel_solusiJaninSehat.Visible = false;
        }

        private void button_menuAwalSolusiJaninSehat_Click(object sender, EventArgs e)
        {
            panel_pilih.BringToFront();
            panel_pilih.Visible = true;
            panel_solusiJaninSehat.Visible = false;
        }

        private void pictureBox_backSolusiJaninSehat_Click(object sender, EventArgs e)
        {
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.Visible = true;
            panel_solusiJaninSehat.Visible = false;
        }

        private void pictureBox_backJaninTidakSehat_Click(object sender, EventArgs e)
        {
            panel_inputMengandung.BringToFront();
            panel_inputMengandung.Visible = true;
            panel_janinTidakSehat.Visible = false;
        }

        private void button_lanjutJaninTidakSehat_Click(object sender, EventArgs e)
        {
            panel_solusijaninTidakSehat.BringToFront();
            panel_solusijaninTidakSehat.Visible = true;
            panel_janinTidakSehat.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_solusiAnakSehat.BringToFront();
            panel_solusiAnakSehat.Visible = true;
            panel_anakTidakStunting.Visible = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_registrasiPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_registrasiPassword.Checked == true)
            {
                textBox_registrasiPassword.PasswordChar = '\0';
            }
            else
            {
                textBox_registrasiPassword.PasswordChar = '*';
            }
        }

        private void button_registrasiDaftar_Click(object sender, EventArgs e)
        {
            if (textBox_registrasiNama.Text.Length == 0 || textBox_registrasiUsername.Text.Length == 0 || textBox_registrasiAlamat.Text.Length == 0 || textBox_registrasiNomorTelepon.Text.Length == 0 || textBox_registrasiPassword.Text.Length == 0 || (radioButton_registrasiLakilaki.Checked == false && radioButton_registrasiPerempuan.Checked == false))
            {
                MessageBox.Show("Ada data yang belum diisi, silahkan isi dulu dengan data yang sesuai");
            }
            else
            {
                MessageBox.Show("Data anda berhasil disimpan. Silahkan login");
                panel_login.BringToFront();
                panel_login.Visible = true;
                panel_registrasi.Visible = false;
            }
        }

        private void pictureBox_backRegistrasi_Click(object sender, EventArgs e)
        {
            panel_login.BringToFront();
            panel_login.Visible = true;
            panel_registrasi.Visible = false;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            panel_registrasi.BringToFront();
            panel_registrasi.Visible = true;
            panel_login.Visible = false;
        }

        private void textBox_registrasiNomorTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_umurTahun_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            int value;
            if (int.TryParse(textbox.Text, out value))
            {
                if (value > 5)
                    textbox.Text = "5";
                else if (value < 0)
                    textbox.Text = "0";
            }
        }

        private void textBox_umurBulan_TextChanged(object sender, EventArgs e)
        {
            if(textBox_umurTahun.Text == "5")
            {
                var textbox = sender as TextBox;
                int value;
                if (int.TryParse(textbox.Text, out value))
                {
                    if (value > 0)
                        textbox.Text = "0";
                    else if (value < 0)
                        textbox.Text = "0";
                }
            }
            else
            {
                var textbox = sender as TextBox;
                int value;
                if (int.TryParse(textbox.Text, out value))
                {
                    if (value > 12)
                        textbox.Text = "12";
                    else if (value < 0)
                        textbox.Text = "0";
                }
            }
        }

        private void textBox_umurTahun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_umurBulan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_beratKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_panjangBayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_registrasiNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox_registrasiUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
