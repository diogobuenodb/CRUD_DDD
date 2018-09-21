using BRQ.Domain.Entities;
using BRQ.Domain.Interfaces.Domain;
using BRQ.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRQ.Domain.Services
{
    public class ServiceBRQ : IBRQ
    {
        private readonly IRepositoriesUser _IRepositoriesUser;
        public ServiceBRQ(IRepositoriesUser IRepositoriesUser)
        {
            _IRepositoriesUser = IRepositoriesUser;
        }
        public void Create(User user)
        {
            _IRepositoriesUser.Create(user);
        }

        public void Delete(int id)
        {
            _IRepositoriesUser.Delete(id);
        }

        public void Edit(User user)
        {
            _IRepositoriesUser.Edit(user);
        }

        public User Get(int id)
        {
          return  _IRepositoriesUser.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return   _IRepositoriesUser.GetAll();
        }
    }
}
