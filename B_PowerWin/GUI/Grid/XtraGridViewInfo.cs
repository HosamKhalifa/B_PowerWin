using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_PowerWin.SharedExt;

namespace B_PowerWin.GUI.Grid
{
    public class XtraGridViewInfo
    {
        public XtraGridViewInfo(GridViewBase gv)
        {
            infoObject = InfoObjectType.GridView;
            this.gridView = gv;
            //objFullName = String.Format("{0}.{1}", GetCSharpControlName(gv.GridControl), gv.Name);
            //objFullCaption = GetCSharpGridViewCaption(gv);
            //gridDBKey = GetGridViewDBKey(objFullName, objFullCaption);

            gridView.Tag = this;
        }

        public XtraGridViewInfo(DevExpress.XtraPivotGrid.PivotGridControl pivot)
        {
            infoObject = InfoObjectType.Pivot;
            this.pivotGrid = pivot;
            //objFullName = GetCSharpControlName(pivot);
            //objFullCaption = GetCSharpControlCaption(pivot);
            //gridDBKey = GetGridViewDBKey(objFullName, objFullCaption);
            pivot.Tag = this;

        }
        public XtraGridViewInfo(DevExpress.XtraTreeList.TreeList treeLst)
        {
            infoObject = InfoObjectType.TreeList;
            this.treeList = treeLst;
            //objFullName = GetCSharpControlName(treeList);
            //objFullCaption = GetCSharpControlCaption(treeList);

            //gridDBKey = GetGridViewDBKey(objFullName, objFullCaption);
            treeList.Tag = this;

        }

        #region Members
        public enum InfoObjectType { GridView, Pivot, TreeList }
        private InfoObjectType infoObject;
        //UIMaster gridDBKey;
        //UIProfile gridLayoutKey;
        GridViewBase gridView;
        DevExpress.XtraPivotGrid.PivotGridControl pivotGrid;
        DevExpress.XtraTreeList.TreeList treeList;
        string gridControlFullName = "?";//Question mark mean you need recreate the name from code 
        string gridControlFullCaption = "?";

        PreviewXtraGridInfo previewXtraGridInfo;

        string objFullName = "?";
        string objFullCaption = "?";


        #endregion

        #region Properties
        public PreviewXtraGridInfo PreviewGridInfo
        {
            set { previewXtraGridInfo = value; }
            get { return previewXtraGridInfo; }
        }

        public InfoObjectType InfoObject
        {
            get { return infoObject; }
        }


     


       
        



        #endregion

        #region Methods

        public string GetXMLSettings()
        {
            string xmlInString;

            string generetedFileName = String.Format("xmlSettins{0}save", DateTime.Now.Ticks);
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            fileName = String.Format(@"{0}\{1}.hos", fileName, generetedFileName);
            FileStream fs = File.Create(fileName);

            DevExpress.Utils.OptionsColumnLayout optionsColumnLayout = new DevExpress.Utils.OptionsColumnLayout();
            //GridView Settings
            if (InfoObject == InfoObjectType.GridView)
            {
                gridView.OptionsLayout.StoreAllOptions = true;
                gridView.OptionsLayout.Columns.StoreAllOptions = true;
                gridView.OptionsLayout.StoreAppearance = true;
                gridView.OptionsLayout.Columns.RemoveOldColumns = false;
                gridView.SaveLayoutToStream(fs);
            }
            if (InfoObject == InfoObjectType.Pivot)
            {
                //pivotGrid.OptionsLayout.StoreAllOptions = true;
                DevExpress.XtraPivotGrid.PivotGridOptionsLayout pivotOptions = new DevExpress.XtraPivotGrid.PivotGridOptionsLayout();
                pivotOptions.StoreAllOptions = true;
                pivotGrid.SaveLayoutToStream(fs, pivotOptions);
            }

            fs.Close();
            xmlInString = System.IO.File.ReadAllText(fileName);
            System.IO.File.Delete(fileName);
            return xmlInString;
        }

        public void RestoreLayoutFromXML(string xmlSettings)
        {
            string generetedFileName = String.Format("xmlSettins{0}save", DateTime.Now.Ticks);
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            fileName = String.Format(@"{0}\{1}.hos", fileName, generetedFileName);
            System.IO.File.WriteAllText(fileName, xmlSettings);
            if (InfoObject == InfoObjectType.GridView)
            {
                gridView.GridControl.ForceInitialize();

                //layoutGridControl.MainView.RestoreLayoutFromXml(fileName);
                gridView.OptionsLayout.Columns.StoreAllOptions = true;
                gridView.OptionsLayout.StoreAppearance = true;
                gridView.RestoreLayoutFromXml(fileName, OptionsLayoutBase.FullLayout);

            }
            if (InfoObject == InfoObjectType.Pivot)
            {
                pivotGrid.ForceInitialize();

                //pivotGrid.OptionsLayout.Columns.StoreAllOptions = false;
                //pivotGrid.OptionsLayout.Columns.RemoveOldColumns = true;
                DevExpress.XtraPivotGrid.PivotGridOptionsLayout pivotOptions = new DevExpress.XtraPivotGrid.PivotGridOptionsLayout();
                pivotOptions.StoreAllOptions = true;
                pivotGrid.RestoreLayoutFromXml(fileName, pivotOptions);
            }


            System.IO.File.Delete(fileName);

        }

       

        public void ClearAllSavedLayoutsFromDB()
        {
            try
            {
                //var line = GetGridViewLayoutKey();
                //XpoDefault.Session.Delete(line.UIProfileLines);
                //XpoDefault.Session.Save(line.UIProfileLines);
                //string deleteSQL = string.Format("DELETE FROM dbo.SecurityUserDataGridLayoutLinesTable WHERE LayoutKey = {0}", GetGridViewLayoutKey());
                //SqlCommand cmd = new SqlCommand(deleteSQL, HFrameWork.GlobalVariable.Sqlca);
                //cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
        }


        #endregion

        #region EventHandlers


        #endregion


    }

}
