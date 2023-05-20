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
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        Context connect = new Context();
        public void ContactStatusChangeFalse(int id)
        {
            var values = connect.ContactUsDbSet.Find(id);
            values.ContactUsStatus = false;
            connect.Update(values);
            connect.SaveChanges();
        }

        public List<ContactUs> GetStatustFalseList()
        {
            return connect.ContactUsDbSet.Where(x => x.ContactUsStatus == false).ToList();
        }

        public List<ContactUs> GetStatustTrueList()
        {
            return connect.ContactUsDbSet.Where(x => x.ContactUsStatus == true).ToList();
        }
    }
}
