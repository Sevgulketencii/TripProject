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
    public class GuideManager : IGuideService
    {
        IGuideDal _guide;

        public GuideManager(IGuideDal guide)
        {
            _guide = guide;
        }

        public void ActiveGuide(int id)
        {
            _guide.ActiveGuide(id);
        }

        public void add(Guide t)
        {
            _guide.add(t);
        }

        public void delete(Guide t)
        {
            _guide.delete(t);
        }

        public Guide GetByID(int id)
        {
            return _guide.GetByID(id);
        }

        public List<Guide> List()
        {
            return _guide.list();
        }

        public void PassiveGuide(int id)
        {
            _guide.PassiveGuide(id);
        }

        public void update(Guide t)
        {
            _guide.update(t);
        }
    }
}
