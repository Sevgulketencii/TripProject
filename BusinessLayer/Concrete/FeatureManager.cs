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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _feature;

        public FeatureManager(IFeatureDal feature)
        {
            _feature = feature;
        }

        public void add(Feature t)
        {
            _feature.add(t);
            
        }

        public void delete(Feature t)
        {
            _feature.delete(t);
        }

        public Feature GetByID(int id)
        {
            return _feature.GetByID(id);
        }

        public List<Feature> List()
        {
            return _feature.list();
        }

        public void update(Feature t)
        {
            _feature.update(t);
        }
    }
}
