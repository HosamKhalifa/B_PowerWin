using B_PowerWin.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.GUI
{
   public class FormArgs
    {
        private object fCurrentObject;

        public FormArgs(FormBase _parentForm)
        {
            this.Form = _parentForm;
            
        }
        public FormBase Form { get; set; }
        public FormArgs CallerFormArgs { get; set; }
        public object CurrentObject { get { return fCurrentObject; }
            set
            {
                fCurrentObject = value;
                if (value is LineBase) { CurrentLine = (LineBase)value; }
                if (value is AccountBase) { CurrentAccount = (AccountBase)value; }
                if (value is DocumentBase) { CurrentDocument = (DocumentBase)value; }
                if (value is DocumentLine) { CurrentDocLine = (DocumentLine)value; }
            }
        }
        public LineBase CurrentLine { get; set; }
        public AccountBase CurrentAccount { get; set; }
        public DocumentBase CurrentDocument { get; set; }
        public DocumentLine CurrentDocLine { get; set; }

        public Dictionary<string,object> Params { get; set; }
        public long? SimpleParm_Id { get; set; }
        public string SimpleParm_Str { get; set; }
        public Object SimpleParm_Obj { get; set; }
        public decimal? SimpleParm_Decimal { get; set; }
        public bool FilterByLookup { get; set; } = false;
        public string CallingMenuItemName { get; set; }



    }
}
