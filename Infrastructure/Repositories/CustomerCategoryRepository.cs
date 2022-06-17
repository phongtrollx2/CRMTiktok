using Data.Infrastructure;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{

    public interface ICustomerCategoryRepository : IRepository<CustomerCategory>
    {
    }

    public class CustomerCategoryRepository : RepositoryBase<CustomerCategory>, ICustomerCategoryRepository
    {
        public CustomerCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
