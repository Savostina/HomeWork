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
    public partial class FormCreatingOrder : Form
    {
        public FormCreatingOrder()
        {
            InitializeComponent();
        }

        private void buttonArrange_Click(object sender, EventArgs e)
        {

            try
            {
                if ((string.IsNullOrEmpty(textBoxClientName.Text) || (string.IsNullOrWhiteSpace(textBoxClientName.Text)) ||
                    (string.IsNullOrEmpty(textBoxClientLName.Text) || (string.IsNullOrWhiteSpace(textBoxClientLName.Text)) ||
                    (string.IsNullOrEmpty(textBoxMClientName.Text) || (string.IsNullOrWhiteSpace(textBoxMClientName.Text)) ||
                    (string.IsNullOrEmpty(textBoxPrice.Text) || (string.IsNullOrWhiteSpace(textBoxPrice.Text)) ||
                    (string.IsNullOrEmpty(textBoxName.Text) || (string.IsNullOrWhiteSpace(textBoxName.Text)) ||
                    (string.IsNullOrEmpty(textBoxProduct.Text) || (string.IsNullOrWhiteSpace(textBoxProduct.Text)))))))))
                    throw new Exception();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new Entity.EntityCodeFirst())
                {
                    context.UserData.Add(
                       new Entity.UserData()
                       {
                           id = 0,
                           firstname = textBoxClientName.Text,
                           lastname = textBoxClientLName.Text,
                           middlename = textBoxMClientName.Text,
                       });
                    context.SaveChanges();
                    context.Orders.Add(
                       new Entity.Orders()
                       {
                           id = 0,
                           name = textBoxName.Text,
                       });
                    context.SaveChanges();
                    context.Product.Add(
                       new Entity.Product()
                       {
                           id = 0,
                           name = textBoxProduct.Text,
                           price = Convert.ToDecimal(textBoxPrice.Text)
                       });
                    context.SaveChanges();
                }
                MessageBox.Show("Заказ успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Произошла ошибка добавления информации в базу данных проверьте вводимые данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
