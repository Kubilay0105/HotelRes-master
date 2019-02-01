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

        public List<Reservations> GetReservations(List<Sale> SaleList)
        {
            throw new NotImplementedException();

                                            
        }

        public bool UpdateReServations(Reservations rzrv)
        {
            throw new NotImplementedException();
        }
    }
}
