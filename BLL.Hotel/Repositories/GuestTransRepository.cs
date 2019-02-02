using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class GuestTransRepository : IGuestTransRepository
    {
        OtelResContext ent = new OtelResContext();

        public bool AddGTrans(GuestTransaction gt)
        {
            bool Sonuc = false;
            ent.GuestTransactions.Add(gt);
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

        public List<GuestTransaction> CariHareketlerListele()
        {
            throw new NotImplementedException();
        }
        public List<GuestTransaction> GetGTransById(int Id)
        {
            List<GuestTransaction> glist = (from gl in ent.GuestTransactions
                                            where gl.Id == Id
                                            select gl).ToList();
            return glist;
        }
        public List<GuestTransaction> GetGTrans()
        {
            return ent.GuestTransactions.ToList();
        }
        public bool DeleteGTrans(GuestTransaction gt)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGTrans(int ID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateGTrans()
        {
            throw new NotImplementedException();
        }
        public List<GuestTransaction> GetGTransByGuestId(int Id)
        {
            List<GuestTransaction> lst = (from gl in ent.GuestTransactions
                                          where gl.GuestId == Id
                                          select gl).ToList();
            return lst;
        }
        public List<decimal> PaymentsByGuest(int GuestId)
        {
            List<Decimal> payments = new List<decimal>();
            decimal borc = (from g in ent.GuestTransactions
                            where g.Status == true && g.GuestId==GuestId
                            select g.Debt).DefaultIfEmpty(0).Sum();
            payments.Add(borc);
            decimal odenen = (from g in ent.GuestTransactions
                              where g.Status == true && g.GuestId == GuestId
                              select g.Credit).DefaultIfEmpty(0).Sum();
            payments.Add(odenen);
            payments.Add(borc - odenen);//kalan borç
            return payments;
        }
      
    }
}
