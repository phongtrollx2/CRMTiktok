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

namespace App.Views.CustomerView
{
    public partial class frmEditCustomer : Form
    {
        private int _idCurrentCustomer;
        private CustomerService _customerService;
        public event UpdateCustomerDelegate _updateCustomerDelegate;
        public frmEditCustomer()
        {
            InitializeComponent();
        }

        public frmEditCustomer(int idCustomer)
        {
            InitializeComponent();
            _idCurrentCustomer = idCustomer;
            _customerService = new CustomerService();
            LoadInfoCustomer();
        }

        #region Events
        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
        }
        private void frmEditCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            _updateCustomerDelegate();
        }

        #endregion

        #region Methods
        public void LoadInfoCustomer()
        {
            try
            {
                var currentCustomer = _customerService.GetCustomerById(_idCurrentCustomer);
                txtName.Text = currentCustomer.Name;
                txtPhone.Text = currentCustomer.Phone;
                txtEmail.Text = currentCustomer.Email;
                txtAddress.Text = currentCustomer.Address;
                txtCustomerCategory.Text = currentCustomer.CategoryId.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu! " + ex, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateCustomer()
        {
            try
            {
                CustomerVM customerVM = new CustomerVM();
                customerVM.Id = _idCurrentCustomer;
                customerVM.Name = txtName.Text;
                customerVM.Phone = txtPhone.Text;
                customerVM.Email = txtEmail.Text;
                customerVM.Address = txtAddress.Text;
                customerVM.CategoryId = int.Parse(txtCustomerCategory.Text);

                _customerService.UpdateCustomer(customerVM);
                MessageBox.Show("Chỉnh sửa thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


    }
}
