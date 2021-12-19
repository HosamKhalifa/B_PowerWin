using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using B_PowerWin.DB;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using System.Drawing;

namespace B_PowerWin.GL.UXC
{
    public class PopupLookup
    {
        public static int GetWidthFromChars(int _charsCount)
        {
            int ret;
            GridColumn _grdCol = new GridColumn();
            Size columnSize = TextRenderer.MeasureText("".PadLeft(_charsCount, 'A'), _grdCol.AppearanceCell.Font);
            ret = columnSize.Width;
            return ret;
        }
        public static void BuildPopupGrid(PopupContainerEdit _control, BaseTypeEnum _type)
        {
            var gc = new GridControl() { Name = $"{_type.ToString()}LookupGC" };
            var gv = new GridView() { Name = $"{_type.ToString()}LookupGV" } ;
            var popContainer = new PopupContainerControl();
            gv.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            gv.OptionsDetail.EnableMasterViewMode = false;
            gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gv });
            gc.MainView = gv;
            gc.Location = new System.Drawing.Point(0, 0);
            gc.Dock = System.Windows.Forms.DockStyle.Fill;
            popContainer.Controls.Add(gc);
            popContainer.Size = new Size(500, 300);
            _control.Properties.PopupControl = popContainer;

            SetupGridView(_type, gv);


            _control.Properties.QueryResultValue += (s, e) => {

            };
            _control.Properties.EditValueChanged += (s, e) => {

            };
            _control.Properties.Popup += (s, e) => {

            };


        }
       
        public static void SetupGridView(BaseTypeEnum _type, GridView _gv)
        {
            _gv.OptionsBehavior.AutoPopulateColumns = false;
            _gv.OptionsSelection.MultiSelect = true;
            _gv.OptionsView.ColumnAutoWidth = false;
            _gv.OptionsView.ShowAutoFilterRow = true;
            _gv.OptionsView.EnableAppearanceOddRow= true;

            switch (_type)
            {
                case BaseTypeEnum.MainAccount:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetMainAccountList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = MainAccount.LineBaseFields.Id ,Width=PopupLookup.GetWidthFromChars(8)});
                    _gv.Columns.Add(new GridColumn() { FieldName = MainAccount.AccountBaseFields.ReferenceNum ,Width = GetWidthFromChars(10)});
                    _gv.Columns.Add(new GridColumn() { FieldName = MainAccount.AccountBaseFields.Name, Width = GetWidthFromChars(60) });
                    _gv.Columns.Add(new GridColumn() { FieldName = MainAccount.MainAccountFields.MainAccountType , Width = GetWidthFromChars(8) });
                    
                    break;
                case BaseTypeEnum.Customer:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetCustomerList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Customer.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Customer.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Customer.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.Vendor:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetVendorList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Vendor.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Vendor.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Vendor.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.JournalType:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetJournalTypeList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = JournalType.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = JournalType.JournalTypeFields.JourName, Width = PopupLookup.GetWidthFromChars(40) });
                    _gv.Columns.Add(new GridColumn() { FieldName = JournalType.JournalTypeFields.JourType, Width = PopupLookup.GetWidthFromChars(25) });

                    break;
                case BaseTypeEnum.Bank:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetBankList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Bank.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Bank.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(15) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Bank.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(50) });

                    break;
                case BaseTypeEnum.Employee:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetEmployeeList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Employee.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Employee.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Employee.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Employee.EmployeeBaseFields.InsuranceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Employee.EmployeeBaseFields.IdentityCard, Width = PopupLookup.GetWidthFromChars(20) });
                    break;
                case BaseTypeEnum.Pos:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetPosList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Pos.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Pos.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Pos.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.Cash:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetCashList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Cash.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Cash.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Cash.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.Purpose:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetPurposeList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Purpose.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Purpose.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Purpose.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.Project:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetProjectList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Project.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Project.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Project.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.Equipment:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetEquipmentList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Equipment.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Equipment.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Equipment.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.Department:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetDepartmentList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Department.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Department.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Department.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.Site:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetSiteList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = Site.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Site.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = Site.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.InventStore:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetInventStoreList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = InventStore.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = InventStore.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = InventStore.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.BusinessUnit:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetBusinessUnitList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = BusinessUnit.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = BusinessUnit.BusinessUnitFields.BusinessUnitCode, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = BusinessUnit.BusinessUnitFields.BusinessUnitName, Width = PopupLookup.GetWidthFromChars(60) });

                    break;
                case BaseTypeEnum.ItemInventory:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetItemInventoryList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = ItemInventory.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = ItemInventory.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = ItemInventory.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });
                    _gv.Columns.Add(new GridColumn() { FieldName = ItemInventory.ItemFields.SalesPrice, Width = PopupLookup.GetWidthFromChars(8) });

                    break;
                case BaseTypeEnum.ItemService:
                    _gv.GridControl.DataSource = new BindingSource() { DataSource = GLDimLists.GetItemServiceList() };
                    _gv.Columns.Add(new GridColumn() { FieldName = ItemService.LineBaseFields.Id, Width = PopupLookup.GetWidthFromChars(8) });
                    _gv.Columns.Add(new GridColumn() { FieldName = ItemService.AccountBaseFields.ReferenceNum, Width = PopupLookup.GetWidthFromChars(10) });
                    _gv.Columns.Add(new GridColumn() { FieldName = ItemService.AccountBaseFields.Name, Width = PopupLookup.GetWidthFromChars(60) });
                    _gv.Columns.Add(new GridColumn() { FieldName = ItemService.ItemFields.SalesPrice, Width = PopupLookup.GetWidthFromChars(8) });

                    break;
                default:
                    break;
            }
        }

    }
}
