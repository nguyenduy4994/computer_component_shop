using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BusHoaDon
    {
        static BusHoaDon Instance;
        public static BusHoaDon GetInstance()
        {
            if(Instance == null)
                Instance = new BusHoaDon();
            return Instance;
        }
        DAL.QLDataContext db = new QLDataContext();
        public object GetAllBill()
        {
            try
            {
                var hd = from h in db.bills
                         where h.type == "hd"
                         select h;
                return hd;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string getMaHD()
        {
            string ma = "HD" + DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00")
            + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00");
            return ma;

        }

        public string getMaBG()
        {
            string ma = "BG" + DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00")
            + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00");
            return ma;

        }

        public object GetAllPrice()
        {
            try
            {
                var bg = from b in db.bills
                         where b.type == "bg"
                         select b;
                return bg;
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
            catch(Exception ex)
            {
                //throw ex;
                return false;
            }
        }
        public bool Insert(bill pbill)
        {
            try
            {
                db.bills.InsertOnSubmit(pbill);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
                //return false;
            }
        }
        public bool Update(bill pbill)
        {
            try
            {
                pbill.modified = DateTime.Now;
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool KiemTraTonTai(bill bl, product sp)
        {
            try
            {
                var p = from b in bl.bill_details
                        where b.product_id.Equals(sp.id)
                        select b;
                return p.Count() == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object GetProduct(bill b)
        {
            try
            {
                var bd = from d in b.bill_details
                         select d;
                return bd;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteProduct(bill_detail bd)
        {
            try
            {
                db.bill_details.DeleteOnSubmit(bd);
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
