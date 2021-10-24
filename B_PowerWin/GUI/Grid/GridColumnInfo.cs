using B_PowerWin.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.GUI.Grid
{
    public class GridColumnInfo
    {

        public UILabel ColumnLablel { get; set; }
        public FormArgs FormArgs { get; set; }
        //  public string LookupValue { get; set; }//Value of current row for lookup field
        public bool IsViewDetails
        {
            get
            {
                return ColumnLablel != null && ColumnLablel.Grid_LookupFormRef != DB.FormEntityEnum.None;
            }
        }



    }
}
