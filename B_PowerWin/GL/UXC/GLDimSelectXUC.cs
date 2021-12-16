using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using B_PowerWin.DB;

namespace B_PowerWin.GL.UXC
{
    public partial class GLDimSelectXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public DocumentLine LineBase { get; set; }
        public DimDefault   DefaultDimension { get; set; }
        public LedgerLineTypeEnum LedgerLineType { get; set; }
        public GLDimSelectXUC()
        {
            InitializeComponent();
           

            
        }

        private void IniObj(LedgerLineTypeEnum _LedgerLineTypeEnum)
        {
            LedgerLineType = _LedgerLineTypeEnum;
            LayoutControls(_LedgerLineTypeEnum);
            InitLookupDataSource(_LedgerLineTypeEnum);

        }

        private void InitLookupDataSource(LedgerLineTypeEnum _ledgerLineType)
        {

            mainAccountBindingSource.DataSource = GLDimLists.GetMainAccountList().Where(x => !x.IsTotal && !x.DisableManualEntry && x.LedgerCOAId == MySession.Session.Company.COA);
            businessUnitBindingSource.DataSource = GLDimLists.GetBusinessUnitList();
            siteBindingSource.DataSource = GLDimLists.GetSiteList();
            departmentBindingSource.DataSource = GLDimLists.GetDepartmentList();
            equipmentBindingSource.DataSource = GLDimLists.GetEquipmentList();
            projectBindingSource.DataSource = GLDimLists.GetProjectList();
            purposeBindingSource.DataSource = GLDimLists.GetPurposeList();
            bankBindingSource.DataSource = GLDimLists.GetBankList();
            cashBindingSource.DataSource = GLDimLists.GetCashList();
            customerBindingSource.DataSource = GLDimLists.GetCustomerList();
            vendorBindingSource.DataSource = GLDimLists.GetVendorList();
            employeeBindingSource.DataSource = GLDimLists.GetEmployeeList();
            posBindingSource.DataSource = GLDimLists.GetPosList();
            

        }

        private void LayoutControls(LedgerLineTypeEnum _ledgerLineType)
        {
            mainDataLayoutCtrl.SuspendLayout();
            mainDataLayoutCtrl.Items.Clear();

            mainDataLayoutCtrl.AddItem(ItemForLedgerActType); ItemForLedgerActType.Enabled = false;
            mainDataLayoutCtrl.AddItem(ItemForMainAccount); ItemForMainAccount.Enabled = false;

            switch (_ledgerLineType)
            {
                case LedgerLineTypeEnum.Ledger:
                    ItemForMainAccount.Enabled = true;
                    mainDataLayoutCtrl.AddItem(ItemForMainAccount);
                    mainDataLayoutCtrl.AddItem(ItemForBusinessUnitId);
                    mainDataLayoutCtrl.AddItem(ItemForSiteId);
                    mainDataLayoutCtrl.AddItem(ItemForDeptId);
                    mainDataLayoutCtrl.AddItem(ItemForEqupId);
                    mainDataLayoutCtrl.AddItem(ItemForProjectId);
                    mainDataLayoutCtrl.AddItem(ItemForPurposeId);
                    mainDataLayoutCtrl.AddItem(ItemForBankId);
                    mainDataLayoutCtrl.AddItem(ItemForCashId);
                    mainDataLayoutCtrl.AddItem(ItemForCustId);
                    mainDataLayoutCtrl.AddItem(ItemForVendId);
                    mainDataLayoutCtrl.AddItem(ItemForEmplId);
                    mainDataLayoutCtrl.AddItem(ItemForPosId);
                    break;
                case LedgerLineTypeEnum.Cust:
                    mainDataLayoutCtrl.AddItem(ItemForMainAccount);
                    mainDataLayoutCtrl.AddItem(ItemForCustId);
                    mainDataLayoutCtrl.AddItem(ItemForBusinessUnitId);
                    mainDataLayoutCtrl.AddItem(ItemForSiteId);
                    mainDataLayoutCtrl.AddItem(ItemForDeptId);
                    mainDataLayoutCtrl.AddItem(ItemForEqupId);
                    mainDataLayoutCtrl.AddItem(ItemForProjectId);
                    mainDataLayoutCtrl.AddItem(ItemForPurposeId);
                    mainDataLayoutCtrl.AddItem(ItemForBankId);
                    mainDataLayoutCtrl.AddItem(ItemForCashId);
                    mainDataLayoutCtrl.AddItem(ItemForVendId);
                    mainDataLayoutCtrl.AddItem(ItemForEmplId);
                    mainDataLayoutCtrl.AddItem(ItemForPosId);

                    break;
                case LedgerLineTypeEnum.Vend:
                    mainDataLayoutCtrl.AddItem(ItemForMainAccount);
                    mainDataLayoutCtrl.AddItem(ItemForVendId);
                    mainDataLayoutCtrl.AddItem(ItemForBusinessUnitId);
                    mainDataLayoutCtrl.AddItem(ItemForSiteId);
                    mainDataLayoutCtrl.AddItem(ItemForDeptId);
                    mainDataLayoutCtrl.AddItem(ItemForEqupId);
                    mainDataLayoutCtrl.AddItem(ItemForProjectId);
                    mainDataLayoutCtrl.AddItem(ItemForPurposeId);
                    mainDataLayoutCtrl.AddItem(ItemForBankId);
                    mainDataLayoutCtrl.AddItem(ItemForCashId);
                    mainDataLayoutCtrl.AddItem(ItemForCustId);
                    mainDataLayoutCtrl.AddItem(ItemForEmplId);
                    mainDataLayoutCtrl.AddItem(ItemForPosId);
                    break;
                case LedgerLineTypeEnum.Bank:
                    mainDataLayoutCtrl.AddItem(ItemForMainAccount);
                    mainDataLayoutCtrl.AddItem(ItemForBankId);
                    mainDataLayoutCtrl.AddItem(ItemForBusinessUnitId);
                    mainDataLayoutCtrl.AddItem(ItemForSiteId);
                    mainDataLayoutCtrl.AddItem(ItemForDeptId);
                    mainDataLayoutCtrl.AddItem(ItemForEqupId);
                    mainDataLayoutCtrl.AddItem(ItemForProjectId);
                    mainDataLayoutCtrl.AddItem(ItemForPurposeId);
                    mainDataLayoutCtrl.AddItem(ItemForCashId);
                    mainDataLayoutCtrl.AddItem(ItemForCustId);
                    mainDataLayoutCtrl.AddItem(ItemForVendId);
                    mainDataLayoutCtrl.AddItem(ItemForEmplId);
                    mainDataLayoutCtrl.AddItem(ItemForPosId);
                    break;
                case LedgerLineTypeEnum.Cash:
                    mainDataLayoutCtrl.AddItem(ItemForMainAccount);
                    mainDataLayoutCtrl.AddItem(ItemForCashId);
                    mainDataLayoutCtrl.AddItem(ItemForBusinessUnitId);
                    mainDataLayoutCtrl.AddItem(ItemForSiteId);
                    mainDataLayoutCtrl.AddItem(ItemForDeptId);
                    mainDataLayoutCtrl.AddItem(ItemForEqupId);
                    mainDataLayoutCtrl.AddItem(ItemForProjectId);
                    mainDataLayoutCtrl.AddItem(ItemForPurposeId);
                    mainDataLayoutCtrl.AddItem(ItemForBankId);
                    mainDataLayoutCtrl.AddItem(ItemForCustId);
                    mainDataLayoutCtrl.AddItem(ItemForVendId);
                    mainDataLayoutCtrl.AddItem(ItemForEmplId);
                    mainDataLayoutCtrl.AddItem(ItemForPosId);
                    break;
                case LedgerLineTypeEnum.FixedAsset:
                    mainDataLayoutCtrl.AddItem(ItemForMainAccount);
                    mainDataLayoutCtrl.AddItem(ItemForEqupId);
                    mainDataLayoutCtrl.AddItem(ItemForBusinessUnitId);
                    mainDataLayoutCtrl.AddItem(ItemForSiteId);
                    mainDataLayoutCtrl.AddItem(ItemForDeptId);
                    mainDataLayoutCtrl.AddItem(ItemForProjectId);
                    mainDataLayoutCtrl.AddItem(ItemForPurposeId);
                    mainDataLayoutCtrl.AddItem(ItemForBankId);
                    mainDataLayoutCtrl.AddItem(ItemForCashId);
                    mainDataLayoutCtrl.AddItem(ItemForCustId);
                    mainDataLayoutCtrl.AddItem(ItemForVendId);
                    mainDataLayoutCtrl.AddItem(ItemForEmplId);
                    mainDataLayoutCtrl.AddItem(ItemForPosId);
                    break;
                default:
                    break;
            }
            mainDataLayoutCtrl.ResumeLayout();
        }
    }
}
