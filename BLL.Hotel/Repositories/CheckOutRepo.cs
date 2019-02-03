using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public class CheckOutRepo
    {
        OtelResContext ent = new OtelResContext();
        public bool NormalCheckOut(int GId)
        {
            using (var trans = ent.Database.BeginTransaction())
            {
                bool sonuc = false;
                try
                {
                    Guest gst = ent.Guests.Where(x => x.Id == GId).FirstOrDefault();//
                    gst.Status = false;
                    ent.SaveChanges();

                    List<GuestTransaction> gt = ent.GuestTransactions.Where(x => x.GuestId == GId).ToList();
                    foreach (GuestTransaction item in gt)
                    {
                        item.Status = false;
                    }

                    ent.SaveChanges();
                    Sale sa = ent.Sales.Where(x => x.GuestId == GId).FirstOrDefault();
                    sa.Status = false;
                    ent.SaveChanges();

                    List<ExtraTransactions> et = ent.ExtraTransactions.Where(x => x.GuestId == GId).ToList();
                    foreach (ExtraTransactions item in et)
                    {
                        item.Status = false;
                    }
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
    }
}
