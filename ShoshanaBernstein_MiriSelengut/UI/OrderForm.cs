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
        }

        delegate void EnterButton();
        EnterButton enter;

        public override void BaseEnterBtn()
        {
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
        }

        public void Visible()
        {
            OrderGrpBx.Visible = true;

            foreach (Control c in OrderGrpBx.Controls)
            {
                c.Visible = true;
            }
        }
        #endregion

        #region Create
        public override void BaseCreateBtn()
        {
            Clear();
            Visible();

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

                Order newOrder = new Order(customerID, productID, orderQuantity);

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

            OrderGrpBx.Text = "Update an order";

            enter = UpdateEnter;
        }

        private void UpdateEnter()
        {
            try
            {
                int orderID = int.Parse(OrderIDTxtBx.Text);

                Order searchOrder = orderBLL.Read(orderID);

                int customerID = int.Parse(CustomerIDTxtBx.Text);
                int productID = int.Parse(ProductIDTxtBx.Text);
                int orderQuantity = int.Parse(OrderQuantityTxtBx.Text);

                Order updateOrder = new Order(customerID, productID, orderQuantity);

                updateOrder.OrderID = orderID;

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