using App.Common;
using App.Services;
using App.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Views.CustomerCategoryView
{
    public partial class frmCustomerCategory : Form
    {
        private CustomerCategoryService _customerCategoryService;
        public event UpdateCustomerCategoryDelegate updateCustomerCategoryDelegate;
        public frmCustomerCategory()
        {
            InitializeComponent();
            _customerCategoryService = new CustomerCategoryService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddCustomerCategory();
        }

        private void frmCustomerCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateCustomerCategoryDelegate();
        }

        public void AddCustomerCategory()
        {
            try
            {
                if (txtName.Text.Length < 1)
                {
                    MessageBox.Show("Bạn chưa nhập tên");
                }
                else
                {
                    CustomerCategoryVM customerCategoryVM = new CustomerCategoryVM();
                    customerCategoryVM.Name = txtName.Text;
                    _customerCategoryService.AddCustomerCategory(customerCategoryVM);

                    MessageBox.Show("Thêm mới thành công!");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
        }
    }
}
