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

namespace UI
{
    public partial class ProductForm : BaseForm
    {
        ProductDAL productDAL;
        ProductBLL productBLL;
 
        public ProductForm()
        {
            InitializeComponent();
            CreateGrpBx.Visible = false;
            productDAL = new ProductDAL();
            productBLL = new ProductBLL(productDAL);
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
            CreateGrpBx.Text = "Add a new product";
            enter = CreateEnter;
        }
        private void CreateEnter()
        {
            try
            {
                // enter button from create
                string productName = ProductNameTxtBx.Text;
                int productID = int.Parse(ProductIDTxtBx.Text);
                decimal costPerUnit = decimal.Parse(CostPerUnitTxtBx.Text);
                int amountInStock = int.Parse(AmountInStockTxtBx.Text);
                Product newProduct = new Product(productID, productName, costPerUnit, amountInStock);
                MessageBox.Show("got to here");
                productBLL.Create(newProduct);
                MessageBox.Show("A new product has been added");

                // Hide the group box again after creation
                CreateGrpBx.Visible = false;

                // Clear the textboxes
                ProductNameTxtBx.Clear();
                ProductIDTxtBx.Clear();
                CostPerUnitTxtBx.Clear();
                AmountInStockTxtBx.Clear();
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
                productBLL.ReadAll();
                MessageBox.Show(string.Join("\n", productBLL.ReadAll()));
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
                string productName = ProductNameTxtBx.Text;
                int productID = int.Parse(ProductIDTxtBx.Text);
                decimal costPerUnit = decimal.Parse(CostPerUnitTxtBx.Text);
                int amountInStock = int.Parse(AmountInStockTxtBx.Text);

                // creating a new tmp updateProduct 

                Product updateProduct = new Product(productID, productName, costPerUnit, amountInStock);

                // call the update method
                productBLL.Update(updateProduct);
                MessageBox.Show("Your product has been updated");
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
            CreateGrpBx.Text = "Search product";
            // clear textbox from what was there before, when click SearchProduct button
            ProductIDTxtBx.Clear();

            // only product ID box, label, and Enter button should be visible
            foreach (Control c in CreateGrpBx.Controls)
            {
                if (c != ProductIDTxtBx && c != ProductIDLbl)
                {
                    c.Visible = false;
                }
                else
                {
                    c.Visible = true;
                }
            }
            enter = ReadOneEnter;
        }
        private void ReadOneEnter()
        {
            try
            {
                // searching for product ID
                int productID = int.Parse(ProductIDTxtBx.Text);
                Product p = productBLL.Read(productID);

                // show all controls
                foreach (Control c in CreateGrpBx.Controls)
                {
                    c.Visible = true;
                }

                if (p != null)
                {
                    // Auto-fill the other textboxes
                    ProductNameTxtBx.Text = p.ProductName;
                    CostPerUnitTxtBx.Text = p.CostPerUnit.ToString();
                    AmountInStockTxtBx.Text = p.AmountInStock.ToString();
                }
                else
                {
                    MessageBox.Show("Product not found");

                    // Optionally clear the other textboxes
                    ProductNameTxtBx.Clear();
                    CostPerUnitTxtBx.Clear();
                    AmountInStockTxtBx.Clear();
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
            CreateGrpBx.Text = "Delete a product";
        }
        private void DeleteEnter()
        {
            try
            {
                // parsing textboxes in group box
                string productName = ProductNameTxtBx.Text;
                int productID = int.Parse(ProductIDTxtBx.Text);
                decimal costPerUnit = decimal.Parse(CostPerUnitTxtBx.Text);
                int amountInStock = int.Parse(AmountInStockTxtBx.Text);

                // creating a new tmp deleteProduct 

                Product deleteProduct = new Product(productID, productName, costPerUnit, amountInStock);

                // call the delete method
                productBLL.Delete(deleteProduct);

                // Hide the group box again after creation
                CreateGrpBx.Visible = false;

                // Clear the textboxes
                ProductNameTxtBx.Clear();
                ProductIDTxtBx.Clear();
                CostPerUnitTxtBx.Clear();
                AmountInStockTxtBx.Clear();

                MessageBox.Show("Your product has been deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        #endregion

        #region update
        public override void BaseUpdateBtn()
        {
            enter = UpdateEnter;
            CreateGrpBx.Visible = true;
            CreateGrpBx.Text = "Update a product";
        }
        private void UpdateEnter()
        {
            try
            {
                // parsing textboxes in group box
                string productName = ProductNameTxtBx.Text;
                int productID = int.Parse(ProductIDTxtBx.Text);
                decimal costPerUnit = decimal.Parse(CostPerUnitTxtBx.Text);
                int amountInStock = int.Parse(AmountInStockTxtBx.Text);

                // creating a new tmp updateProduct 

                Product updateProduct = new Product(productID, productName, costPerUnit, amountInStock);

                // call the update method
                productBLL.Update(updateProduct);
                MessageBox.Show("Your product has been updated");
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
            ProductNameTxtBx.Clear();
            ProductIDTxtBx.Clear();
            CostPerUnitTxtBx.Clear();
            AmountInStockTxtBx.Clear();
        }
        #endregion
    }
}
