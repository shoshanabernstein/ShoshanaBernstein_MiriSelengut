using BLL;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace UI
{
    public partial class CustomerForm : BaseForm
    {
        CustomerBLL customerBLL;

        public CustomerForm()
        {
            InitializeComponent();
            CreateGrpBx.Visible = false;
            CreditCardGrpBx.Visible = false;
            customerBLL = new CustomerBLL();
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
            // Clear the textboxes
            CustomerNameTxtBx.Clear();
            CustomerIDTxtBx.Clear();

            foreach (Control c in CreditCardGrpBx.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.Clear();
                }
            }
        }

        public void OnlyIDVisible()
        {
            CreateGrpBx.Visible = true;
            CreditCardGrpBx.Visible = false;
            foreach (Control c in CreateGrpBx.Controls)
            {
                c.Visible = false;
                if (c == CustomerIDLbl || c == CustomerIDTxtBx)
                {
                    c.Visible = true;
                }
            }

        }
        public void Visible()
        {
            CreateGrpBx.Visible = true;
            foreach (Control c in CreateGrpBx.Controls)
            {
                c.Visible = true;
            }
            CreditCardGrpBx.Visible = true;
        }
        #endregion

        #region Create
        public override void BaseCreateBtn()
        {
            Clear();
            Visible();
            CreateGrpBx.Text = "Add a new customer";
            enter = CreateEnter;
        }
        private void CreateEnter()
        {
            try
            {
                // enter button from create
                string customerName = CustomerNameTxtBx.Text;
                int customerID = int.Parse(CustomerIDTxtBx.Text);
                string cardNumber = CardNumberTxtBx.Text;
                string cardHolder = CardHolderNameTxtBx.Text;
                string cvv = CVVTxtBx.Text;
                string expMonth = ExpMonthTxtBx.Text;
                string expYear = ExpYearTxtBx.Text;

                CreditCard newCard = new CreditCard(cardHolder, cardNumber, expMonth, expYear, cvv);

                Customer newCustomer = new Customer(customerName, customerID);
                newCustomer.creditCard = newCard;

                customerBLL.Create(newCustomer);
                MessageBox.Show("A new customer has been added");

                // Hide the group box again after creation
                CreateGrpBx.Visible = false;
                CreditCardGrpBx.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Clear();
            }
        }
        #endregion

        #region ReadAll
        public override void BaseReadAllBtn()
        {
            try
            {
                customerBLL.ReadAll();
                MessageBox.Show(string.Join("\n", customerBLL.ReadAll()));
            }
            catch
            {
                MessageBox.Show("Unable to read products");
            }
        }

        private void ReadAllEnter()
        {
            try
            {
                // parsing textboxes in group box
                string customerName = CustomerNameTxtBx.Text;
                int customerID = int.Parse(CustomerIDTxtBx.Text);

                // creating a new tmp updateProduct 

                Customer updateCustomer = new Customer(customerName, customerID);

                // call the update method
                customerBLL.Update(updateCustomer);
                MessageBox.Show("Your customer has been updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        #endregion

        #region Read
        public override void BaseReadBtn()
        {
            Clear();
            OnlyIDVisible();

            CreateGrpBx.Text = "Search customer by ID";

            enter = ReadOneEnter;
        }
        private void ReadOneEnter()
        {

            try
            {
                // Searching for customer ID
                int customerID = int.Parse(CustomerIDTxtBx.Text);
                
                Customer c = customerBLL.Read(customerID);
                CreditCard newcard = c.creditCard;

                // after enter, show all textboxes
                Visible();

                if (c != null)
                {
                    // Auto-fill the other textboxes
                    // if the customer has a credit card, fill in the credit card details
                    if (c.creditCard != null)
                    {
                        CreditCard searchCard = c.creditCard;
                        CardHolderNameTxtBx.Text = searchCard.CardHolderName;
                        CardNumberTxtBx.Text = searchCard.CardNumber;
                        ExpMonthTxtBx.Text = searchCard.ExpMonth;
                        ExpYearTxtBx.Text = searchCard.ExpYear;
                        CVVTxtBx.Text = searchCard.CVV;
                    }
                    else
                    {
                        foreach (Control ctrl in CreditCardGrpBx.Controls)
                        {
                            if (ctrl is TextBox textBox)
                            {
                                textBox.Clear();
                            }
                        }
                    } 
                        
                        CustomerNameTxtBx.Text = c.CustomerName;
                }
                else
                {
                    MessageBox.Show("Product not found");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                OnlyIDVisible();
            }
        }
        #endregion

        #region Delete
        public override void BaseDeleteBtn()
        {
            Clear();
            OnlyIDVisible();

            CreateGrpBx.Text = "Delete a customer";

            enter = DeleteEnter;
        }
        private void DeleteEnter()
        {
            try
            {
                // parsing textboxes in group box
                string customerName = CustomerNameTxtBx.Text;
                int customerID = int.Parse(CustomerIDTxtBx.Text);

                // creating a new tmp deleteProduct 
                Customer deleteCustomer = new Customer(customerName, customerID);

                // call the delete method
                customerBLL.Delete(deleteCustomer);

                // Hide the group box again after creation
                CreateGrpBx.Visible = false;

                MessageBox.Show("Your customer has been deleted");
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

            CreateGrpBx.Text = "Update a customer";

            enter = UpdateEnter;
        }
        private void UpdateEnter()
        {
            try
            {
                // creating customer
                int customerID = int.Parse(CustomerIDTxtBx.Text);
                Customer searchCustomer = customerBLL.Read(customerID);
                string customerName = CustomerNameTxtBx.Text;

                // creating a new tmp updateProduct 
                Customer updateCustomer = new Customer(customerName, customerID);

                //creating credit card
                string cardNumber = CardNumberTxtBx.Text;
                string cardHolder = CardHolderNameTxtBx.Text;
                string cvv = CVVTxtBx.Text;
                string expMonth = ExpMonthTxtBx.Text;
                string expYear = ExpYearTxtBx.Text;

                // parsing credit card in group box, if contains something
                if (string.IsNullOrWhiteSpace(customerName))
                {
                    customerName = searchCustomer.CustomerName;
                }
                if (string.IsNullOrWhiteSpace(cardNumber))
                {
                    cardNumber = searchCustomer.creditCard.CardNumber;
                }
                if (string.IsNullOrWhiteSpace(cardHolder))
                {
                    cardHolder = searchCustomer.creditCard.CardHolderName;
                }
                if (string.IsNullOrWhiteSpace(cvv))
                {
                    cvv = searchCustomer.creditCard.CVV;
                }
                if (string.IsNullOrWhiteSpace(expMonth))
                {
                    expMonth = searchCustomer.creditCard.ExpMonth;
                }
                if (string.IsNullOrWhiteSpace(expYear))
                {
                    expYear = searchCustomer.creditCard.ExpYear;
                }
                CreditCard updateCard = new CreditCard(cardHolder, cardNumber, expMonth, expYear, cvv);

                // putting credit card into customer
                updateCustomer.creditCard = updateCard;

                // call the update method
                customerBLL.Update(updateCustomer);
                MessageBox.Show("Your customer has been updated");
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
            // Hide the group box
            CreateGrpBx.Visible = false;

            // Optional: Clear the input fields
            foreach (Control control in CreateGrpBx.Controls)
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

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CardNumberTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreditCardGrpBx_Enter(object sender, EventArgs e)
        {

        }
    }
}
