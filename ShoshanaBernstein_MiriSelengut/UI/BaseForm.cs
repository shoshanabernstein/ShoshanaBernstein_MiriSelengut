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

        public BaseForm()
        {
            InitializeComponent();
        }

        # region Create
        public virtual void BaseCreateBtn () { }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            BaseCreateBtn();
        }

        #endregion

        #region Enter
        public virtual void BaseEnterBtn() { }
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            
            BaseEnterBtn();
        }
        #endregion

        #region ReadAll
        public virtual void BaseReadAllBtn() { }

        private void ReadAllBtn_Click(object sender, EventArgs e)
        {
            BaseReadAllBtn();
        }
        #endregion

        #region Read
        private void ReadBtn_Click(object sender, EventArgs e)
        {
            BaseReadBtn();
        }
        public virtual void BaseReadBtn() { }
        #endregion

        #region Update
        public virtual void BaseUpdateBtn() { }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            BaseUpdateBtn();
        }
        #endregion

        #region delete
        public virtual void BaseDeleteBtn() { }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            BaseDeleteBtn();
        }
        #endregion

        #region close
        public virtual void BaseCloseBtn() { Close(); }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            BaseCloseBtn();
        }
        #endregion
    }
}
