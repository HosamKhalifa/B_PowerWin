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

namespace B_PowerWin.GL.UXC
{
    public partial class UserParamSelectXUC : DevExpress.XtraEditors.XtraUserControl
    {
        AppDbContext dbContext;
        public UserParamSelectXUC()
        {
            InitializeComponent();
            InitData();
        }
        public void SetBaseTypeParams(DB.BaseTypeEnum _QueryBaseType,params string[] _FiledsToShow)
        {
            this.BaseType = _QueryBaseType;
            ItemForStartDate.Visibility = _FiledsToShow.Count(x => x == DB.GUI.UserParameter.UserParameterFields.StartDate) > 0?DevExpress.XtraLayout.Utils.LayoutVisibility.Always:DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            ItemForEndDate.Visibility = _FiledsToShow.Count(x => x == DB.GUI.UserParameter.UserParameterFields.EndDate) > 0 ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            ItemForCustomerListExp.Visibility = _FiledsToShow.Count(x => x == DB.GUI.UserParameter.UserParameterFields.CustomerListExp) > 0 ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            ItemForSiteListExp.Visibility = _FiledsToShow.Count(x => x == DB.GUI.UserParameter.UserParameterFields.SiteListExp) > 0 ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            ItemForStoreListExp.Visibility = _FiledsToShow.Count(x => x == DB.GUI.UserParameter.UserParameterFields.StoreListExp) > 0 ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            ItemForVendorListExp.Visibility = _FiledsToShow.Count(x => x == DB.GUI.UserParameter.UserParameterFields.VendorListExp) > 0 ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            
            InitData();

        }
        public DB.BaseTypeEnum BaseType { get; private set; }

        private void InitData()
        {
            dbContext = new AppDbContext();
            userParameterBindingSource.DataSource = dbContext.UserParameters.Local;
            userParameterBindingSource.AddingNew += (s, e) => {
                e.NewObject = new DB.GUI.UserParameter() {UserKey = MySession.Session.UserKey,QueryBaseType = this.BaseType };
            };
            
        }
    }
}
