using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService:IGenericService<ContactUs>
    {
        List<ContactUs> GetStatusFalseList();
        List<ContactUs> GetStatusTrueList();
        void ContactUsStatusChangeFalse(int id);

    }
}
