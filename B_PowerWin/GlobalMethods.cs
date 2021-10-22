using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_PowerWin
{
   public class GlobalMethods
    {
        public static string AskUser_SaveFilePath(string fileType)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.InitialDirectory = UserRegistry.GetLastExportFolder(Environment.SpecialFolder.MyDocuments);
            dlg.Filter = string.Format("Excel files (*.{0})|*.{0}", fileType, fileType);

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UserRegistry.SetLastExportFolder(Path.GetDirectoryName(dlg.FileName));
                return dlg.FileName;
            }

            return "";

        }


        #region SubClasses
        static class UserRegistry
        {


            #region Members

            const string FinERPUserKey = "Software\\BPower";
            const string lastFileOpenDirectory = "LastFileOpenDirectory";
            const string lastExportFolder = "LastExportFolder";

            #endregion

            #region Properties





            #endregion

            #region Methods
            private static RegistryKey GetMasterRegKey()
            {
                RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey, true);
                if (finERPKey == null)
                {
                    finERPKey = Registry.CurrentUser.CreateSubKey(FinERPUserKey);
                }
                return finERPKey;
            }


            public static void SetLastFileOpenFolder(string folderPath)
            {
                //RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey,true);
                GetMasterRegKey().SetValue(lastFileOpenDirectory, folderPath, RegistryValueKind.String);
            }

            public static string GetLastFileOpenFolder(Environment.SpecialFolder defaultFolder)
            {
                string val = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey);

                if (finERPKey != null)
                {
                    val = finERPKey.GetValue(lastFileOpenDirectory, Environment.GetFolderPath(defaultFolder)).ToString();
                }

                return val;

            }




            public static void SetLastExportFolder(string folderPath)
            {
                //RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey, true);
                GetMasterRegKey().SetValue(lastExportFolder, folderPath, RegistryValueKind.String);
            }

            public static string GetLastExportFolder(Environment.SpecialFolder defaultFolder)
            {
                string val = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey);
                if (finERPKey != null)
                {
                    val = finERPKey.GetValue(lastExportFolder, Environment.GetFolderPath(defaultFolder)).ToString();
                }

                return val;

            }



            #endregion

            #region EventHandlers


            #endregion

        }
        #endregion
    }
}
