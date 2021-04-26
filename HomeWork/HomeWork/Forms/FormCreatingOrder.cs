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
                   }) ;
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
        }

    }
}
