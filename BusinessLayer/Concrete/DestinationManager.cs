using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destination;

        public DestinationManager(IDestinationDal destination)
        {
            _destination = destination;
        }

        public void add(Destination t)
        {
            _destination.add(t);
        }

        public void delete(Destination t)
        {
            _destination.delete(t);
        }

        public Destination GetByID(int id)
        {
            return _destination.GetByID(id);
        }

        public List<Destination> List()
        {
            return _destination.list();
        }

        public void update(Destination t)
        {
            _destination.update(t);
        }
    }
}
