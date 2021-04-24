using System;
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
    public partial class Form_Manager : Form
    {
        private string login;

        public Form_Manager(string login)
        {
            InitializeComponent();

            this.login = login;

            pictureBox_avatar.Image = Properties.Resources.profile_icon_183860;
            label_Login.Text = "@" + login;
        }


        private void Form_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Close();
        }

        private void button_CreatingOrder_Click(object sender, EventArgs e)
        {
            Form f_CO = new Forms.Form_CreatingOrder();
            f_CO.ShowDialog();
        }
    }
}
