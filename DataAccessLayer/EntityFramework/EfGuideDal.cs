using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context connect = new Context();
       
        public void ActiveGuide(int id)
        {
            var value = connect.GuideDbSet.Find(id);
            value.GuideStatus = true;
            connect.Update(value);
            connect.SaveChanges();
            
        }

        public void PassiveGuide(int id)
        {
            var value = connect.GuideDbSet.Find(id);
            value.GuideStatus = false;
            connect.Update(value);
            connect.SaveChanges();
        }
    }
}
