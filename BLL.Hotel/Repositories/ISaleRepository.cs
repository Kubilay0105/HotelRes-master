using DAL.Hotel.Context;
using DAL.Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public interface ISalesRepository
    {
        List<Sale> GetSales();
        bool AddSales(Sale s);
        bool UpdatePersonnel(Personnel p);
        bool DeletePersonnel(Personnel p);
        bool DeletePersonnel(int ID);
        int GetSaleIdByGuest(int GuestId);
        List<ReservationsModel> GetSales(DateTime today);
    }
}
