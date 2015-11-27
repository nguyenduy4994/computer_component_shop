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
        public object GetByCat(category pCat)
        {
            try
            {
                // Dưới đây là đoạn select của Trang
                //var hh = from h in db.products
                //         where h.cat_id == pCat.cat_id
                //         select h;

                var hh = from h in pCat.products
                         select h;

                return hh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
