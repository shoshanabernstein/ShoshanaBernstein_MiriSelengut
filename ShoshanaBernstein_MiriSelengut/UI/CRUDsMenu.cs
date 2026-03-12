using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
using DAL;

namespace UI
{
    public partial class CRUDsMenu : Form
    {
        ProductDAL productDAL;
        ProductBLL productBLL;

        public CRUDsMenu()
        {
            try
            {
                InitializeComponent();
                CreateGrpBx.Visible = false;
                productDAL = new ProductDAL();
                productBLL = new ProductBLL(productDAL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Startup Error");
            }
        }

        private void CloseCreateGrpBxBtn_Click(object sender, EventArgs e)
        {
            // Hide the group box
            CreateGrpBx.Visible = false;

            // Optional: Clear the input fields
            ProductNameTxtBx.Clear();
            ProductIDTxtBx.Clear();
            CostPerUnitTxtBx.Clear();
            AmountInStockTxtBx.Clear();
        }

        #region CreateButton
        // opening CreateGroupBox
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateGrpBx.Visible = true;
            CreateGrpBx.Text = "Add a new product";

        }

        // sends info from text box in create group box to parameters of create method of product BLL
        
        #endregion

        #region Read All Button
        private void ReadAllBtn_Click(object sender, EventArgs e)
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

        #endregion

        #region Search one product
        private void ReadBtn_Click(object sender, EventArgs e)
        {
            CreateGrpBx.Visible = true;
            CreateGrpBx.Text = "Search product";
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

            try
            {
                int productID = int.Parse(ProductIDTxtBx.Text);
                Product p = productBLL.Read(productID);

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

        #region Enter Button
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string productName = ProductNameTxtBx.Text;
                int productID = int.Parse(ProductIDTxtBx.Text);
                decimal costPerUnit = decimal.Parse(CostPerUnitTxtBx.Text);
                int amountInStock = int.Parse(AmountInStockTxtBx.Text);
                Product newProduct = new Product(productID, productName, costPerUnit, amountInStock);
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
        private void CreateGrpBx_Enter(object sender, EventArgs e)
        {

        }

        private void ProductIDLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
