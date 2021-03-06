using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_PowerWin.SharedExt;
using DevExpress.XtraGrid.Drawing;
using System.Data.Entity;
using DevExpress.XtraGrid.Columns;
using B_PowerWin.GUI.CustomLookup;
using B_PowerWin.DB;
using DevExpress.XtraGrid.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Entity.Migrations;

namespace B_PowerWin.GUI.Grid
{
    /*GridManager class is a service to add extra functions to standard GridControl,PivotGridControl
    1-Print
    2-Export
    3-Create runtime Pivot for Grid control
    4-Add Drilldown to pivot grid cells

        */
    public class GridManager
    {

        #region StaticMethods
        public static void SetupEditForm(GridView _gv, List<string> Fields)
        {
            int indx = 0;
            foreach (var col in _gv.Columns)
            {
                ((GridColumn)col).OptionsColumn.AllowEdit = false;
                ((GridColumn)col).OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
                ((GridColumn)col).OptionsEditForm.VisibleIndex = 0;

            }
            foreach (var field in Fields)
            {
                
                var lc_col = _gv.Columns.ColumnByFieldName(field);
                if(lc_col == null) { continue; }
                indx+=5;
                lc_col.OptionsColumn.AllowEdit = true;
                lc_col.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
                lc_col.OptionsEditForm.VisibleIndex = indx;

            }

        }
        #endregion

        #region Properties
        public Grid.GridCtrlBase[] GridControls { get; set; }
        
        public DevExpress.XtraPivotGrid.PivotGridControl[] PivotGridControls { get; set; }
        public object GridControl { get; private set; }
        #endregion



        #region Methods
        public void Attach(params Grid.GridCtrlBase[] _gridControls)
        {
            GridControls = null;//Clear existing list
            
            GridControls = _gridControls;

            InitGuiProperties(GridControls);

            //InitGuiFromDB(GridControls);
        }
        public static void InitGuiFromDB(GridViewBase gv,bool EnableAutoFormat)
        {
            if (!(gv.BaseTypeEnum == DB.BaseTypeEnum.None))
            {
                if (EnableAutoFormat)
                {
                    foreach (GridColumn grdC in gv.Columns)
                    {
                        grdC.Visible = false;
                        grdC.VisibleIndex = -1;
                        grdC.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
                        grdC.OptionsColumn.AllowEdit = false;
                    }
                }
                var db = MySession.Session.Database;
                var lo_BaseType = db.BaseTypes.Find((int)gv.BaseTypeEnum);
                var colList = db.UILabels.Where(x => x.BaseType.BaseTypeId == lo_BaseType.BaseTypeId).OrderBy(x => x.Grid_VisibleOrder).ToList();
                foreach (var col in colList )
                {
                    var grdCol = gv.Columns.ColumnByFieldName(col.FieldName);
                    if (grdCol != null)
                    {
                     
                        col.ApplyFieldSettings(gv, grdCol, EnableAutoFormat);
                        if (col.LookupCode != DB.UILabelAutoLookup.None )
                        {
                            LookupManager.ApplyGVLookup(gv, grdCol, col.LookupCode, col.LookupFilterExp);
                        }
                    }


                }

            }
        }
        private void InitGuiFromDB(GridCtrlBase[] _gridControls)
        {
            foreach (var gc in _gridControls)
            {
                
                foreach (var item in gc.Views)
                {
                    if (item is DevExpress.XtraGrid.Views.Grid.GridView)
                    {
                        var gv = (GridViewBase)item;
                        
                        if (!(gv.BaseTypeEnum == DB.BaseTypeEnum.None))
                        {
                            var db = MySession.Session.Database;
                            var lo_BaseType = db.BaseTypes.Find((int)gv.BaseTypeEnum);
                            var colList = db.UILabels.Where(x => x.BaseType.BaseTypeId == lo_BaseType.BaseTypeId).ToList();
                            foreach (var col in colList)
                            {
                                var grdCol = gv.Columns.ColumnByFieldName(col.FieldName);
                                if (grdCol != null)
                                {
                                    grdCol.Visible = !col.Grid_IsHidden;
                                    grdCol.OptionsColumn.AllowEdit = !col.Grid_IsDisabled;
                                    grdCol.VisibleIndex = col.Grid_VisibleOrder;
                                    grdCol.Width = grdCol.Visible ? col.Grid_Width : 0;
                                   
                                }
                             

                            }

                        }
                        

                    }


                }
               
               
            }

        }

        private void InitGuiProperties(GridControl[] _gridControls)
        {
            foreach (var gc in _gridControls)
            {

                //GridControl settings
                gc.GotFocus += (s, e) => {
                    var gcParntFrm = gc.FindForm();
                    if(gcParntFrm is FormBase )
                    {
                        if (gc.FocusedView is GridViewBase)
                        {
                            (gc.FocusedView as GridViewBase).EnableEditButtons(); 
                        }
                    }
                };

                //Grid View Settings
                foreach (var item in gc.Views)
                {
                    if (item is GridViewBase)
                    {
                        
                        var gv = (DevExpress.XtraGrid.Views.Grid.GridView)item;
                      

                        gv.OptionsView.ColumnAutoWidth = false;
                        gv.OptionsView.ShowAutoFilterRow = true;
                        gv.OptionsView.ShowFooter = true;
                        gv.OptionsView.EnableAppearanceEvenRow = true;
                        gv.OptionsMenu.ShowGroupSummaryEditorItem = true;
                        gv.OptionsMenu.ShowConditionalFormattingItem = true;
                        gv.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
                        gv.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.PlainText;
                        gv.OptionsLayout.StoreAllOptions = true;
                        gv.OptionsLayout.StoreAppearance = true;
                        gv.OptionsLayout.StoreFormatRules = true;
                        
                        
                            gv.InitNewRow += (s, e) => {
                                if(gv is GridViewBase && ((gv as GridViewBase).GridViewEditMode == GridViewEditModeEnum.FormEdit) )
                                {
                                    if (gv.OptionsBehavior.EditingMode == GridEditingMode.EditForm || gv.OptionsBehavior.EditingMode == GridEditingMode.EditFormInplace || gv.OptionsBehavior.EditingMode == GridEditingMode.EditFormInplaceHideCurrentRow)
                                    {
                                        (s as GridViewBase).ShowEditForm();
                                    }
                                    
                                }
                               
                                
                            };
                        

                        //Attach current object to form 
                        var gcParntFrm = gc.FindForm();
                        if (gcParntFrm is FormBase)
                        {
                            gv.FocusedRowChanged += (s, e) => {
                                if (e.FocusedRowHandle >= 0)
                                {
                                    (gcParntFrm as FormBase).FormArgs.CurrentObject = gv.GetFocusedRow();

                                }
                            };
                        }
                        //Add Shortcuts hint on Append & Remove buttons
                        if(gv.GridControl.EmbeddedNavigator != null)
                        {
                            var cn = gv.GridControl.EmbeddedNavigator;
                            cn.Buttons.Append.Hint = "New F6";
                            cn.Buttons.Remove.Hint = "Delete Shift+F6";

                        }
                        gv.KeyDown += (s, e) =>
                        {
                            
                            if (e.KeyCode == Keys.T && e.Control)//Export current selection to Application excel sheet
                            {
                                ExportToExcel(gv);

                            }
                            if(e.KeyCode == Keys.F6)
                            {
                                var cn = gv.GridControl.EmbeddedNavigator;
                                if(cn != null)
                                {
                                    if (e.Shift) //Remove record
                                    {
                                        cn.Buttons.DoClick(cn.Buttons.Remove);
                                    }
                                    else //Insert new record
                                    {
                                        cn.Buttons.DoClick(cn.Buttons.Append);
                                    }
                                }
                            }
                        };
                        gv.PopupMenuShowing += (sender, argE) =>
                        {
                            var lgv = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
                            lgv.OptionsMenu.ShowConditionalFormattingItem = true;
                            //Row menu configuration
                            #region RowMenu
                            if (argE.HitInfo.InRow)
                            {
                                DevExpress.Utils.Menu.DXMenuItem copyGridMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Copy");
                                DevExpress.Utils.Menu.DXMenuItem printGridMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Print");
                                DevExpress.Utils.Menu.DXMenuItem previewGridMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Preview");
                                DevExpress.Utils.Menu.DXMenuItem exportMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Export");
                                DevExpress.Utils.Menu.DXMenuItem refreshMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Refresh");
                                DevExpress.Utils.Menu.DXMenuItem conditionalFormatMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Conditional Format");
                                DevExpress.Utils.Menu.DXMenuItem saveLayoutMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Save layout");
                                DevExpress.Utils.Menu.DXMenuItem restoreLayoutMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Restore layout");
                                DevExpress.Utils.Menu.DXMenuItem clearLayoutMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Clear layout settings");
                                DevExpress.Utils.Menu.DXMenuItem bulkUpdateMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Multi rows update");
                                DevExpress.Utils.Menu.DXMenuItem pivotGridMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Pivot grid");
                                DevExpress.Utils.Menu.DXMenuItem sendSMSMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Send SMS");
                                DevExpress.Utils.Menu.DXMenuItem viewDetailsMenuItem = new DevExpress.Utils.Menu.DXMenuItem("View details");
                                //get icons
                                Image copyGridIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/copy_16x16.png");
                                Image printGridIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/print_16x16.png");
                                Image previewGridIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/preview_16x16.png");
                                Image exportIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxlsx_16x16.png");
                                Image refreshIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh2_16x16.png");
                                Image conditionalFormatIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/palette_16x16.png");
                                Image saveLayoutIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/addgroupheader_16x16.png");
                                Image restoreLayoutIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/deletegroupheader_16x16.png");
                                Image clearLayoutIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/save/saveandclose_16x16.png");
                                Image bulkUpdateLayoutIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/scripts_16x16.png");
                                Image pivotGridIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/grid/pivot_16x16.png");
                                Image sendSMSIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/editfeed_16x16.png");
                                Image viewDetailsIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/showproduct_16x16.png");
                                //Assign icon to its menus
                                copyGridMenuItem.Image = copyGridIcon;
                                printGridMenuItem.Image = printGridIcon;
                                previewGridMenuItem.Image = previewGridIcon;
                                exportMenuItem.Image = exportIcon;
                                refreshMenuItem.Image = refreshIcon;
                                conditionalFormatMenuItem.Image = conditionalFormatIcon;
                                saveLayoutMenuItem.Image = saveLayoutIcon;
                                restoreLayoutMenuItem.Image = restoreLayoutIcon;
                                clearLayoutMenuItem.Image = clearLayoutIcon;
                                bulkUpdateMenuItem.Image = bulkUpdateLayoutIcon;
                                pivotGridMenuItem.Image = pivotGridIcon;
                                sendSMSMenuItem.Image = sendSMSIcon;
                                viewDetailsMenuItem.Image = viewDetailsIcon;
                                //Link this grid view to menu object via Tag property
                                copyGridMenuItem.Tag = lgv;
                                printGridMenuItem.Tag = lgv;
                                previewGridMenuItem.Tag = lgv;
                                exportMenuItem.Tag = lgv;
                                refreshMenuItem.Tag = lgv;
                                conditionalFormatMenuItem.Tag = lgv;
                                saveLayoutMenuItem.Tag = lgv;
                                restoreLayoutMenuItem.Tag = lgv;
                                clearLayoutMenuItem.Tag = lgv;
                                bulkUpdateMenuItem.Tag = lgv;
                                pivotGridMenuItem.Tag = lgv;
                                sendSMSMenuItem.Tag = lgv;
                                viewDetailsMenuItem.Tag = lgv;
                                //Event handler for each menu item
                                //=======================================================================================
                                copyGridMenuItem.Click += (s, e) =>
                                {
                                    lgv.CopyToClipboard();
                                };
                                printGridMenuItem.Click += (s, e) =>
                                {
                                    lgv.OptionsPrint.ExpandAllDetails = false;//To reserve user settings during printing
                                    lgv.OptionsPrint.ExpandAllGroups = false;
                                    lgv.Print();

                                };
                                previewGridMenuItem.Click += (s, e) =>
                                {
                                    PreviewXtraGrid previewXtraGrid;

                                    try
                                    {
                                        lgv.OptionsPrint.ExpandAllDetails = false;//To reserve user settings during printing
                                        lgv.OptionsPrint.ExpandAllGroups = false;
                                        previewXtraGrid = new PreviewXtraGrid(lgv.GridControl);
                                        previewXtraGrid.PrintableGridLink.Landscape = true;
                                        previewXtraGrid.ShowPreviewDialog();
                                    }
                                    catch (Exception ex)
                                    {

                                        XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                                    }
                                };
                                exportMenuItem.Click += (s, e) =>
                                {
                                    string fileName = "";
                                    fileName = GlobalMethods.AskUser_SaveFilePath("Xlsx");
                                    if (string.IsNullOrEmpty(fileName)) { return; }
                                    lgv.ExportToXls(fileName);
                                };
                                refreshMenuItem.Click += (s, e) =>
                                {
                                    //    gv.UnitOfWorkXpo.Refresh( RefreshMode.StoreWins,);
                                };
                                pivotGridMenuItem.Click += (s, e) =>
                                {
                                    try
                                    {


                                        XtraGridPopupMenu_PivotXtraForm frm = new XtraGridPopupMenu_PivotXtraForm(lgv);
                                        //Inhriet pivot form from caller form
                                        //frm.IsSaveLayout = parentForm.IsSaveLayout;Disable this option 
                                        //frm.IsPreviewable = parentForm.IsPreviewable;
                                        //frm.IsPrintable = parentForm.IsPrintable;
                                        //frm.IsExportable = parentForm.IsExportable;
                                        var parentForm = lgv.GridControl.TopLevelControl as XtraForm;

                                        if (parentForm.IsMdiChild)
                                        {
                                            frm.MdiParent = parentForm;
                                            frm.WindowState = FormWindowState.Maximized;
                                            frm.Show();
                                            //Stacked windows
                                            // StackingChildForms(lgv,MdiLayout.TileHorizontal, parentForm, frm);

                                        }
                                        else
                                        {
                                            frm.WindowState = FormWindowState.Maximized;
                                            frm.ShowDialog();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                                    }


                                };
                                viewDetailsMenuItem.Click += (s, e) =>
                                {
                                    //if (argE.HitInfo.InRow && argE.HitInfo.RowHandle >= 0)
                                    //{
                                    //    var colInfo = (GridColumnInfo)argE.HitInfo.Column.Tag;
                                    //    if (colInfo == null) return;
                                    //    if (colInfo.IsViewDetails)
                                    //    {
                                    //        colInfo.FormArgs = new Args();
                                    //        //Save current row value 
                                    //        string cellVal = lgv.GetRowCellValue(argE.HitInfo.RowHandle, argE.HitInfo.Column).ToString();
                                    //        var col = argE.HitInfo.Column;
                                    //        if (col.ColumnType == typeof(string) ||
                                    //           col.ColumnType == typeof(DateTime))
                                    //        {
                                    //            cellVal = $"'{cellVal}'";
                                    //        }
                                    //        colInfo.FormArgs.Caller = lgv.GridControl.FindForm();
                                    //        //colInfo.FormArgs.LookupField = colInfo.ColumnLablel.LookupEditor.LookupValueField;
                                    //        colInfo.FormArgs.LookupValue = cellVal;
                                    //        // colInfo.FormArgs.Record = (XPBaseObject)GetRow(argE.HitInfo.RowHandle);
                                    //        //OnViewDetails(new ViewDetailsEventArgs(colInfo, lgv));
                                    //    }
                                    //}
                                };
                                saveLayoutMenuItem.Click += (s, e) =>
                                {
                                    SaveLayoutAsDefault((GridViewBase)gv);
                                };


                                //=======================================================================================
                                //Add menu to grid 
                                //=======================================================================================
                                argE.Menu.Items.Add(copyGridMenuItem);
                                argE.Menu.Items.Add(printGridMenuItem);
                                argE.Menu.Items.Add(previewGridMenuItem);
                                argE.Menu.Items.Add(exportMenuItem);
                                argE.Menu.Items.Add(pivotGridMenuItem);
                                argE.Menu.Items.Add(refreshMenuItem);
                                argE.Menu.Items.Add(viewDetailsMenuItem);
                                argE.Menu.Items.Add(saveLayoutMenuItem);


                            }
                            #endregion

                            #region ColumnMenu
                            if (argE.HitInfo.InColumn)
                            {

                                //Checked filter with sub menu
                                DevExpress.Utils.Menu.DXSubMenuItem checkedFilterSubMenuItem = new DevExpress.Utils.Menu.DXSubMenuItem("Filter popup mode");
                                DevExpress.Utils.Menu.DXMenuItem checkedListOptionMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Checked list");
                                DevExpress.Utils.Menu.DXMenuItem listOptionMenuItem = new DevExpress.Utils.Menu.DXMenuItem("List");
                                DevExpress.Utils.Menu.DXMenuItem defaultOptionMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Default");

                                checkedFilterSubMenuItem.Items.Add(defaultOptionMenuItem);
                                checkedFilterSubMenuItem.Items.Add(checkedListOptionMenuItem);
                                checkedFilterSubMenuItem.Items.Add(listOptionMenuItem);

                                System.Drawing.Image filterIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/forcetesting_16x16.png");
                                System.Drawing.Image freezeIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/alignverticalleft_16x16.png");
                                System.Drawing.Image expColumnIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/scripts_16x16.png");
                                System.Drawing.Image removeColumnIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/deleteheader_16x16.png");
                                System.Drawing.Image columnsSetupIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/grid/customizegrid_16x16.png");

                                checkedFilterSubMenuItem.Image = filterIcon;
                                checkedFilterSubMenuItem.ImageDisabled = filterIcon;
                                checkedFilterSubMenuItem.LargeImage = filterIcon;
                                checkedFilterSubMenuItem.LargeImageDisabled = filterIcon;

                                defaultOptionMenuItem.Click += (s, e) =>
                                {
                                    argE.HitInfo.Column.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
                                };
                                checkedListOptionMenuItem.Click += (s, e) =>
                                {
                                    argE.HitInfo.Column.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
                                };
                                listOptionMenuItem.Click += (s, e) =>
                                {
                                    argE.HitInfo.Column.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
                                };

                                defaultOptionMenuItem.Tag = argE.HitInfo;
                                checkedListOptionMenuItem.Tag = argE.HitInfo;
                                listOptionMenuItem.Tag = argE.HitInfo;
                                argE.Menu.Items.Add(checkedFilterSubMenuItem);

                                //Freeze column
                                DevExpress.Utils.Menu.DXSubMenuItem freezeColumnSubMenuItem = new DevExpress.Utils.Menu.DXSubMenuItem("Freeze column");
                                freezeColumnSubMenuItem.Image = freezeIcon;
                                freezeColumnSubMenuItem.ImageDisabled = freezeIcon;
                                freezeColumnSubMenuItem.LargeImage = freezeIcon;
                                freezeColumnSubMenuItem.LargeImageDisabled = freezeIcon;

                                DevExpress.Utils.Menu.DXMenuItem freezeColumnToLeft = new DevExpress.Utils.Menu.DXMenuItem("Left");
                                DevExpress.Utils.Menu.DXMenuItem freezeColumnToRight = new DevExpress.Utils.Menu.DXMenuItem("Right");
                                DevExpress.Utils.Menu.DXMenuItem freezeColumnClear = new DevExpress.Utils.Menu.DXMenuItem("None");

                                freezeColumnSubMenuItem.Items.Add(freezeColumnToLeft);
                                freezeColumnSubMenuItem.Items.Add(freezeColumnToRight);
                                freezeColumnSubMenuItem.Items.Add(freezeColumnClear);

                                freezeColumnToLeft.Click += (s, e) => { argE.HitInfo.Column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left; };
                                freezeColumnToRight.Click += (s, e) => { argE.HitInfo.Column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right; };
                                freezeColumnClear.Click += (s, e) => { argE.HitInfo.Column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None; };

                                freezeColumnToLeft.Tag = argE.HitInfo;
                                freezeColumnToRight.Tag = argE.HitInfo;
                                freezeColumnClear.Tag = argE.HitInfo;

                                argE.Menu.Items.Add(freezeColumnSubMenuItem);
                                if (argE.HitInfo.Column.UnboundType == DevExpress.Data.UnboundColumnType.Bound)
                                {
                                    DevExpress.Utils.Menu.DXMenuItem addExpColumnMenu = new DevExpress.Utils.Menu.DXMenuItem("New expression column");
                                    addExpColumnMenu.Image = expColumnIcon;
                                    addExpColumnMenu.Tag = lgv;
                                    addExpColumnMenu.Click += (s, e) =>
                                    {
                                        ExpressionColumnOptionsXtraForm frm = new ExpressionColumnOptionsXtraForm(lgv);
                                        frm.ShowDialog();
                                    };
                                    argE.Menu.Items.Add(addExpColumnMenu);

                                }
                                else
                                {
                                    DevExpress.Utils.Menu.DXMenuItem removeExpColumnMenu = new DevExpress.Utils.Menu.DXMenuItem("Remove expression column");
                                    removeExpColumnMenu.Image = removeColumnIcon;
                                    removeExpColumnMenu.Tag = argE.HitInfo;
                                    removeExpColumnMenu.Click += (s, e) =>
                                    {
                                        argE.HitInfo.Column.View.Columns.Remove(argE.HitInfo.Column);
                                    };
                                    argE.Menu.Items.Add(removeExpColumnMenu);


                                }

                                //Column setup
                                DevExpress.Utils.Menu.DXMenuItem setupColumnsMenu = new DevExpress.Utils.Menu.DXMenuItem("Advanced settings");
                                setupColumnsMenu.Image = columnsSetupIcon;
                                setupColumnsMenu.Tag = lgv;
                                setupColumnsMenu.Click += (s, e) => //setupColumnsMenu_Click
                                {
                                    XtraGridPopupMenu_ColumnsReorderXtraForm frm = new XtraGridPopupMenu_ColumnsReorderXtraForm(lgv);
                                    frm.Show();
                                };
                                argE.Menu.Items.Add(setupColumnsMenu);

                            }
                            #endregion

                        };
                    }


                }
            }
        }

        public void SaveLayoutAsDefault(GridViewBase gv)
        {
            if (gv.BaseTypeEnum != BaseTypeEnum.None)
            {
                foreach (var grdCol in gv.Columns.Where(x => x.Tag is GridColumnInfo ))
                {
                    var info = (GridColumnInfo)grdCol.Tag;
                    if (info.ColumnLablel != null)
                    {
                        info.ColumnLablel.Grid_VisibleOrder = grdCol.VisibleIndex+1;
                        info.ColumnLablel.Grid_Width = grdCol.Width;
                        if (grdCol.VisibleIndex < 0 || !grdCol.Visible) { info.ColumnLablel.Grid_IsHidden = true; }
                        if(grdCol.OptionsColumn.ReadOnly || grdCol.OptionsColumn.AllowEdit == false) { info.ColumnLablel.Grid_IsDisabled = true; }
                        MySession.Session.Database.UILabels.AddOrUpdate(info.ColumnLablel);
                        MySession.Session.Database.SaveChanges();
                    }
                }
                MySession.Session.Database.SaveChanges();

            }
        }

        public void ExportToExcel(DevExpress.XtraGrid.Views.Grid.GridView _gv)
        {
            try
            {
                var parnt = _gv.GridControl.TopLevelControl;
                ExcelForm frm = new ExcelForm();
                if (parnt is Form)
                {
                    var parentFrm = (Form)parnt;
                    if (parentFrm.IsMdiContainer)
                    {
                        frm.MdiParent = parentFrm;
                    }
                }
                _gv.CopyToClipboard();
                frm.OpenFromClipboard();
                frm.Show();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
        }
        private void StackingChildForms(DevExpress.XtraGrid.Views.Grid.GridView _gv, MdiLayout mDiLayout, params Form[] childWindows)
        {
            //Minimize all others winow 
            var parentForm = (XtraForm)_gv.GridControl.TopLevelControl;
            foreach (Form child in parentForm.MdiChildren)
            {
                child.WindowState = FormWindowState.Minimized;
            }
            foreach (Form child in childWindows)
            {
                child.WindowState = FormWindowState.Normal;

            }

            parentForm.LayoutMdi(mDiLayout);


        }
        private void ApplyDBGuiProperties(GridViewBase _gv,DB.BaseTypeEnum _baseType)
        {
            var dbBaseType = MySession.Session.Database.BaseTypes.Find(_baseType);
            var Lbls = MySession.Session.Database.UILabels.Where(x => x.BaseType == dbBaseType);
            foreach (var col in Lbls)
            {
                var grdCol = _gv.Columns.ColumnByFieldName(col.FieldName);

                grdCol.Caption = DB.UILabelLangTxt.GetLangTxt(col.LabelId, DB.UILabelType.FieldCaption)?.Txt;
                grdCol.ToolTip = DB.UILabelLangTxt.GetLangTxt(col.LabelId, DB.UILabelType.FieldHelp)?.Txt;
                grdCol.Tag = col;
                grdCol.Visible = !col.Grid_IsHidden;
                grdCol.VisibleIndex = col.Grid_VisibleOrder;
                grdCol.Width = col.Grid_Width;
                if(col.LookupCode != DB.UILabelAutoLookup.None)
                {
                    LookupManager.ApplyGVLookup(_gv, grdCol, col.LookupCode, col.LookupFilterExp);
                }


            }

        }
        

        #endregion
    }
}
