using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;
using DAL.Hotel.Model;

namespace BLL.Hotel.Repositories
{
    public class SaleRepository : ISalesRepository
    {
        OtelResContext ent = new OtelResContext();

        public bool AddSales(Sale s)
        {
            bool Sonuc = false;
            ent.Sales.Add(s);
            try
            {
                ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public bool DeletePersonnel(Personnel p)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersonnel(int ID)
        {
            throw new NotImplementedException();
        }
        public List<Sale> GetSaleforFullRoom(DateTime Tarih)
        {

            return ent.Sales.Where(x=>x.Deleted == false && x.CheckIn < Tarih && x.CheckOut > Tarih).Select(x=>x).ToList();
        }
        public int GetSaleIdByGuest(int GuestId)
        {
            int SaleId = Convert.ToInt32((from s in ent.Sales
                                          where s.GuestId==GuestId
                                          select s.Id).FirstOrDefault());
            return SaleId;
        }
        public List<Guest> GetActiveGuest()
        {
            return ent.Sales.Where(x=>x.Status==true).Select(x=>x.Guest).ToList();
        }
        public List<Guest> GetReservationGuest()
        {
            DateTime Tarih;
            Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            return ent.Sales.Where(x => x.Status == false && x.CheckIn>Tarih).Select(x => x.Guest).ToList();
        }
        public List<Sale> GetSales()
        {
            return ent.Sales.ToList();
        }
        
        public Sale GetSaleById(int SaleId)
        {
            return ent.Sales.Where(x=>x.Id==SaleId).Select(x=>x).FirstOrDefault();
        }

        public List<ReservationsModel> GetSales(DateTime today)
        {
            List<ReservationsModel> SaleList = (from sl in ent.Sales
                                   where sl.CheckIn >= today.Date && sl.Status == false
                                   select new ReservationsModel { SalesId=sl.Id,GuestId=sl.GuestId,GuestFirstName=sl.Guest.FirstName,GuestLastName=sl.Guest.LastName,GuestIdtf=sl.Guest.IdentificationNo,GuestContactNo=sl.Guest.ContactNo,GuestMail=sl.Guest.Email,CheckIn=sl.CheckIn,CheckOut=sl.CheckOut }).ToList();
            return SaleList;
        }

        public int GetSalesId(int ID)
        {
            var sonuc = (from s in ent.Sales
                         where s.RoomId == ID
                         select s.Id).FirstOrDefault();
            return sonuc;
        }

        public bool UpdatePersonnel(Personnel p)
        {
            throw new NotImplementedException();
        }
        //Gelen Tarihteki odteldeki satışlar
        public List<SaleModel> SalesIdGetByDate(DateTime Tarih)
        {
            List<SaleModel> Sales = (from s in ent.Sales
                                 where s.CheckIn <= Tarih.Date && s.CheckOut >= Tarih.Date
                                 from g in ent.Guests where g.Id==s.GuestId
                                 select new SaleModel {SaleID=s.Id,FirstName=g.FirstName,LastName=g.LastName,Identification=g.IdentificationNo }).ToList();
            return Sales;
        }
        public bool UpdateSaleStatusForCheckin(int SalesId)
        {
            bool sonuc = false;
            try
            {
                var sonuc1 = (from s in ent.Sales
                              where s.Id == SalesId
                              select s).FirstOrDefault();
                sonuc1.Status = true;
                sonuc = true;
                ent.SaveChanges();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;

            }
            return sonuc;
        }
        public bool UpdateSalesByGuestId(int ID)
        {
            bool sonuc = false;
            Sale sondeger = (from s in ent.Sales
                             where s.GuestId == ID
                             select s).FirstOrDefault();
            sondeger.Status = false;
            try
            {
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return sonuc;

        }
    }
}
