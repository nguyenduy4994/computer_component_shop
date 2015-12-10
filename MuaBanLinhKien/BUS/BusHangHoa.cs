using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BusHangHoa
    {
        static BusHangHoa Instance;
        public static BusHangHoa GetInstance()
        {
            if (Instance == null)
                Instance = new BusHangHoa();
            return Instance;
        }

        QLDataContext db = QLDataContext.GetInstance();
        
        /**
         * Lấy sản phẩm theo danh mục
         */
        public object GetAll()
        {
            try
            {
                var hh = from h in db.products
                         select h;
                return hh;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string getMa()
        {
            string ma = "SP" + DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00")
            + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00");
            return ma;

        }

        public object GetByCat(category pCat)
        {
            try
            {
                var hh = from h in pCat.products
                         select h;
                return hh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(product pProduct)
        {
            try
            {
                pProduct.modified = DateTime.Now;
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
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(product pProduct)
        {
            try
            {
                db.products.DeleteOnSubmit(pProduct);
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
