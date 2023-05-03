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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void add(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void delete(AppUser t)
        {
            _appUserDal.delete(t);
        }

        public AppUser GetByID(int id)
        {
            return _appUserDal.GetByID(id);
        }

        public List<AppUser> List()
        {
            return _appUserDal.list();
        }

        public void update(AppUser t)
        {
            throw new NotImplementedException();
        }
    }
}
