using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DevExpress;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Devexpress Style");

            Application.Run(new GUI.HeThong.CauHinh.FrmDangNhap());
        }
    }
}
