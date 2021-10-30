using B_PowerWin.GUI;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace B_PowerWin.Sec
{
    public partial class SecPrincipalEditorFrm : B_PowerWin.GUI.EditFormBase
    {
        public DB.SecPrincipalRole PrincipalRole { get; set; }
        public SecPrincipalEditorFrm():base()
        {
            InitializeComponent();
        }
        public SecPrincipalEditorFrm(FormArgs _callerArgs):base(_callerArgs)
        {
            InitializeComponent();
            FormArgs.CallerFormArgs = _callerArgs;
            InitData();
        }
        protected override void AdjustFormScrollbars(bool displayScrollbars)
        {
            displayScrollbars = true;
            base.AdjustFormScrollbars(displayScrollbars);
        }
        private void InitData()
        {
            dbContext = new AppDbContext();
            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(membersGC);

            membersBindingSource.AddingNew += MembersBindingSource_AddingNew;
          

            RefreshData();
        }

        private void MembersBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DB.SecPrincipalRoleMem()
            { RolePrincipalId = PrincipalRole.PrincipalId,
                EffectiveFrom = DateTime.Today.AddDays(-1).Date,
                EffectiveTo = DateTime.Today.AddYears(10).Date
                
            };
        }

        public override void RefreshData()
        {
            
            PrincipalRole = this.FormArgs.CallerFormArgs.CurrentObject as DB.SecPrincipalRole;
            dbContext.SecPrincipalRoleMems.Where(x => x.RolePrincipalId == PrincipalRole.PrincipalId).Load();
            var memberList = dbContext.Database.SqlQuery<DB.SecPrincipal>("SELECT PrincipalId,PrincipalName,RoleType FROM sec_principal where RoleType in (@P0, @P1) ", DB.SecAccessTypeTypeEnum.Responsibility, DB.SecAccessTypeTypeEnum.User).ToList();
            secPrincipalBindingSource.DataSource = memberList;
            membersBindingSource.DataSource = dbContext.SecPrincipalRoleMems.Local;
            membersBindingSource.ResetBindings(true);
            membersGC.DataSource = membersBindingSource;
            base.RefreshData();
        }
    }
}
