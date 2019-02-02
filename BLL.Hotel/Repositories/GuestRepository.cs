﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        OtelResContext ent = new OtelResContext();

        public bool AddGuest(Guest g)
        {
            bool Sonuc = false;
            ent.Guests.Add(g);
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
        public bool DeleteGuest(string Tc)
        {
            bool Sonuc = false;
            Guest gg = (from g in ent.Guests
                        where g.IdentificationNo == Tc
                        select g).FirstOrDefault();
            ent.Guests.Remove(gg);
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

        public List<Guest> GetAllGuest()
        {
            return ent.Guests.OrderByDescending(x=>x.Id).ToList();
        }
        public List<Guest> GetAllGuestByS()
        {
            return ent.Guests.Where(x =>x.Status==true).ToList();
        }

        public List<Guest> GetGuest(int roomId, bool stat)
        {
            throw new NotImplementedException();
        }

        public List<Guest> GetGuestByRoomId(int RoomId)
        {
            List<Guest> list = (from ls in ent.Guests
                                where ls.RoomId == RoomId
                                select ls).ToList();
            return list;
        }

        public Guest GetGuestByTC(string TC)
        {
            Guest gst = (from g in ent.Guests
                         where g.IdentificationNo == TC
                         select g).FirstOrDefault();
            return gst;
        }
        //public Guest GetGuestId(string TC)
        //{
        //    Guest gst = (from g in ent.Guests
        //                 where g.IdentificationNo == TC
        //                 select g).FirstOrDefault();
        //    return gst;
        //}

        public int GetGuestIdByTC(string IdentificationNo)
        {
            int GuestId = Convert.ToInt32((from g in ent.Guests
                                          where g.IdentificationNo == IdentificationNo
                                          select g.Id).FirstOrDefault());
            return GuestId;
        }

        public int NOG(int RoomId)
        {
            int listg = (from lg in ent.Guests
                         where lg.RoomId == RoomId
                         select lg).Count();
            return listg;


        }

        public bool UpdateGuest(Guest g)
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
        public bool UpdateGuestByTC(string TC)
        {
            bool sonuc = false;
            Guest sondeger = (from s in ent.Guests
                            where s.IdentificationNo == TC
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
        public bool UpdateGuestStatusForCheckin(int Id)
        {
            bool sonuc = false;
            try
            {
                var sonuc1 = (from g in ent.Guests
                              where g.Id == Id
                              select g).FirstOrDefault();
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
        public bool UpdateGuestStatusForCheckOutByRoomId(int RoomId)
        {
            bool sonuc = false;
            List<Guest> lg = (from list in ent.Guests
                              where list.RoomId == RoomId
                              select list).ToList();
            try
            {
               foreach (Guest item in lg)
            {
                item.Status = false;
            }
                ent.SaveChanges();
                sonuc = true;
            }
            
            catch (Exception ex)
            {
                string hata = ex.Message;

            }
            return sonuc;
        }
        public List<Guest> GetGuestBySearch(string Ad,string Soyad,string Tc)
        {
            return ent.Guests.Where(x => x.FirstName.StartsWith(Ad) && x.LastName.StartsWith(Soyad) && x.IdentificationNo.StartsWith(Tc)).ToList();
        }

        public List<Guest> GetGuest(int RoomId)
        {
            throw new NotImplementedException();
        }
        public bool UpdateGuest()
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
    }
}
