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
        public object GetAll()
        {
            try
            {
                var hd = from h in db.bills
                         select h;
                return hd;
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
            catch(Exception ex)
            {
                throw ex;
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
    }
}
