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
        public object GetAllPermission(staff nv)
        {
            try
            {
                var st = from p in db.staff_permissions
                         where p.staff_id.Equals(nv.id)
                         select p;
                return st;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public staff GetUsername(string user)
        {
            try
            {
                staff nv = db.staffs.Where(n => n.username == user).FirstOrDefault();
                return nv;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<staff_permission> GetPermissions(staff nv)
        {
            var p = from d in nv.staff_permissions
                    select d;

            return p.ToList();
        }
    }
}
