using B_PowerWin.DB;
using B_PowerWin.GUI.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Drawing;

namespace B_PowerWin.GUI.CustomLookup
{
   public class LookupManager
    {
        static string PRRFIX = "LOOKUP_MGR_";
        public static GL_Lookups GL_LookupStorage { get; set; }

        public static void ApplyGVLookup(GridViewBase _gv, GridColumn _gvcol, DB.UILabelAutoLookup _lookUpCode,string _FilterExp="")
        {
            if(GL_LookupStorage == null) { GL_LookupStorage = new GL_Lookups(); }

            var lov = GL_LookupStorage.GetLookupObject(_lookUpCode, _FilterExp);
            _gv.GridControl.ExternalRepository = GL_LookupStorage.MyLookupPR;
            _gvcol.ColumnEdit = lov;
        }
     
        public static RepositoryItemLookUpEdit CompanyGrdLookup(AppDbContext _db, GridViewBase _gv, GridColumn _gvcol, string _Filter)
        {
            var bs = new BindingSource() { Filter = _Filter };
            _db.Companies.Load();
            bs.DataSource = _db.Companies.Local;
            var ret = new RepositoryItemLookUpEdit() {
                Name = $"{PRRFIX}COMPANY_LOV",
                DataSource = bs,
                DisplayMember = "CompanyName",
                ValueMember = "Id",
                KeyMember = "Id",
                PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains,
            };
            ret.Columns.Add(new LookUpColumnInfo() { FieldName = "Id", Caption = "Id", Width = 10 });
            ret.Columns.Add(new LookUpColumnInfo() { FieldName = "CompanyName", Caption = "Name", Width = 60 });
            ret.Columns.Add(new LookUpColumnInfo() { FieldName = "Address", Caption = "Address", Width = 30 });




            if (_gv.GridControl.RepositoryItems.Contains(ret))
            {
                _gvcol.ColumnEditName = ret.Name;
            }
            else
            {
                _gv.GridControl.RepositoryItems.Add(ret);
                _gvcol.ColumnEditName = ret.Name;
            }
            return ret;
        }
        public static RepositoryItemLookUpEdit AccountGroup(AppDbContext _db, GridViewBase _gv, GridColumn _gvcol,BaseTypeEnum _GroupedBaseType)
        {
            Image limg_Ellipsis = DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/copy_16x16.png");
            var bs = new BindingSource() ;
            _db.AccountGroups.Where(x => x.GroupedBaseTypeId == (int)_GroupedBaseType).Load();
            bs.DataSource = _db.AccountGroups.Local;
            var ret = new RepositoryItemLookUpEdit()
            {

                Name = $"{PRRFIX}ACC_GRP_{_GroupedBaseType.ToString()}_LOV",
                DataSource = bs,
                DisplayMember = "FullName",
                ValueMember = "Id",
                KeyMember = "Id",
                PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains,
            };
            ret.Columns.Add(new LookUpColumnInfo() { FieldName = "Id", Caption = "Id", Width = 10 });
            ret.Columns.Add(new LookUpColumnInfo() { FieldName = "FullName", Caption = "Name", Width = 55 });
            
            //Buttons setup
            ret.Buttons.Add(
                new EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit...", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, limg_Ellipsis )
                );
            //Buttons event handlers
            ret.ButtonClick += (s, e) => {
                if(e.Button.Kind == ButtonPredefines.Ellipsis)
                {
                    GL.Forms.AccountGroupEditorFrm frm = new GL.Forms.AccountGroupEditorFrm(_GroupedBaseType) { StartPosition = FormStartPosition.CenterParent};
                    frm.FormClosing += (l_s, l_e) => {
                        _db.AccountGroups.Where(x => x.GroupedBaseTypeId == (int)_GroupedBaseType).Load();
                    };
                    frm.ShowDialog();
                }
            };
            if (_gv.GridControl.RepositoryItems.Contains(ret))
            {
                _gvcol.ColumnEditName = ret.Name;
            }
            else
            {
                _gv.GridControl.RepositoryItems.Add(ret);
                _gvcol.ColumnEditName = ret.Name;
            }



            return ret;
        }

        public static RepositoryItemLookUpEdit AccountBase(AppDbContext _db, GridViewBase _gv, GridColumn _gvcol, BaseTypeEnum _BaseType)
        {
            
            var bs = new BindingSource();
            _db.Accounts.Where(x => x.BaseType == (int)_BaseType).Load();
            bs.DataSource = _db.Accounts.Local;
            var ret = new RepositoryItemLookUpEdit()
            {

                Name = $"{PRRFIX}ACC_BASE_{_BaseType.ToString()}_LOV",
                DataSource = bs,
                DisplayMember = "FullName",
                ValueMember = "Id",
                KeyMember = "Id",
                PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains,
            };
            ret.Columns.Add(new LookUpColumnInfo() { FieldName = "Id", Caption = "Id", Width = 10 });
            ret.Columns.Add(new LookUpColumnInfo() { FieldName = "FullName", Caption = "Name", Width = 90 });

            ////Buttons setup
            //ret.Buttons.Add(
            //    new EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit...", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, limg_Ellipsis)
            //    );
            ////Buttons event handlers
            //ret.ButtonClick += (s, e) => {
            //    if (e.Button.Kind == ButtonPredefines.Ellipsis)
            //    {
            //        GL.Forms.AccountGroupEditorFrm frm = new GL.Forms.AccountGroupEditorFrm(_GroupedBaseType) { StartPosition = FormStartPosition.CenterParent };
            //        frm.FormClosing += (l_s, l_e) => {
            //            _db.AccountGroups.Where(x => x.GroupedBaseTypeId == (int)_GroupedBaseType).Load();
            //        };
            //        frm.ShowDialog();
            //    }
            //};
            if (_gv.GridControl.RepositoryItems.Contains(ret))
            {
                _gvcol.ColumnEditName = ret.Name;
            }
            else
            {
                _gv.GridControl.RepositoryItems.Add(ret);
                _gvcol.ColumnEditName = ret.Name;
            }



            return ret;
        }


    }
}
