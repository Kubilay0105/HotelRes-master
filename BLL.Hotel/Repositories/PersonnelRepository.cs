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
            throw new NotImplementedException();
        }
    }
}
