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
        //ếgsdgdfgbdfgdfgdffgdfbh
        static BusNhanVien Instance;
        public static BusNhanVien GetInstance()
        {
            if (Instance == null)
                Instance = new BusNhanVien();
            return Instance;
        }

        public string getMa()
        {
            string ma = "NV" + DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00")
            + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00");
            return ma;

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
        public object GetByID(string id)
        {
            try
            {
                var nv = from n in db.staffs
                         where n.id == id
                         select n;
                return nv;
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
        public bool Insert(staff nv)
        {
            try
            {
                db.staffs.InsertOnSubmit(nv);

                var permissions = from p in db.permissions
                                 select p;
                foreach (permission p in permissions)
                {
                    staff_permission sp = new staff_permission();
                    sp.permission = p;
                    sp.staff = nv;
                    sp.created = DateTime.Now;
                    sp.allow = false;

                    db.staff_permissions.InsertOnSubmit(sp);
                }

                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(staff nv)
        {
            try
            {
                nv.modified = DateTime.Now;
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
        public bool Delete(staff nv)
        {
            try
            {
                staff_permission p = db.staff_permissions.Where(t => t.staff_id.Equals(nv.id)).FirstOrDefault();
                if (p != null)
                    return false;
                return true;
                        
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
