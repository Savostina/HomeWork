using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Entity;

namespace HomeWork.Forms
{

    public partial class FormManager : Form
    {
        private string login;

        private BindingList<dataGridItem> db;



        public FormManager(string login)
        {
            InitializeComponent();
            dataGridView.DataSource = null;
            db = new BindingList<dataGridItem>();

            InitDataGrid();

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

        private void InintUsers(BindingList<dataGridItem> items)
        {

            var list = new List<dataGridItem>();
            using (var context = new Entity.EntityCodeFirst())
            {
                foreach (var client in context.Client)
                {
                    foreach (var _userData in context.UserData)
                    {

                        var userDate = context.UserData.FirstOrDefault(_client => (_client.id == client.ud_id));
                        var order = context.Orders.FirstOrDefault(_order=>(_order.client_id == client.id));

                        var products = new List<Product>();
                        foreach (var productId in context.OrdersHasProduct)
                        {
                            if (productId.id_orders == order.id)
                            {
                                var _product = context.Product.FirstOrDefault(_item => (_item.id == productId.id_product));
                                items.Add(new dataGridItem()
                                {
                                    orderName = order.name,
                                    firstName = userDate.firstname,
                                    surName = userDate.middlename,
                                    lastName = userDate.lastname,
                                    product = _product.name,
                                    price = _product.price
                                });
                            }
                        }
                    }
                }
            }

        }


        private void InitBindings()
        {
            OrderName.DataPropertyName = nameof(dataGridItem.orderName);
            FirsName.DataPropertyName = nameof(dataGridItem.firstName);
            LastName.DataPropertyName = nameof(dataGridItem.lastName);
            MiddleName.DataPropertyName = nameof(dataGridItem.surName);
            ProductColumn.DataPropertyName = nameof(dataGridItem.product);
            PriceColumn.DataPropertyName = nameof(dataGridItem.price);
        }

        private void InitDataGrid()
        {
            InitBindings();
            InintUsers(db);
            var list = new List<dataGridItem>();

            dataGridView.DataSource = new BindingSource 
            { 
                DataSource = db
            };
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

        private void dataGridViewDBdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dataGridView.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(selected.ToString());
        }
    }

    class dataGridItem
    {
        public string orderName{get; set; }
        public string firstName{get; set; }
        public string surName  {get; set; }
        public string lastName {get; set; }
        public string product {get; set; }
        public decimal price   {get; set; }
        //public List<Entity.Product> products;
        //public Entity.UserData
    }
}
