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
    public class UserService
    {
        private IUserRepository _userRepository;
        private IUnitOfWork _unitOfWork;
        
        public UserService()
        {
            var dbFactory = new DbFactory();
            _userRepository = new UserRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        public User Login(string username, string password)
        {
            var user = _userRepository.GetSingleByCondition(x => x.Username == username && x.Password == password);
            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

    }
}
