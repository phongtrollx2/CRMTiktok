using App.Services;
using App.ViewModels;
using App.Views.InportView;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Views.CustomerView
{
    public partial class ucCustomer : UserControl
    {
        private CustomerService _customerService;
        private CustomerCategoryService _customerCategoryService;
        private List<Customer> _listCustomers;
        private List<CustomerCategory> _listCustomerCategories;
        public ucCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            _customerCategoryService = new CustomerCategoryService();
        }

        #region Events
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboCategory();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ShowFormCreateCustomer();
        }

        private void FrmCreateCustomer__updateCustomerDelegate()
        {
            LoadDataGridView();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            ShowFormEditCustomer();
        }

        private void FrmEditCustomer__updateCustomerDelegate()
        {
            LoadDataGridView();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ShowFormImportCustomer();
        }
        private void cmbCustomerCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Methods

        private void LoadDataGridView()
        {
            try
            {
                gvCustomer.Rows.Clear();
                _listCustomers = _customerService.GetAllCustomers().ToList();
                var isChecked = false;
                foreach (var customer in _listCustomers)
                {
                    gvCustomer.Rows.Add(isChecked, customer.Name, customer.Phone, customer.Email, customer.Address, customer.CustomerCategory.Name, customer.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu! " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LoadComboCategory()
        {
            try
            {
                _listCustomerCategories = _customerCategoryService.GetAllCategories().ToList();
                cmbCustomerCategory.DataSource = _listCustomerCategories;
                cmbCustomerCategory.DisplayMember = "Name";
                cmbCustomerCategory.ValueMember = "Id";
                cmbCustomerCategory.SelectedItem = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu! " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCustomer()
        {
            try
            {
                int id = int.Parse(gvCustomer.SelectedCells[6].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa trường này?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _customerService.DeleteCustomerById(id);
                    MessageBox.Show("Xóa bản ghi thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Xóa bản ghi không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowFormEditCustomer()
        {
            if (gvCustomer.Rows.Count < 1)
            {
                MessageBox.Show("Không có dữ liệu để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (gvCustomer.SelectedCells[6].Value != null)
                {
                    int idCurrentUser = int.Parse(gvCustomer.SelectedCells[6].Value.ToString());

                    frmEditCustomer frmEditCustomer = new frmEditCustomer(idCurrentUser);
                    frmEditCustomer.StartPosition = FormStartPosition.CenterScreen;
                    frmEditCustomer._updateCustomerDelegate += FrmEditCustomer__updateCustomerDelegate;

                    frmEditCustomer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowFormCreateCustomer()
        {
            try
            {
                frmCreateCustomer frmCreateCustomer = new frmCreateCustomer();
                frmCreateCustomer.StartPosition = FormStartPosition.CenterScreen;
                frmCreateCustomer._updateCustomerDelegate += FrmCreateCustomer__updateCustomerDelegate;
                frmCreateCustomer.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu! " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowFormImportCustomer()
        {
            try
            {
                frmImport frmImport = new frmImport();
                frmImport.StartPosition = FormStartPosition.CenterScreen;

                frmImport.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu! " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void dateFromDate_ValueChanged(object sender, EventArgs e)
        {
            //DateTime dateStart = dateFromDate.Value.Date;
            //DateTime dateEnd = dateToDate.Value.Date;

            //List<Customer> customers = new List<Customer>();

            //customers = _listCustomer.Where(x => x.CreatedDate >= dateStart && x.CreatedDate <= dateEnd).ToList();
            //LoadDataGridView(customers);
        }
    }
}
