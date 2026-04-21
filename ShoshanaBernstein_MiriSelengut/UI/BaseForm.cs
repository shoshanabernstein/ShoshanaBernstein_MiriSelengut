using BLL;
using DAL;
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
    public partial class BaseForm : Form
    {

        public ProductDAL productDAL;
        public ProductBLL productBLL;
        public int EnterFlag = 0;
        public const int CreateFlag = 1;
        public const int ReadAllFlag = 2;
        public const int ReadOneFlag = 3;
        public const int UpdateFlag = 4;
        public const int DeleteFlag = 5;

        public BaseForm()
        {
            InitializeComponent();
        }

        public virtual void BaseCreateBtn ()
        {

        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            BaseCreateBtn();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void BaseEnterBtn()
        {

        }
        public virtual void BaseReadAllBtn()
        {

        }
        private void ReadAllBtn_Click(object sender, EventArgs e)
        {
            EnterFlag = ReadAllFlag;
            BaseReadAllBtn();
        }
    }
}
