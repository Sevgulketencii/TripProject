
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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _about;

        public SubAboutManager(ISubAboutDal about)
        {
            _about = about;
        }

        public void add(SubAbout t)
        {
            _about.add(t);
        }

        public void delete(SubAbout t)
        {
            _about.delete(t);
        }

        public SubAbout GetByID(int id)
        {
            return _about.GetByID(id);
        }

        public List<SubAbout> List()
        {
            return _about.list();
        }

        public void update(SubAbout t)
        {
            _about.update(t);
        }
    }
}
