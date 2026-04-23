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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CustomerFormBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customerFormFromMain = new CustomerForm();
            customerFormFromMain.Show();
            this.Hide();
        }

        private void ProductFormBtn_Click(object sender, EventArgs e)
        {
            ProductForm productFormFromMain = new ProductForm();
            productFormFromMain.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
