using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        Context baglan = new Context();
        public List<Reservation> GetListActiveReservations(int id)
        {
            return baglan.ReservationDbSet.Include(x => x.Destination).Where(x =>x.AppUserID==id && x.ReservationStatus=="Onaylandı" ).ToList();
        }

        public List<Reservation> GetListOldReservation(int id)
        {
            return baglan.ReservationDbSet.Include(x => x.Destination).Where(x => x.AppUserID == id && x.ReservationStatus == "İşlem Tamamlandı").ToList();
        }

        public List<Reservation> GetListWaitReservation(int id)
        {
            return baglan.ReservationDbSet.Include(x => x.Destination).Where(x => x.AppUserID == id && x.ReservationStatus == "Onay Bekliyor").ToList();
        }
    }
}
