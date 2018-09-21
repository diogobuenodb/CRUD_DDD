using BRQ.Domain.Entities;
using BRQ.Domain.Repositories;
using BRQ.InfraStructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRQ.InfraStructure.Data.Repositories
{
    public class RepositoriesUser : IRepositoriesUser
    {
        public void Create(User user)
        {
            using (var context = new BRQContext())
            {
                context.User.Add(user);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new BRQContext())
            {
                var result = context.User.Find(id);
                context.User.Remove(result);
                context.SaveChanges();
            }
        }

        public void Edit(User user)
        {
            using (var context = new BRQContext())
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public User Get(int id)
        {
            using (var context = new BRQContext())
            {
                return context.User.Find(id);
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var context = new BRQContext())
            {
                return context.User.ToList();
            }
        }
    }
}
