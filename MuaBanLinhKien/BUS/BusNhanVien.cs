using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BusNhanVien
    {
        QLDataContext db = QLDataContext.GetInstance();

        static BusNhanVien Instance;
        public static BusNhanVien GetInstance()
        {
            if (Instance == null)
                Instance = new BusNhanVien();
            return Instance;
        }

        public object GetAll()
        {
            try
            {
                var staff = from s in db.staffs
                            select s;
                return staff;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
