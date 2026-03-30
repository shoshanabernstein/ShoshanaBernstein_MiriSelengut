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
        int enterFlag = 0;
        const int createFlag = 1;
        const int readAllFlag = 2;
        const int readOneFlag = 3;
        const int updateFlag = 4;
        const int deleteFlag = 5;

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
            enterFlag = createFlag;
            CreateGrpBx.Visible = true;
            CreateGrpBx.Text = "Add a new product";
        }

        // sends info from text box in create group box to parameters of create method of product BLL

        #endregion

        #region Read All Button
        private void ReadAllBtn_Click(object sender, EventArgs e)
        {
            enterFlag = readAllFlag;
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
            enterFlag = readOneFlag;

            // show Groupbox
            CreateGrpBx.Visible = true;
            CreateGrpBx.Text = "Search product";
            // clear textbox from what was there before, when click SearchProduct button
            ProductIDTxtBx.Clear();

            // only product ID box, label, and Enter button should be visible
            foreach (Control c in CreateGrpBx.Controls)
            {
                if (c != ProductIDTxtBx && c != ProductIDLbl && c != EnterBtn)
                {
                    c.Visible = false;
                }
                else
                {
                    c.Visible = true;
                }
            }


        }

        #endregion

        #region Update Button
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            enterFlag = updateFlag;
            CreateGrpBx.Visible = true;
            CreateGrpBx.Text = "Update a product";
        }

        #endregion

        #region Delete Button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            enterFlag = deleteFlag;
            CreateGrpBx.Visible = true;
            CreateGrpBx.Text = "Delete a product";
        }
        #endregion
        #region Enter Button
        private void EnterBtn_Click(object sender, EventArgs e)
        {


            switch (enterFlag)
            {

                case createFlag:
                    try
                    {
                        // enter button from create
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
                    break;

                    // if enter button clicked from search one product
                case readOneFlag:
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
                    break;
                case updateFlag:
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
                    break;
                case deleteFlag:
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
                    break;
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
