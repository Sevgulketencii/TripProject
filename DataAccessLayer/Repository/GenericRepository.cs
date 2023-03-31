using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<Table> : IGenericDal<Table> where Table : class
    {
        Context baglan = new Context();

        public void add(Table t)
        {
            baglan.Set<Table>().Add(t);
            baglan.SaveChanges();
        }

        public void delete(Table t)
        {
            baglan.Set<Table>().Remove(t);
            baglan.SaveChanges();
        }

        public Table GetByID(int id)
        {
            return baglan.Set<Table>().Find(id);

        }

        public List<Table> list()
        {
            throw new NotImplementedException();
        }

        public void update(Table t)
        {
            throw new NotImplementedException();
        }
    }
}
