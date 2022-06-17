using App.ViewModels;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateCustomer(this Customer customer, CustomerVM customerVM)
        {
            customer.Id = customerVM.Id;
            customer.Name = customerVM.Name;
            customer.Phone= customerVM.Phone;
            customer.Email = customerVM.Email;
            customer.Address = customerVM.Address;
            customer.CategoryId = customerVM.CategoryId;
            customer.CreatedDate = customerVM.CreatedDate;
            customer.CreatedBy = customerVM.CreatedBy;
            customer.UpdatedDate = customerVM.UpdatedDate;
            customer.UpdatedBy = customerVM.UpdatedBy;
            customer.Status = customerVM.Status;
        }

        public static void UpdateCustomerCategory(this CustomerCategory customerCategory, CustomerCategoryVM customerCategoryrVM)
        {
            customerCategory.Id = customerCategoryrVM.Id;
            customerCategory.Name = customerCategoryrVM.Name;
            customerCategory.CreatedDate = customerCategoryrVM.CreatedDate;
            customerCategory.CreatedBy = customerCategoryrVM.CreatedBy;
            customerCategory.UpdatedDate = customerCategoryrVM.UpdatedDate;
            customerCategory.UpdatedBy = customerCategoryrVM.UpdatedBy;
            customerCategory.Status = customerCategoryrVM.Status;
        }
    }
}
