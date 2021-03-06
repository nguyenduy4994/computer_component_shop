﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BusDanhMuc
    {
        QLDataContext db = QLDataContext.GetInstance();
        static BusDanhMuc Instance;
        public static BusDanhMuc GetInstance()
        {
            if (Instance == null)
                Instance = new BusDanhMuc();
            return Instance;
        }

        public object GetAll()
        {
            try
            {
                var danhmuc = from dm in db.categories
                              select dm;
                return danhmuc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string getMa()
        {
            string ma = "DM" + DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00")
            + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00");
            return ma;
           
        }

        public void Insert(category pCat)
        {
            try
            {
                pCat.created = DateTime.Now;
                db.categories.InsertOnSubmit(pCat);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(category pCat)
        {
            try
            {
                pCat.modified = DateTime.Now;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Save()
        {
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(category pCat)
        {
            try
            {
                product pro = db.products.Where(p => p.cat_id == pCat.cat_id).FirstOrDefault();
                category cat = db.categories.Where(c => c.parent_id == pCat.cat_id).FirstOrDefault();
                if(pro != null || cat != null)
                {
                    return false;
                }
                db.categories.DeleteOnSubmit(pCat);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
