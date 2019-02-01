using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class ExtraRepository : IExtraRepository
    {
        OtelResContext ent = new OtelResContext();
        
        public bool AddExtra(ExtraType Ex)
        {
            bool Sonuc = false;
            ent.ExtraTypes.Add(Ex);
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
        
        public bool DeleteExtra(int ID)
        {
            throw new NotImplementedException();
        }

        public ExtraTransactions GetExtraType(int ID)
        {
            ExtraTransactions sonuc = (from ex in ent.ExtraTransactions
                         where ex.RoomId == ID 
                         select ex).FirstOrDefault();
            return sonuc;
            
        }


        public List<ExtraType> GetExtraTypes()
        {
            return ent.ExtraTypes.ToList();
        }
        public string GetExtraTypeAll(int id)
        {
            string tur = (from ex in ent.ExtraTypes
                                where ex.Id == id
                                select ex.Type).FirstOrDefault();
            return tur;
        }

        public bool UpdateExtra()
        {
            bool Sonuc = false;
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
        public decimal GetExtraTypePrice(int RoomId)
        {
            decimal sonucPrice = (from r in ent.ExtraTransactions
                             from rt in ent.ExtraTypes
                             where r.RoomId == RoomId
                             where r.TypeId == rt.Id
                             select rt.Price).FirstOrDefault();
            return sonucPrice;
        }
        public int GetRoomId(string RoomNo)
        {
            
            int sonucId = (from r in ent.Rooms
                         where r.RoomNumber == RoomNo
                         from rt in ent.ExtraTransactions
                         where rt.RoomId ==r.Id
                         select rt.RoomId ).FirstOrDefault();
            return sonucId;
        }

        public string ExtraTypeAll(int id)
        {
            throw new NotImplementedException();
        }
        public bool ExtraControl(ExtraType e)
        {
            var Extra = (from ext in ent.ExtraTypes
                            where ext.Type == e.Type
                            select ext).FirstOrDefault();
            if (Extra != null)
                return true;
            return false;
        }
        public ExtraType GetExtraById(int ID)
        {
            ExtraType degisen = (from c in ent.ExtraTypes
                                  where c.Id == ID
                                  select c).FirstOrDefault();
            return degisen;
        }
        public bool ExtraControlFromUpdate(ExtraType e)
        {
            var extra = (from ext in ent.ExtraTypes
                            where ext.Type == e.Type && ext.Id != e.Id
                            select ext).FirstOrDefault();
            if (extra != null)
                return true;
            return false;
        }

        public bool AddExtraTrans(ExtraTransactions Ex)
        {
            throw new NotImplementedException();
        }

        public List<ExtraTransactions> GetExtras(int RoomId)
        {
            throw new NotImplementedException();
        }

        ExtraType IExtraRepository.GetExtraType(int TypeName)
        {
            throw new NotImplementedException();
        }
    }
}
