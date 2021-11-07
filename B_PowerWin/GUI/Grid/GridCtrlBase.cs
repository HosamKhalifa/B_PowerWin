using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace B_PowerWin.GUI.Grid
{
    [ToolboxItem(true)]
    public class GridCtrlBase : GridControl
    {
        public AppDbContext dbContext { get; set; }

        protected override BaseView CreateDefaultView()
        {
            return CreateView("GridViewBase");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new GridViewBaseInfoRegistrator());
        }
    }

    public class GridViewBaseInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName
        {
            get
            {
                return "GridViewBase";
            }
        }

        public override BaseView CreateView(GridControl grid)
        {
            return new GridViewBase(grid);
        }

        public override BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new GridViewBaseInfo(view as GridViewBase);
        }

        public override BaseViewHandler CreateHandler(BaseView view)
        {
            return new GridViewBaseHandler(view as GridViewBase);
        }

        public override BaseViewPainter CreatePainter(BaseView view)
        {
            return new GridViewBasePainter(view as GridViewBase);
        }
    }

    public class GridViewBase : DevExpress.XtraGrid.Views.Grid.GridView
    {
        private DB.BaseTypeEnum fBaseTypeEnum = DB.BaseTypeEnum.None;
        private GridViewEditModeEnum fGridViewEditMode = GridViewEditModeEnum.FormEdit;
        private bool fEnableAutoFormat = false;
        public GridViewEditModeEnum GridViewEditMode {get { return fGridViewEditMode; }set { fGridViewEditMode = value; } }
        public DB.BaseTypeEnum BaseTypeEnum { get { return fBaseTypeEnum; } set { fBaseTypeEnum = value; } }
        public bool EnableAutoFormat { get { return  fEnableAutoFormat; }set { fEnableAutoFormat = value; } }
        public void EnableEditButtons()
        {
            var gc = this.GridControl;
            gc.UseEmbeddedNavigator = GridViewEditMode != GridViewEditModeEnum.ReadOnly;
            ControlNavigator cn = (ControlNavigator)gc.EmbeddedNavigator;
            cn.Buttons.Remove.Enabled = GridViewEditMode != GridViewEditModeEnum.ReadOnly;
            cn.Buttons.Append.Enabled = GridViewEditMode != GridViewEditModeEnum.ReadOnly;
            cn.Buttons.Edit.Enabled = GridViewEditMode != GridViewEditModeEnum.ReadOnly;
            this.OptionsBehavior.AllowAddRows = GridViewEditMode == GridViewEditModeEnum.ReadOnly?DevExpress.Utils.DefaultBoolean.False:DevExpress.Utils.DefaultBoolean.Default;
            this.OptionsBehavior.AllowDeleteRows = GridViewEditMode == GridViewEditModeEnum.ReadOnly ? DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.Default;
            this.OptionsBehavior.Editable = GridViewEditMode != GridViewEditModeEnum.ReadOnly;

            if (GridViewEditMode == GridViewEditModeEnum.FormEdit )
            {
                this.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;
                this.OptionsEditForm.BindingMode = EditFormBindingMode.Cached;
                this.OptionsEditForm.EditFormColumnCount = 2;
            }

        }
        public GridViewBase()
        {
            //Labels
            //Should calling after datasource settings ApplyLabelToColumns();
            this.DataSourceChanged += (s, e) =>
            {
                if (!this.DesignMode)
                {
                    
                    if (this.DataSource != null)                                //Level 1
                    {
                        this.BeginInit();
                        GridManager.InitGuiFromDB(gv:this,EnableAutoFormat:this.EnableAutoFormat);
                                                                                
                        this.EndInit();
                        this.GridControl.ForceInitialize();
                    }
             
                }


            };


        }

        public GridViewBase(GridControl grid) : base(grid)
        {
        }

        protected override string ViewName
        {
            get
            {
                return "GridViewBase";
            }
        }
    }

    public class GridViewBaseInfo : DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo
    {
        public GridViewBaseInfo(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class GridViewBaseHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler
    {
        public GridViewBaseHandler(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class GridViewBasePainter : DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter
    {
        public GridViewBasePainter(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }
}
