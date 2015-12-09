using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GUI.HeThong.CauHinh
{
    public class myRegistry 
    {
        private static string mAppRegPath = "MyConnectionString";

        public myRegistry()
        {
            // Mặc định sẽ ghi vào HKEY_CURRENT_USER\\Software\\AppCSharp  
            mAppRegPath = "abc";
        }

        /*====================================================================== 
        **----------------------------------------------------------------------  
        ** Ghi khóa có tên pValueName và giá trị bên trong pValue 
        */
        public static void RegWrite(string pValueName, string pValue)
        {
            // Tên khóa = rỗng 
            if (pValueName == "")
                return;
            // Tạo chỗ ghi mặc đinh trước 
         
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(mAppRegPath);
            // Ghi 
            rk.SetValue(pValueName, pValue);
            rk.Close();
        }


        /*====================================================================== 
        **----------------------------------------------------------------------  
        ** Đọc khóa có tên pValueName, không tìm thấy hay.... => lấy giá trị mặc định pDefaultValue 
        */
        public static string RegRead(string pValueName, string pDefaultValue)
        {
            if (pValueName == "")
                return pDefaultValue;
            // Truy cập vào chỗ ghi mặc định trước 
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(mAppRegPath);

            // Không tìm thấy HKEY_CURRENT_USER\\Software\\AppCSharp 
            if (rk == null)
                return pDefaultValue;
            else
                // Đọc khóa 
                return rk.GetValue(pValueName, pDefaultValue).ToString();

        }
    }
}
