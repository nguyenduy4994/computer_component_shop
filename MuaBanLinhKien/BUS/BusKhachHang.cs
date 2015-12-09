using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BusKhachHang
    {
        static BusKhachHang Instance;
        public static BusKhachHang GetInstance()
        {
            if (Instance == null)
                Instance = new BusKhachHang();
            return Instance;
        }
        DAL.QLDataContext db = QLDataContext.GetInstance();
        public object GetAll()
        {
            try
            {
                var kh = from k in db.customers
                         select k;
                return kh;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(customer pCus)
        {
            try
            {
                db.customers.InsertOnSubmit(pCus);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(customer pCus)
        {
            try
            {
                pCus.modified = DateTime.Now;
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(customer pCus)
        {
            try
            {
                bill b = db.bills.Where(t => t.customer_id == pCus.id).FirstOrDefault();
                if(b != null)
                {
                    return false;
                }
                db.customers.DeleteOnSubmit(pCus);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
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
    }
}
