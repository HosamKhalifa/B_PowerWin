using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;

namespace B_PowerWin.GUI
{
    [UserRepositoryItem("RegisterLookupBase")]
    public class RepositoryItemLookupBase : RepositoryItemLookUpEdit
    {
        static RepositoryItemLookupBase()
        {
            RegisterLookupBase();
        }

        public const string CustomEditName = "LookupBase";

        public RepositoryItemLookupBase()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegisterLookupBase()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(LookupBase), typeof(RepositoryItemLookupBase), typeof(LookupBaseViewInfo), new LookupBasePainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemLookupBase source = item as RepositoryItemLookupBase;
                if (source == null) return;
                //
            }
            finally
            {
                EndUpdate();
            }
        }
    }

    [ToolboxItem(true)]
    public class LookupBase : LookUpEdit
    {
        static LookupBase()
        {
            RepositoryItemLookupBase.RegisterLookupBase();
        }

        public LookupBase()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemLookupBase Properties
        {
            get
            {
                return base.Properties as RepositoryItemLookupBase;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemLookupBase.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new LookupBasePopupForm(this);
        }
    }

    public class LookupBaseViewInfo : LookUpEditViewInfo
    {
        public LookupBaseViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class LookupBasePainter : ButtonEditPainter
    {
        public LookupBasePainter()
        {
        }
    }

    public class LookupBasePopupForm : PopupLookUpEditForm
    {
        public LookupBasePopupForm(LookupBase ownerEdit) : base(ownerEdit)
        {
        }
    }
}
