using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
        List<Reservation> FilterList(int id);
        List<Reservation> GetListActiveReservations(int id);
        List<Reservation> GetListOldReservation(int id);
        List<Reservation> GetListWaitReservation(int id);
    }
}
