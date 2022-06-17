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
    public class CustomerService
    {
        private ICustomerRepository _customerRepository;
        private IUnitOfWork _unitOfWork;

        public CustomerService()
        {
            var dbFactory = new DbFactory();
            _customerRepository = new CustomerRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetCustomerById(int idCustomer)
        {
            return _customerRepository.GetSingleById(idCustomer);
        }

        public Customer AddCustomer(CustomerVM customer)
        {
            var newCustomer = new Customer();
            newCustomer.UpdateCustomer(customer);
            _customerRepository.Add(newCustomer);
            _unitOfWork.Commit();

            return newCustomer;
        }
        public IEnumerable<Customer> AddMultiCustomer(IEnumerable<CustomerVM> customers)
        {
            List<Customer> newCustomers = new List<Customer>();
            List<Customer> existCustomers = _customerRepository.GetAll().ToList();
            foreach(CustomerVM customer in customers)
            {
                var newCustomer = new Customer();

                if(existCustomers.Any(x=>x.Phone == customer.Phone))
                {
                    break;
                }
                else
                {
                    newCustomer.UpdateCustomer(customer);
                    newCustomer.CategoryId = 1;
                    newCustomers.Add(newCustomer);
                }
            }

            _customerRepository.AddMulti(newCustomers);
            _unitOfWork.Commit();

            return newCustomers;
        }

        public void DeleteCustomerById(int id)
        {
            _customerRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public void UpdateCustomer(CustomerVM customer)
        {
            Customer currentCustomer = _customerRepository.GetSingleById(customer.Id);
            currentCustomer.UpdateCustomer(customer);

            _customerRepository.Update(currentCustomer);
            _unitOfWork.Commit();
        }

    }
}
