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
    public partial class ProductMenu : CRUDsMenu
    {
        public ProductMenu()
        {
            InitializeComponent();
        }

        public override void CreateBtn(object sender, EventArgs e)
        {
            // opening CreateGroupBox

            enterFlag = createFlag;
            CreateGrpBx.Visible = true;
            CreateGrpBx.Text = "Add a new product";

        }
    }
}
