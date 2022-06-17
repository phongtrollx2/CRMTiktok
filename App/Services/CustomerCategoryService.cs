using App.Infrastructure.Extensions;
using App.ViewModels;
using Data.Infrastructure;
using Infrastructure.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class CustomerCategoryService
    {
        private ICustomerCategoryRepository _customerCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public CustomerCategoryService()
        {
            var dbFactory = new DbFactory();
            _customerCategoryRepository = new CustomerCategoryRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        public IEnumerable<CustomerCategory> GetAllCategories()
        {
            return _customerCategoryRepository.GetAll();
        }

        public CustomerCategory AddCustomerCategory(CustomerCategoryVM customerCategoryVM)
        {
            var newCustomerCategory = new CustomerCategory();
            newCustomerCategory.UpdateCustomerCategory(customerCategoryVM);

            _customerCategoryRepository.Add(newCustomerCategory);
            _unitOfWork.Commit();

            return newCustomerCategory;
        }
    }
}
