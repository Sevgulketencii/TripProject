using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<Table> where Table :class
    {
        List<Table> List();
        void add(Table t);
        void delete(Table t);
        void update(Table t);
        Table GetByID(int id);
    }
}
