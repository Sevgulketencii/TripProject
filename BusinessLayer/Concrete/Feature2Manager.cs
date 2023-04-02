using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Feature2Manager : IFeature2Service
    {
        IFeature2Dal _feature2;

        public Feature2Manager(IFeature2Dal feature2)
        {
            _feature2 = feature2;
        }

        public void add(Feature2 t)
        {
            _feature2.add(t);
        }

        public void delete(Feature2 t)
        {
            _feature2.delete(t);
        }

        public Feature2 GetByID(int id)
        {
            return _feature2.GetByID(id);
        }

        public List<Feature2> List()
        {
            return _feature2.list();
        }

        public void update(Feature2 t)
        {
            _feature2.update(t);
        }
    }
}
