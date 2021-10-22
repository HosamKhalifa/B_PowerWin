using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ui_label_lang_txt")]
    public class UILabelLangTxt
    {
        [StringLength(200)]
        public string LabelId { get; set; }
        public UILabelType LabelType { get; set; }
        [StringLength(5)]
        public string LangId { get; set; }/*ar-EG   en-US*/
        [StringLength(250),Required]
        public string   Txt { get; set; }

        //Service methods
        public static UILabelLangTxt GetLangTxt(string _LabelId,UILabelType _LblType)
        {
            var ret = MySession.Session.Database.UILabelTxts.Where(x => x.LabelId == _LabelId && x.LabelType == _LblType && x.LangId == MySession.Session.LangId).FirstOrDefault();
            return ret;
        }

    }
}
