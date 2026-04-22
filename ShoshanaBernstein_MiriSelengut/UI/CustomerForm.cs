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
        CustomerDAL customerDAL;
        CustomerBLL customerBLL;

        public CustomerForm()
        {
            InitializeComponent();
            CreateGrpBx.Visible = false;
            CreditCardGrpBx.Visible = false;
            customerDAL = CustomerDAL.Instance;
            customerBLL = new CustomerBLL();
        }

        delegate void EnterButton();
        EnterButton enter;

        public override void BaseEnterBtn()
        {
            enter();
        }

        #region Create
        public override void BaseCreateBtn()
        {
            CreateGrpBx.Visible = true;
            CreditCardGrpBx.Visible = true;
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
            // show Groupbox
            CreateGrpBx.Visible = true;
            CreditCardGrpBx.Visible = false;
            CustomerNameTxtBx.Visible = false;
            CustomerNameLbl.Visible = false;
            CreateGrpBx.Text = "Search customer by ID";
            // clear textbox from what was there before, when click search customer button
            CustomerIDTxtBx.Clear();

            enter = ReadOneEnter;
        }
        private void ReadOneEnter()
        {
            try
            {
                // searching for customer ID
                int customerID = int.Parse(CustomerIDTxtBx.Text);
                Customer c = customerBLL.Read(customerID);


                
                // show all controls
                foreach (Control control in CreateGrpBx.Controls)
                {
                    control.Visible = true;
                }

                if (c != null)
                {
                    // Auto-fill the other textboxes

                    // if the customer has a credit card, fill in the credit card details
                    if (c.creditCard != null)
                    {
                        CreditCard searchCard = c.creditCard;
                        CardHolderNameTxtBx.Text = searchCard.CardHolderName;
                        ExpMonthTxtBx.Text = searchCard.ExpMonth;
                        ExpYearTxtBx.Text = searchCard.ExpYear;
                        CVVTxtBx.Text = searchCard.CVV;
                    }
                    CustomerNameTxtBx.Text = c.CustomerName;

                    
                }
                else
                {
                    MessageBox.Show("Product not found");

                    // Optionally clear the other textboxes
                    foreach (Control control in CreateGrpBx.Controls)
                    {
                        if (control is TextBox textBox)
                        {
                            textBox.Clear();
                        }
                    }
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
            enter = DeleteEnter;
            CreateGrpBx.Visible = true;
            CreditCardGrpBx.Visible = false;
            CustomerNameLbl.Visible = false;
            CustomerNameTxtBx.Visible = false;
            CreateGrpBx.Text = "Delete a customer";
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

                // Clear the textboxes
                foreach (Control control in CreateGrpBx.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }

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
            enter = UpdateEnter;
            CreateGrpBx.Visible = true;
            CreateGrpBx.Text = "Update a customer";
        }
        private void UpdateEnter()
        {
            try
            {
                // parsing textboxes in group box
                string customerName = CustomerNameTxtBx.Text;
                int customerID = int.Parse(CustomerIDTxtBx.Text);
                string cardNumber = CardNumberTxtBx.Text;
                string cardHolder = CardHolderNameTxtBx.Text;
                string cvv = CVVTxtBx.Text;
                string expMonth = ExpMonthTxtBx.Text;
                string expYear = ExpYearTxtBx.Text;

                // creating a new tmp updateProduct 
                Customer updateCustomer = new Customer(customerName, customerID);
                CreditCard updateCreditCard = new CreditCard(cardHolder, cardNumber, expMonth, expYear, cvv);
                updateCustomer.creditCard = updateCreditCard;

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
        }
        #endregion

    }
}
