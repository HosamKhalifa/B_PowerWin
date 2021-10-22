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
using System.Linq.Expressions;
using B_PowerWin.GUI.Grid;
using DevExpress.XtraGrid.Columns;

namespace B_PowerWin.GUI.CustomLookup
{
    public partial class GL_Lookups : DevExpress.XtraEditors.XtraUserControl
    {
        #region InMemoryStorage
        public IQueryable<MainAccount> MainAccountLOV { get; set; }
      

        #endregion


        public GL_Lookups()
        {
            InitializeComponent();
            
            
        }
        public DevExpress.XtraEditors.Repository.RepositoryItem GetLookupObject(DB.UILabelAutoLookup _lookUpCode, string _FilterExp = "")
        {
            DevExpress.XtraEditors.Repository.RepositoryItem repItem = null;
            switch (_lookUpCode)
            {
              
                case UILabelAutoLookup.Customer:
                    break;
                case UILabelAutoLookup.CustGroup:
                    break;
                case UILabelAutoLookup.Vendor:
                    break;
                case UILabelAutoLookup.VendGroup:
                    break;
                case UILabelAutoLookup.Item:
                    break;
                case UILabelAutoLookup.ItemVariants:
                    break;
                case UILabelAutoLookup.ItemGroup:
                    break;
                case UILabelAutoLookup.MainAccount:
                   
                    mainAccountBS.DataSource = MySession.Session.Database.MainAccounts.Local;
                    mainAccountBS.Filter = _FilterExp;

                     repItem = MyLookupPR.Items[mainAccountSLookupGV.Name];
                    
                    break;
                case UILabelAutoLookup.MainAccountGroup:
                    break;
                case UILabelAutoLookup.MainAccountChild:
                    break;
                case UILabelAutoLookup.MainAccountTotal:
                    break;
                default:
                    break;
            }
            return repItem;
        }
        public void LoadMainAccountLOV(Expression<Func<MainAccount, bool>> predicate =null,bool _refreshFromDB=false)
        {
            if(MainAccountLOV == null || _refreshFromDB)//Query DB is required
            {

                MainAccountLOV = predicate != null ? MySession.Session.Database.MainAccounts.Where(predicate ) : MySession.Session.Database.MainAccounts;
            }
            MainAccountLOV = MainAccountLOV.Where(predicate);

            //Link to Binding source
           
        }
        
    }
}
