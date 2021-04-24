using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form_Authorization : Form
    {
        public string login = "login1";

        public Form_Authorization()
        {
            InitializeComponent();
        }

        private void checkBox_Pas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Pas.Checked == true)
                maskedTextBox_Pas.PasswordChar = '\0';
            else maskedTextBox_Pas.PasswordChar = '*';
        }

        private void button_Authorization_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(textBox_Login.Text) || (string.IsNullOrWhiteSpace(textBox_Login.Text)) ||
                    (string.IsNullOrEmpty(maskedTextBox_Pas.Text) || (string.IsNullOrWhiteSpace(maskedTextBox_Pas.Text)))))
                    throw new Exception("Полькователя не существует");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста заполните все поля");
                return;
            }

            try
            {
                if (textBox_Login.Text == login && maskedTextBox_Pas.Text == "tuptup")
                {
                    Form f_M = new Forms.Form_Manager(login);
                    f_M.Owner = this;
                    f_M.Show();
                }
                else throw new Exception("Полькователя не существует");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильный логин или пороль");
                return;
            }
            this.Hide();
        }

        private void Form_Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
