using BRQ.Domain.Entities;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace BRQ.InfraStructure.Data.Context
{
    public class BRQContext : DbContext
    {
        public BRQContext(): base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BRQCRUD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
             
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BRQContext>());  //cria o banco se não existir
        }
    }
}
