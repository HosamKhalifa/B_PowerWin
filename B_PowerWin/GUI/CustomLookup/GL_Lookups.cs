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
using System.Data.Entity;
using B_PowerWin.GL.Forms;

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
            InitViewDetailsEvent();



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

                    MySession.Session.Database.MainAccounts.Load();
                    mainAccountBS.DataSource = MySession.Session.Database.MainAccounts.Local;
                    mainAccountBS.Filter = _FilterExp;
                    mainAccountBS.ResetBindings(true);

                     repItem = MyLookupPR.Items[mainAccountSLookupGV.Name];
                    
                    break;
                case UILabelAutoLookup.MainAccountGroup:

                    MySession.Session.Database.MainAccountGroups.Load();
                    mainAccountGroupBS.DataSource = MySession.Session.Database.MainAccountGroups.Local;
                    mainAccountGroupBS.Filter = _FilterExp;
                    mainAccountGroupBS.ResetBindings(true);
                    repItem = MyLookupPR.Items[mainAccountGroupLookup.Name];
                    

                    break;
                case UILabelAutoLookup.SysSequence:
                    MySession.Session.Database.SysSequences.Load();
                    sequBindingSource.DataSource = MySession.Session.Database.SysSequences.Local;
                    sequBindingSource.Filter = _FilterExp;
                    sequBindingSource.ResetBindings(true);
                    repItem = MyLookupPR.Items[sequLookup.Name];

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

        private void mainAccountGroupLookup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                var frm = new MainAccountGroupFrm();
                frm.FormClosing+=(frmS, frmE)=>{
                    MySession.Session.Database.JournalTypes.Load();
                };
                frm.Show();
            }
        }

        private void InitViewDetailsEvent()
        {
            mainAccountGroupLookup.ButtonClick += (s, e) =>
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
                {
                    var frm = new MainAccountGroupFrm() { MdiParent = MySession.Session.MainForm};
                    frm.FormClosing += (frmS, frmE) =>
                    {
                        MySession.Session.Database.MainAccountGroups.Load();
                    };
                    frm.Show();
                }
            };
            //*****************************************************************************************
            mainAccount.ButtonClick += (s, e) =>
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
                {
                    var frm = new MainAccountGroupFrm() { MdiParent = MySession.Session.MainForm };
                    frm.FormClosing += (frmS, frmE) =>
                    {
                        MySession.Session.Database.MainAccounts.Load();
                    };
                    frm.Show(); 
                }
            };
            //*****************************************************************************************
            sequLookup.ButtonClick += (s, e) =>
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
                {
                    var frm = new SysSequenceSetupFrm() { MdiParent = MySession.Session.MainForm };
                    frm.FormClosing += (frmS, frmE) =>
                    {
                        MySession.Session.Database.SysSequences.Load();
                    };
                    frm.Show(); 
                }
            };
            //*****************************************************************************************
            /*
            x.ButtonClick += (s, e) =>
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                {
                    var frm = new SysSequenceSetupFrm();
                    frm.FormClosing += (frmS, frmE) =>
                    {
                        MySession.Session.Database.x.Load();
                    };
                    frm.Show(); 
                }
            };
            
             */
        }

    }
}
