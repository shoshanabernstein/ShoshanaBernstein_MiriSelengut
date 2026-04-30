using BLL;
using Entities;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderForm : BaseForm
    {
        OrderBLL orderBLL;

        public OrderForm()
        {
            InitializeComponent();
            orderBLL = new OrderBLL();
            SearchCustomerBtn.Visible = false;
            SearchProductBtn.Visible = false;
            OrderGrpBx.Visible = false;
        }

        delegate void EnterButton();
        EnterButton enter;

        public override void BaseEnterBtn()
        {
            OrderGrpBx.Visible = false;
            enter();
        }

        #region methods
        public void Clear()
        {
            CustomerIDTxtBx.Clear();
            ProductIDTxtBx.Clear();
            OrderQuantityTxtBx.Clear();
            OrderIDTxtBx.Clear();
        }

        public void OnlyIDVisible()
        {
            OrderGrpBx.Visible = true;
            foreach (Control c in OrderGrpBx.Controls)
            {
                c.Visible = false;

                if (c == OrderIDLbl || c == OrderIDTxtBx)
                {
                    c.Visible = true;
                }
            }
            SearchCustomerBtn.Visible = false;
            SearchProductBtn.Visible = false;
        }

        public void Visible()
        {
            OrderGrpBx.Visible = true;

            foreach (Control c in OrderGrpBx.Controls)
            {
                c.Visible = true;
            }
            SearchCustomerBtn.Visible = false;
            SearchProductBtn.Visible = false;
        }
        #endregion

        #region Create
        public override void BaseCreateBtn()
        {
            Clear();
            Visible();
            OrderIDLbl.Visible = false;
            OrderIDTxtBx.Visible = false;
            OrderGrpBx.Text = "Add a new order";

            enter = CreateEnter;
            
        }

        private void CreateEnter()
        {
            try
            {

                int customerID = int.Parse(CustomerIDTxtBx.Text);
                int productID = int.Parse(ProductIDTxtBx.Text);
                int orderQuantity = int.Parse(OrderQuantityTxtBx.Text);

                Order newOrder = new Order(productID, customerID, orderQuantity);

                orderBLL.Create(newOrder);

                MessageBox.Show("A new order has been added");

                OrderGrpBx.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ReadAll
        public override void BaseReadAllBtn()
        {
            try
            {
                orderBLL.ReadAll();
                MessageBox.Show(string.Join("\n", orderBLL.ReadAll()));
            }
            catch
            {
                MessageBox.Show("Unable to read orders");
            }
        }
        #endregion

        #region Read
        public override void BaseReadBtn()
        {
            Clear();
            OnlyIDVisible();

            OrderGrpBx.Text = "Search order by ID";

            SearchCustomerBtn.Visible = true;
            SearchProductBtn.Visible = true;

            enter = ReadOneEnter;
        }
        private void ReadOneEnter()
        {
            try
            {
                int orderID = int.Parse(OrderIDTxtBx.Text);

                Order o = orderBLL.Read(orderID);

                Visible();

                if (o != null)
                {
                    CustomerIDTxtBx.Text = o.CustomerID.ToString();
                    ProductIDTxtBx.Text = o.ProductID.ToString();
                    OrderQuantityTxtBx.Text = o.OrderQuantity.ToString();
                }
                else
                {
                    MessageBox.Show("Order not found");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Read by product
        private void SearchProductBtn_Click(object sender, EventArgs e)
        {
            Clear();
            OnlyIDVisible();
            OrderIDTxtBx.Visible = false;
            OrderIDLbl.Visible = false;
            ProductIDLbl.Visible = true;
            ProductIDTxtBx.Visible = true;
            enter = ReadProductEnter;
        }

        private void ReadProductEnter()
        {
            try
            {
                int productID = int.Parse(ProductIDTxtBx.Text);
                MessageBox.Show(string.Join("\n", orderBLL.ReadProduct(productID)));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Read by customer
        private void SearchCustomerBtn_Click_1(object sender, EventArgs e)
        {
            Clear();
            OnlyIDVisible();
            OrderIDTxtBx.Visible = false;
            OrderIDLbl.Visible = false;
            CustomerIDLbl.Visible = true;
            CustomerIDTxtBx.Visible = true;
            enter = ReadCustomerEnter;
        }


        private void ReadCustomerEnter()
        {
            try
            {

                int customerID = int.Parse(CustomerIDTxtBx.Text);
                MessageBox.Show(string.Join("\n", orderBLL.ReadCustomer(customerID)));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Delete
        public override void BaseDeleteBtn()
        {
            Clear();
            OnlyIDVisible();

            OrderGrpBx.Text = "Delete an order";

            enter = DeleteEnter;
        }

        private void DeleteEnter()
        {
            try
            {
                int orderID = int.Parse(OrderIDTxtBx.Text);

                Order deleteOrder = orderBLL.Read(orderID);

                orderBLL.Delete(deleteOrder);

                OrderGrpBx.Visible = false;

                MessageBox.Show("Your order has been deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Update
        public override void BaseUpdateBtn()
        {
            Clear();
            Visible();
            CustomerIDTxtBx.Visible = false;
            CustomerIDLbl.Visible = false;
            ProductIDTxtBx.Visible = false;
            ProductIDLbl.Visible = false;
            OrderGrpBx.Text = "Update an order";

            enter = UpdateEnter;
        }

        private void UpdateEnter()
        {
            try
            {
                int orderID = int.Parse(OrderIDTxtBx.Text);
                int orderQuantity = int.Parse(OrderQuantityTxtBx.Text);

                Order searchOrder = orderBLL.Read(orderID);

                Order updateOrder = new Order(searchOrder);
                updateOrder.CustomerID = searchOrder.CustomerID;
                updateOrder.ProductID = searchOrder.ProductID;
                updateOrder.OrderQuantity = orderQuantity;

                orderBLL.Update(updateOrder);

                MessageBox.Show("Your order has been updated");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Close
        public override void BaseCloseBtn()
        {
            OrderGrpBx.Visible = false;

            foreach (Control control in OrderGrpBx.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }

            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }
        #endregion

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}