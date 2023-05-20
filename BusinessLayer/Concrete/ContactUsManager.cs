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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void add(ContactUs t)
        {
            _contactUsDal.add(t);
        }

        public void ContactUsStatusChangeFalse(int id)
        {
            _contactUsDal.ContactStatusChangeFalse(id);
        }

        public void delete(ContactUs t)
        {
            _contactUsDal.delete(t);
        }

        public ContactUs GetByID(int id)
        {
            return _contactUsDal.GetByID(id);
        }

        public List<ContactUs> GetStatusFalseList()
        {
            return _contactUsDal.GetStatustFalseList();
        }

        public List<ContactUs> GetStatusTrueList()
        {
            return _contactUsDal.GetStatustTrueList();
        }

        public List<ContactUs> List()
        {
            return _contactUsDal.list();
        }

        public void update(ContactUs t)
        {
            _contactUsDal.update(t);
        }
    }
}
