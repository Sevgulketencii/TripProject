using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<Table> where Table:class
    {
        List<Table> list();
        void add(Table t);
        void delete(Table t);
        void update(Table t);
        Table GetByID(int id);
    }
}
