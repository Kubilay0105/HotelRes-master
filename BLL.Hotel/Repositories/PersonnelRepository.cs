using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class PersonnelRepository : IPersonnelRepository
    {
        OtelResContext ent = new OtelResContext();
        public bool AddPersonnel(Personnel p)
        {
            bool Sonuc = false;
            ent.Personnel.Add(p);
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

        public bool AdminControl(int ID)
        {
            bool sonuc = false;
            try
            {
                int Admin = (from p in ent.Personnel
                             where p.Id == ID && p.Admin == true
                             select p).Count();

                if (Admin > 0) sonuc=true;
                else sonuc=false;
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
           return sonuc;
        }

        public bool DeletePersonnel(Personnel p)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersonnel(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Personnel> GetPersonnels()
        {
            return ent.Personnel.ToList();
        }

        public bool UpdatePersonnel(Personnel p)
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
        public bool PersonnelControl(Personnel p)
        {
            var Personel = (from per in ent.Personnel
                            where per.PersonName == p.PersonName
                            select per).FirstOrDefault();
            if (Personel != null)
                return true;
            return false;
        }
        public Personnel GetPersonnelById(int ID)
        {
            Personnel degisen = (from p in ent.Personnel
                                 where p.Id == ID
                                 select p).FirstOrDefault();
            return degisen;
        }
        public bool PersonnelControlFromUpdate(Personnel p)
        {
            var personel = (from ext in ent.ExtraTypes
                            where ext.Type == p.PersonName && ext.Id != p.Id
                            select ext).FirstOrDefault();
            if (personel != null)
                return true;
            return false;
        }
    }
}
