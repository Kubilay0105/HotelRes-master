using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class Reservations : IReservations
    {
        OtelResContext ent = new OtelResContext();
        public bool CancelReservations(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Guest> GetReservations(DateTime dt)
        {
            dt = Convert.ToDateTime(dt.ToShortDateString());
            List<Guest> RG = (from s in ent.Sales
                              where dt <= s.CheckIn
                              from g in ent.Guests
                              where s.GuestId == g.Id && g.Status == false
                              select g).ToList();
            return RG;
        }

        public bool UpdateReServations(Reservations rzrv)
        {
            throw new NotImplementedException();
        }
    }
}
