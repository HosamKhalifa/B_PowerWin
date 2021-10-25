using B_PowerWin.GUI.Grid;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_PowerWin.DB
{
    [Table("ui_label")]
    public class UILabel
    {
        public void ApplyFieldSettings(GridViewBase gv, GridColumn grdCol, bool enableAutoFormat)
        {
            //Avoid access to null when field is complex name Like Name!Key or Name!
            var c = gv.Columns[FieldName];
            if (c == null)
            {
                Debug.WriteLine($"{FieldName} has been scapped from apply settings");
                return;
            }

            //Save Column information in grid column Tag
            GridColumnInfo info = new GridColumnInfo() { ColumnLablel = this };
            grdCol.Tag = info;
            // gv.Columns.Remove()
            var captionRow = MySession.Session.Database.UILabelTxts.Where(x => x.LabelId == LabelId && x.LabelType == UILabelType.FieldCaption && x.LangId == MySession.Session.LangId).FirstOrDefault();
            var toolTipRow = MySession.Session.Database.UILabelTxts.Where(x => x.LabelId == LabelId && x.LabelType == UILabelType.FieldHelp && x.LangId == MySession.Session.LangId).FirstOrDefault();
            c.Caption = captionRow?.Txt;
            c.ToolTip = toolTipRow?.Txt;

            if (!enableAutoFormat) return;//Exit for non formated grid view after wirting caption 


            //Size columnSize = TextRenderer.MeasureText("".PadLeft(Grid_Width, 'A'), grdCol.AppearanceCell.Font);
            //c.Width = Grid_IsHidden ? 0 : columnSize.Width;
            c.Width = Grid_IsHidden ? 0  : Grid_Width ;
            c.OptionsColumn.ReadOnly = Grid_IsDisabled;
            c.OptionsColumn.AllowEdit = !Grid_IsDisabled;
            c.OptionsEditForm.Visible = Grid_IsDisabled ? DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.Default;

            c.Visible = !Grid_IsHidden;
            c.VisibleIndex = Grid_IsHidden ? -1 : Grid_VisibleOrder;
            c.OptionsEditForm.VisibleIndex = Grid_IsHidden ? -1 : Grid_VisibleOrder;

        }

        [Key,StringLength(200)]
        public string LabelId { get; set; }/*ClassName.FieldName */
        [StringLength(200)]
        public string FieldName { get; set; }
        public BaseType BaseType { get; set; }
        public UILabelAutoLookup LookupCode { get; set; }
        [StringLength(200)]
        public string LookupFilterExp { get; set; }
        public bool Grid_IsHidden { get; set; }
        public bool Grid_IsDisabled { get; set; }
        public int Grid_Width { get; set; }
        public int Grid_VisibleOrder { get; set; }
        public FormEntityEnum Grid_LookupFormRef { get; set; }

        public List<UILabelLangTxt> LangTxts { get; set; }



    }
}
