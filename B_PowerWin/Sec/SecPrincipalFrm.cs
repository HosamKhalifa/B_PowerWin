using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using B_PowerWin.GUI.Grid;
using DevExpress.XtraEditors;

namespace B_PowerWin.Sec
{
    public partial class SecPrincipalFrm : B_PowerWin.GUI.EditFormBase
    {
        public SecPrincipalFrm()
        {
            InitializeComponent();
            InitEvents();
            InitData();
        }
        
        private void InitEvents()
        {
            bar2.AddItem(seedAccessTypeBI);
            seedAccessTypeBI.ItemClick +=(s,e)=>{
                if(XtraMessageBox.Show("Seed DB with access type lines?","Seed DB",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DB.SeedDatabase.SeedAccessType(dbContext);
                }
                
            };
            secMasterGV.FocusedRowChanged += RolesGV_FocusedRowChanged; 
            secJournalGV.FocusedRowChanged += RolesGV_FocusedRowChanged;
            secResponsGV.FocusedRowChanged += RolesGV_FocusedRowChanged;
            secReportGV.FocusedRowChanged += RolesGV_FocusedRowChanged;
            secFormGV.FocusedRowChanged += RolesGV_FocusedRowChanged;
            secActionsGV.FocusedRowChanged += RolesGV_FocusedRowChanged;

            secResponsGV.RowClick += GV_RowClick;
            secMasterGV.RowClick += GV_RowClick; ;
            secJournalGV.RowClick += GV_RowClick;
            secReportGV.RowClick += GV_RowClick;
            secFormGV.RowClick += GV_RowClick;
            secActionsGV.RowClick += GV_RowClick;

            



        }

        private void RolesGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var lt_Row = (DB.SecPrincipalRole)(sender as GridViewBase).GetRow(e.FocusedRowHandle);
            ShowDetailRows(lt_Row);
        }

        private void ShowDetailRows(DB.SecPrincipalRole _master)
        {
            //var bs = new BindingSource();
            
            //dbContext.SecPrincipalRoleMems.Where(x => x.RolePrincipalId == _master.PrincipalId).Load();
            //bs.DataSource = dbContext.SecPrincipalRoleMems.Local.ToBindingList();
            //membershipGC.DataSource = bs;
            //bs.AddingNew += (s, e) => {
            //    e.NewObject = new DB.SecPrincipalRoleMem() {Id=DB_Util.LineBaseSequNextVal(dbContext),RolePrincipalId = _master.PrincipalId,EffectiveFrom=DateTime.Today.Date,EffectiveTo=DateTime.Today.AddYears(10).Date };
            //};
                        

            
        }
        public override void RefreshData()
        {
           
            dbContext.SecPrincipalUsers.Load();
            
            dbContext.SecPrincipalRoleResponsibilities.Include(x => x.SecPrincipalRoleMems).Load();
            dbContext.SecPrincipalRoleMasters.Include(x => x.SecPrincipalRoleMems).Load();
            dbContext.SecPrincipalRoleJournals.Include(x => x.SecPrincipalRoleMems).Load();
            dbContext.SecPrincipalRoleReports.Include(x => x.SecPrincipalRoleMems).Load();
            dbContext.SecPrincipalRoleForm.Include(x => x.SecPrincipalRoleMems).Load();
            dbContext.SecPrincipalRoleActions.Include(x => x.SecPrincipalRoleMems).Load();

            secPrincipalUserBindingSource.ResetBindings(false);
            secResponsBindingSource.ResetBindings(false);
            secMasterBindingSource.ResetBindings(false);
            secJournalBindingSource.ResetBindings(false);
            secReportBindingSource.ResetBindings(false);
            secFormBindingSource.ResetBindings(false);
            secActionsBindingSource.ResetBindings(false);

            dbContext.SecPrincipalRoleMems.Load();
            dbContext.SecAccessTypes.Load();
            
           




            base.RefreshData();
        }
        private void InitData()
        {
            dbContext = new AppDbContext();
            FormGridManager = new GUI.Grid.GridManager();

            FormGridManager.Attach(secUserGC, secResponsGC, secMasterGC, secJournalGC, secReportGC, secFormGC,secActionsGC,membershipGC);

            //Lookup 
            GUI.CustomLookup.LookupManager.CompanyGrdLookup(dbContext, secUserGV, colDefaultCompany, "");

            //*********************************Users**********************************************
            dbContext.SecPrincipalUsers.Load();
            secPrincipalUserBindingSource.DataSource = dbContext.SecPrincipalUsers.Local;
            //secUserGV.Columns.ColumnByFieldName("RoleType").OptionsColumn.AllowEdit = false;
            secUserGC.DataSource = secPrincipalUserBindingSource;


            //*********************************Responsibility**********************************************
            dbContext.SecPrincipalRoleResponsibilities.Load();
            secResponsBindingSource.DataSource = dbContext.SecPrincipalRoleResponsibilities.Local;
            secResponsGV.Columns.ColumnByFieldName("RoleType").OptionsColumn.AllowEdit = false;
            secResponsGC.DataSource = secResponsBindingSource;
            //*********************************Master**********************************************
            dbContext.SecPrincipalRoleMasters.Load();
            secMasterBindingSource.DataSource = dbContext.SecPrincipalRoleMasters.Local;
            secMasterGV.Columns.ColumnByFieldName("RoleType").OptionsColumn.AllowEdit = false;
            secMasterGC.DataSource = secMasterBindingSource;
            //*********************************Journal**********************************************
            dbContext.SecPrincipalRoleJournals.Load();
            secJournalBindingSource.DataSource = dbContext.SecPrincipalRoleJournals.Local;
            secJournalGV.Columns.ColumnByFieldName("RoleType").OptionsColumn.AllowEdit = false;
            secJournalGC.DataSource = secJournalBindingSource;
            //*********************************SysOutputReport**********************************************
            dbContext.SecPrincipalRoleReports.Load();
            secReportBindingSource.DataSource = dbContext.SecPrincipalRoleReports.Local;
            secReportGV.Columns.ColumnByFieldName("RoleType").OptionsColumn.AllowEdit = false;
            secReportGC.DataSource = secReportBindingSource;
            //*********************************SysDisplayForm**********************************************
            dbContext.SecPrincipalRoleForm.Load();
            secFormBindingSource.DataSource = dbContext.SecPrincipalRoleForm.Local;
            secFormGV.Columns.ColumnByFieldName("RoleType").OptionsColumn.AllowEdit = false;
            secFormGC.DataSource = secFormBindingSource;
            //*********************************SysAction**********************************************
            dbContext.SecPrincipalRoleActions.Load();
            secActionsBindingSource.DataSource = dbContext.SecPrincipalRoleActions.Local;
            secActionsGV.Columns.ColumnByFieldName("RoleType").OptionsColumn.AllowEdit = false;
            secActionsGC.DataSource = secActionsBindingSource;

            RefreshData();

        }

        private void GV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks > 1 && e.RowHandle >= 0)
            {
                var line = (sender as GridViewBase).GetRow(e.RowHandle)as DB.SecPrincipalRole;
                if(line != null)
                {
                    Sec.SecPrincipalEditorFrm frm = new SecPrincipalEditorFrm(this.FormArgs)
                    { Text = $"Edit {line.PrincipalFullName}"};
                    
                    frm.ShowDialog();
                }
            }
        }
    }
}
