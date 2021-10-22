using B_PowerWin.DB;
using B_PowerWin.GUI.Grid;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.GUI.CustomLookup
{
   public class LookupManager
    {
        public static GL_Lookups GL_LookupStorage { get; set; }

        public static void ApplyGVLookup(GridViewBase _gv, GridColumn _gvcol, DB.UILabelAutoLookup _lookUpCode,string _FilterExp="")
        {
            if(GL_LookupStorage == null) { GL_LookupStorage = new GL_Lookups(); }

            var lov = GL_LookupStorage.GetLookupObject(_lookUpCode, _FilterExp);
            _gvcol.ColumnEdit = lov;
        }




    }
}
