using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BusPhanQuyen
    {
        static BusPhanQuyen Instance;
        public static BusPhanQuyen GetInstance()
        {
            if (Instance == null)
                Instance = new BusPhanQuyen();
            return Instance;
        }

        QLDataContext db = QLDataContext.GetInstance();

        public object GetAll()
        {
            try
            {
                var permission = from p in db.permissions
                                 select p;
                return permission;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
