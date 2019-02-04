using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class PaymentsRepository : IPaymentsRepository
    {
        OtelResContext ent = new OtelResContext();

        public List<Payment> GetAllPayments()
        {
            return ent.Payments.ToList();
        }
        public List<PaymentModel> GetAllPaymentsModel()
        {
            List<PaymentModel> liste = (from p in ent.Payments
                                        select new PaymentModel { Id = p.Id, Date = p.Date, Defin = p.TransactionType.Defin, TtName = p.TransactionType.Transtype, Incoming = p.Incoming, Outgoing = p.Outgoing,Description=p.Description }).ToList();
            return liste;
        }
        public List<PaymentModel> GetAllPaymentsModelByDate(DateTime Tarih)
        {
            List<PaymentModel> liste = (from p in ent.Payments
                                        where p.Date.Month == Tarih.Month && p.Date.Day == Tarih.Day
                                        select new PaymentModel { Id = p.Id, Date = p.Date, Defin = p.TransactionType.Defin, TtName = p.TransactionType.Transtype, Incoming = p.Incoming, Outgoing = p.Outgoing, Description = p.Description }).ToList();
            return liste;
        }
        public List<PaymentModel> GetAllPaymentsModelByDate(DateTime Tarih,string Defin)
        {
            List<PaymentModel> liste = (from p in ent.Payments
                                        where p.Date.Month == Tarih.Month && p.Date.Day == Tarih.Day && p.TransactionType.Defin==Defin
                                        select new PaymentModel { Id = p.Id, Date = p.Date, Defin = p.TransactionType.Defin, TtName = p.TransactionType.Transtype, Incoming = p.Incoming, Outgoing = p.Outgoing, Description = p.Description }).ToList();
            return liste;
        }
        public List<PaymentModel> GetAllPaymentsModelByTypeName(DateTime Tarih, string TypeName)
        {
            List<PaymentModel> liste = (from p in ent.Payments
                                        where p.Date.Month == Tarih.Month && p.Date.Day == Tarih.Day && p.TransactionType.Transtype == TypeName
                                        select new PaymentModel { Id = p.Id, Date = p.Date, Defin = p.TransactionType.Transtype, TtName = p.TransactionType.Transtype, Incoming = p.Incoming, Outgoing = p.Outgoing, Description = p.Description }).ToList();
            return liste;
        }
        public bool AddPaymentByIncoming(Payment pay, string TransType)
        {
            using (var trans = ent.Database.BeginTransaction())
            {
                bool sonuc = false;
                try
                {
                    ent.Payments.Add(pay);
                    ent.SaveChanges();

                    GuestTransaction gt = new GuestTransaction();
                    gt.Date = pay.Date;
                    gt.TransType = TransType;
                    gt.Debt = 0;
                    gt.Credit = pay.Incoming;
                    gt.GuestId = pay.GuestId;
                    gt.Status = true;
                    gt.Description = pay.Description;
                    ent.GuestTransactions.Add(gt);
                    ent.SaveChanges();

                    trans.Commit();
                    sonuc = true;

                }
                catch (Exception)
                {
                    trans.Rollback();
                }
                return sonuc;

            }
        }

        public bool AddPaymentByOutgoing(Payment pay)
        {
            bool Sonuc = false;
            ent.Payments.Add(pay);
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

    }
}

