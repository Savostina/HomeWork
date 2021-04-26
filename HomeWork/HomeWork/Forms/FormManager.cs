﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork.Forms
{
    public partial class FormManager : Form
    {
        private string login;

        public FormManager(string login)
        {
            InitializeComponent();

            this.login = login;

            pictureBoxavatar.Image = Properties.Resources.profile_icon_183860;
            label_Login.Text = "@" + login;

            using (Entity.EntityCodeFirst context = new Entity.EntityCodeFirst())
            {
                var user = Class.UserSingleton.GetUser();


                var selecteduser = context.User.FirstOrDefault(_user => (_user.id == _user.id));
                labelName.Text = user.GetFirstName() +" "+ user.GetLastName() +" "+ user.GetMiddleName();


            }

        }


        private void FormManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) this.Owner.Show();
            //Application.Exit();
        }

        private void buttonCreatingOrder_Click(object sender, EventArgs e)
        {
            Form f_CO = new Forms.FormCreatingOrder();
            f_CO.ShowDialog();
        }
    }
}
