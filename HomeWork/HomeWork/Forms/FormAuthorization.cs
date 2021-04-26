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
    public partial class FormAuthorization : Form
    {

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void checkBoxPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPas.Checked == true)
                maskedTextBoxPas.PasswordChar = '\0';
            else maskedTextBoxPas.PasswordChar = '*';
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            using (Entity.EntityCodeFirst context = new Entity.EntityCodeFirst()) 
            {
                string login = textBoxLogin.Text;
                string password = maskedTextBoxPas.Text;

                var user = context.User.FirstOrDefault(_user => (_user.login == login && _user.password == password));

                try
                {
                    if ((string.IsNullOrEmpty(textBoxLogin.Text) || (string.IsNullOrWhiteSpace(textBoxLogin.Text)) ||
                        (string.IsNullOrEmpty(maskedTextBoxPas.Text) || (string.IsNullOrWhiteSpace(maskedTextBoxPas.Text)))))
                        throw new Exception();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Пожалуйста заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    if (user != null)
                    {
                        var userData = context.UserData.FirstOrDefault(_userData => (_userData.id == user.ud_id));
                        Class.UserSingleton.FromDatabase(user, userData);
                        Form f_M = new Forms.FormManager(login);
                        f_M.Owner = this;
                        f_M.Show();
                    }
                    else throw new Exception();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неправильный логин или пороль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Hide();
            } 
        }

        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
