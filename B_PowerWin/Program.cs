using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using B_PowerWin.Properties;
using DevExpress.XtraEditors;
using B_PowerWin.SharedExt;

namespace B_PowerWin
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

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            new MySession("root");
            var mainFrm = new MainFrm();
            MySession.Session.MainForm = mainFrm;

            Application.Run(mainFrm);
            //Application.Run(new MainFrm());
        }

    }
}
