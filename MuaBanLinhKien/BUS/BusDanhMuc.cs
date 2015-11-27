using System;
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

        public void Insert(category pCat)
        {
            try
            {
                db.categories.InsertOnSubmit(pCat);
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
    }
}
