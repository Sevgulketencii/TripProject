using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetListOldReservation(int id);
        List<Reservation> GetListActiveReservations(int id);
        List<Reservation> GetListWaitReservation(int id);
    }
}
