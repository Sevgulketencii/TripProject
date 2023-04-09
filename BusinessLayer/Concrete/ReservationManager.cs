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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservation;

        public ReservationManager(IReservationDal reservation)
        {
            _reservation = reservation;
        }

        public void add(Reservation t)
        {
            _reservation.add(t);
        }

        public void delete(Reservation t)
        {
            _reservation.delete(t);
        }

        public List<Reservation> FilterList(int id)
        {
            return _reservation.GetFilterList(x => x.AppUserID == id && x.ReservationStatus=="Onay Bekliyor");
        }

        public Reservation GetByID(int id)
        {
            return _reservation.GetByID(id);
        }

        public List<Reservation> GetListActiveReservations(int id)
        {
            return _reservation.GetListActiveReservations(id);
        }

        public List<Reservation> GetListOldReservation(int id)
        {
            return _reservation.GetListOldReservation(id);
        }

        public List<Reservation> GetListWaitReservation(int id)
        {
            return _reservation.GetListWaitReservation(id);
        }

        public List<Reservation> List()
        {
            return _reservation.list();
        }

        public void update(Reservation t)
        {
            _reservation.update(t);
        }
    }
}
