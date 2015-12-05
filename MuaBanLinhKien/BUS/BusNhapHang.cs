using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BusNhapHang
    {
        static BusNhapHang Instance;
        public static BusNhapHang GetInstance()
        {
            if (Instance == null)
                Instance = new BusNhapHang();
            return Instance;
        }
        DAL.QLDataContext db = QLDataContext.GetInstance();
        public object GetAll()
        {
            try
            {
                var pnh = from p in db.receipts
                          select p;
                return pnh;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(receipt pReceipt)
        {
            try
            {
                pReceipt.created = DateTime.Now;
                db.receipts.InsertOnSubmit(pReceipt);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(receipt pReceipt)
        {
            try
            {
                pReceipt.modified = DateTime.Now;
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
