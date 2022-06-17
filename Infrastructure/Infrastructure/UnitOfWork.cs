using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public CRMDbContext DataContext
        {
            get;
            set;
        }

        public UnitOfWork(DbFactory dbFactory)
        {
            DataContext = dbFactory.Init();
        }

        public UnitOfWork()
        {
            DataContext = new CRMDbContext();
        }

        public void Commit()
        {
            DataContext.SaveChanges();
        }
    }
}
