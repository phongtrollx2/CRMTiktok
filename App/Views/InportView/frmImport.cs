using App.Common;
using App.Services;
using App.ViewModels;
using App.Views.CustomerCategoryView;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace App.Views.InportView
{
    public partial class frmImport : Form
    {
        private CustomerService _customerService;
        private CustomerCategoryService _customerCategoryService;
        private List<Customer> _customersFromDB;
        private List<CustomerVM> _listCustomerImportedFromFile;
        private List<CustomerVM> _listCustomerVerified;
        public frmImport()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            _customerCategoryService = new CustomerCategoryService();
            _customersFromDB = _customerService.GetAllCustomers().ToList();
            _listCustomerVerified = new List<CustomerVM>();
            LoadGridViewCustomerCategory();
        }

        #region Events
        private void menuImportExcel_Click(object sender, EventArgs e)
        {
            ImportExcelFile();
        }

        private void menuCategory_Click(object sender, EventArgs e)
        {
            ShowForm_CreateCustomerCategory();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.AddMultiCustomer(_listCustomerVerified);
                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCustomerCategory_updateCustomerCategoryDelegate()
        {
            LoadGridViewCustomerCategory();
        }

        #endregion

        #region methods
        private void ImportExcelFile()
        {
            string file = ""; //variable for the Excel File Location
            DataTable dt = new DataTable(); //container for our excel data
            _listCustomerImportedFromFile = new List<CustomerVM>();
            DataRow row;
            DialogResult result = openExcel.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Check if Result == "OK".
            {
                file = openExcel.FileName; //get the filename with the location of the file
                try
                {
                    //Create Object for Microsoft.Office.Interop.Excel that will be use to read excel file

                    Excel.Application excelApp = new Excel.Application();

                    Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(file);

                    Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                    Excel.Range excelRange = excelWorksheet.UsedRange;

                    int rowCount = excelRange.Rows.Count; //get row count of excel dataz

                    int colCount = excelRange.Columns.Count; // get column count of excel data

                    //Get the first Column of excel file which is the Column Name

                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= colCount; j++)
                        {
                            dt.Columns.Add(excelRange.Cells[i, j].Value2.ToString());
                        }
                        break;
                    }

                    //Get Row Data of Excel

                    int rowCounter; //This variable is used for row index number
                    for (int i = 2; i <= rowCount; i++) //Loop for available row of excel data
                    {
                        row = dt.NewRow(); //assign new row to DataTable
                        rowCounter = 0;
                        for (int j = 1; j <= colCount; j++) //Loop for available column of excel data
                        {
                            //check if cell is empty
                            if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                            {
                                row[rowCounter] = excelRange.Cells[i, j].Value2.ToString();
                            }
                            else
                            {
                                row[i] = "";
                            }
                            rowCounter++;
                        }
                        dt.Rows.Add(row); //add row to DataTable
                    }

                    _listCustomerImportedFromFile = ConvertDataTable<CustomerVM>(dt);
                    VerifyCustomer(_listCustomerImportedFromFile);
                    var _list = _listCustomerVerified;
                    LoadGridViewCustomer(_list);
                    //gvCustomer.DataSource = _list.ToList(); //assign DataTable as Datasource for DataGridview
                    //gvCustomer.DataSource = dt; //assign DataTable as Datasource for DataGridview


                    //close and clean excel process
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Marshal.ReleaseComObject(excelRange);
                    Marshal.ReleaseComObject(excelWorksheet);
                    //quit apps
                    excelWorkbook.Close();
                    Marshal.ReleaseComObject(excelWorkbook);
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }


        void VerifyCustomer(List<CustomerVM> customers)
        {
            foreach (CustomerVM cus in customers)
            {
                if (CheckCustomerExist(_listCustomerVerified, cus.Phone))
                {
                    MessageBox.Show("Khách hàng đã tồn tại");
                }
                else
                {
                    if (!StringExtensions.ValidatePhoneNumber(cus.Phone, true))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!");
                    }
                    else if (!StringExtensions.IsValidEmail(cus.Email))
                    {
                        MessageBox.Show("Email không tồn tại!");
                    }
                    else
                    {
                        _listCustomerVerified.Add(cus);
                    }

                }
            }
        }

        private bool CheckCustomerExist(List<CustomerVM> customers, string phone)
        {
            bool customer = customers.Any(cus => cus.Phone == phone);
            if (customer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoadGridViewCustomer(List<CustomerVM> customers)
        {
            try
            {
                gvCustomer.Rows.Clear();
                foreach (var customer in customers)
                {
                    gvCustomer.Rows.Add(customer.Name, customer.Phone, customer.Email, customer.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu! " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGridViewCustomerCategory()
        {
            try
            {
                gvCategory.Rows.Clear();
                List<CustomerCategory> customerCategories = _customerCategoryService.GetAllCategories().ToList();
                foreach (var cat in customerCategories)
                {
                    gvCategory.Rows.Add(false, cat.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu! " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowForm_CreateCustomerCategory()
        {
            frmCustomerCategory frmCustomerCategory = new frmCustomerCategory();
            frmCustomerCategory.StartPosition = FormStartPosition.CenterScreen;
            frmCustomerCategory.updateCustomerCategoryDelegate += FrmCustomerCategory_updateCustomerCategoryDelegate;
            frmCustomerCategory.ShowDialog();
        }
        #endregion
    }
}
