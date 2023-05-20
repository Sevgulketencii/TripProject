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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcement;

        public AnnouncementManager(IAnnouncementDal announcement)
        {
            _announcement = announcement;
        }

        public void add(Announcement t)
        {
            _announcement.add(t);
        }

        public void delete(Announcement t)
        {
            _announcement.delete(t);
        }

        public Announcement GetByID(int id)
        {
            return _announcement.GetByID(id);
        }

        public List<Announcement> List()
        {
            return _announcement.list();
        }

        public void update(Announcement t)
        {
            _announcement.update(t);
        }
    }
}
