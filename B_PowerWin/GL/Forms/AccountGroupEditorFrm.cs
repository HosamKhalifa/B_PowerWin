using B_PowerWin.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.GL.Forms
{
    public partial class AccountGroupEditorFrm : B_PowerWin.GUI.EditFormBase
    {
        BaseType groupBaseType;
        public AccountGroupEditorFrm(BaseTypeEnum _GroupedBaseType):base()
        {
            InitializeComponent();
            groupBaseType = MySession.Session.Database.BaseTypes.Find((int)_GroupedBaseType);
            this.Text = $"Edit : {groupBaseType.BaseTypeName}";
            InitData();
        }
        public override void RefreshData()
        {
            dbContext.AccountGroups.Where(x => x.GroupedBaseTypeId == groupBaseType.BaseTypeId).Load();
            accountGroupBindingSource.DataSource = dbContext.AccountGroups.Local;
            accountGroupBindingSource.ResetBindings(true);
            base.RefreshData();
        }
        private void InitData()
        {
            dbContext = new AppDbContext();
            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(accountGroupGC);
            accountGroupBindingSource.AddingNew += (s, e) => {
                e.NewObject = new AccountGroup() {GroupedBaseTypeId = groupBaseType.BaseTypeId,ReferenceNum = "00",WFStatus = WorkflowStatusEnum.Draft };
                
            };
            RefreshData();
        }
    }
}
