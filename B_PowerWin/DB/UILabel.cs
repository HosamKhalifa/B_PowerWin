using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ui_label")]
    public class UILabel
    {
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
        public int Grid_LookupFormRef { get; set; }

        public List<UILabelLangTxt> LangTxts { get; set; }



    }
}
