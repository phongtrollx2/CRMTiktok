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
    public partial class frmCreateCustomer : Form
    {
        private CustomerService _customerService;
        public event UpdateCustomerDelegate _updateCustomerDelegate;
        public frmCreateCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        #region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewCustomer();
        }

        private void frmCreateCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            _updateCustomerDelegate();
        }

        #endregion

        #region Methods

        private void AddNewCustomer()
        {
            try
            {
                if (ValidateCustomer())
                {
                    CustomerVM customer = new CustomerVM();
                    customer.Name = txtName.Text;
                    customer.Phone = txtPhone.Text;
                    customer.Email = txtEmail.Text;
                    customer.Address = txtAddress.Text;
                    customer.CategoryId = int.Parse(txtCustomerCategory.Text);
                    customer.CreatedDate = DateTime.Now;
                    customer.Status = true;

                    _customerService.AddCustomer(customer);
                    this.Close();
                    MessageBox.Show("Them moi thanh cong!");
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Co loi");
            }

        }

        private bool ValidateCustomer()
        {
            if(txtName.Text.Length < 1)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng.");
            }
            else if(txtEmail.Text.Length < 1)
            {
                MessageBox.Show("Bạn chưa nhập email khách hàng.");
            }
            else if (txtPhone.Text.Length < 1)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng.");
            }
            else
            {
                if(!StringExtensions.IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ.");
                }
                else if(!StringExtensions.ValidatePhoneNumber(txtPhone.Text, true))
                {
                    MessageBox.Show("Email không hợp lệ.");
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
