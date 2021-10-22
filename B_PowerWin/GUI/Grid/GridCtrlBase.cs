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

namespace B_PowerWin.GUI.Grid
{
    [ToolboxItem(true)]
    public class GridCtrlBase : GridControl
    {
       

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
        public DB.BaseTypeEnum BaseTypeEnum { get { return fBaseTypeEnum; } set { fBaseTypeEnum = value; } }
        public GridViewBase()
        {

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
