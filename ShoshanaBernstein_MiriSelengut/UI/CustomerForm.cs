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
        public CustomerForm()
        {
            InitializeComponent();
        }

        //delegate void EnterButton();
        //EnterButton enter;

        //public override void BaseCreateBtn()
        //{
        //    CreateGrpBx.Visible = true;
        //    CreateGrpBx.Text = "Add a new product";
        //    enter = CreateEnter;
        //}


        //private void CreateEnter()
        //{
        //    try
        //    {
        //        // enter button from create
        //        string productName = ProductNameTxtBx.Text;
        //        int productID = int.Parse(ProductIDTxtBx.Text);
        //        decimal costPerUnit = decimal.Parse(CostPerUnitTxtBx.Text);
        //        int amountInStock = int.Parse(AmountInStockTxtBx.Text);
        //        Product newProduct = new Product(productID, productName, costPerUnit, amountInStock);
        //        productBLL.Create(newProduct);
        //        MessageBox.Show("A new product has been added");

        //        // Hide the group box again after creation
        //        CreateGrpBx.Visible = false;

        //        // Clear the textboxes
        //        ProductNameTxtBx.Clear();
        //        ProductIDTxtBx.Clear();
        //        CostPerUnitTxtBx.Clear();
        //        AmountInStockTxtBx.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ReadOneEnter()
        //{
        //    try
        //    {
        //        // searching for product ID
        //        int productID = int.Parse(ProductIDTxtBx.Text);
        //        Product p = productBLL.Read(productID);

        //        // show all controls
        //        foreach (Control c in CreateGrpBx.Controls)
        //        {
        //            c.Visible = true;
        //        }

        //        if (p != null)
        //        {
        //            // Auto-fill the other textboxes
        //            ProductNameTxtBx.Text = p.ProductName;
        //            CostPerUnitTxtBx.Text = p.CostPerUnit.ToString();
        //            AmountInStockTxtBx.Text = p.AmountInStock.ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Product not found");

        //            // Optionally clear the other textboxes
        //            ProductNameTxtBx.Clear();
        //            CostPerUnitTxtBx.Clear();
        //            AmountInStockTxtBx.Clear();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ReadAllEnter()
        //{
        //    try
        //    {
        //        // parsing textboxes in group box
        //        string productName = ProductNameTxtBx.Text;
        //        int productID = int.Parse(ProductIDTxtBx.Text);
        //        decimal costPerUnit = decimal.Parse(CostPerUnitTxtBx.Text);
        //        int amountInStock = int.Parse(AmountInStockTxtBx.Text);

        //        // creating a new tmp updateProduct 

        //        Product updateProduct = new Product(productID, productName, costPerUnit, amountInStock);

        //        // call the update method
        //        productBLL.Update(updateProduct);
        //        MessageBox.Show("Your product has been updated");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }
        //}
        //private void DeleteEnter()
        //{
        //    try
        //    {
        //        // parsing textboxes in group box
        //        string productName = ProductNameTxtBx.Text;
        //        int productID = int.Parse(ProductIDTxtBx.Text);
        //        decimal costPerUnit = decimal.Parse(CostPerUnitTxtBx.Text);
        //        int amountInStock = int.Parse(AmountInStockTxtBx.Text);

        //        // creating a new tmp deleteProduct 

        //        Product deleteProduct = new Product(productID, productName, costPerUnit, amountInStock);

        //        // call the delete method
        //        productBLL.Delete(deleteProduct);

        //        // Hide the group box again after creation
        //        CreateGrpBx.Visible = false;

        //        // Clear the textboxes
        //        ProductNameTxtBx.Clear();
        //        ProductIDTxtBx.Clear();
        //        CostPerUnitTxtBx.Clear();
        //        AmountInStockTxtBx.Clear();

        //        MessageBox.Show("Your product has been deleted");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }
        //}

    }
}
