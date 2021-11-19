using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using B_PowerWin.SharedExt;
using B_PowerWin.DBEvents;
using System.Data.Entity.Infrastructure;

namespace B_PowerWin.DB
{
    [Table("line_base")]
    public class LineBase:ILineBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class LineBaseFields
        {
            public static string Id { get { return "Id"; } }
            public static string WFStatus { get { return "WFStatus"; } }
            public static string BaseType { get { return "BaseType"; } }
            public static string CreatedAt { get { return "CreatedAt"; } }
            public static string CreatedBy { get { return "CreatedBy"; } }
            public static string ModifiedAt { get { return "ModifiedAt"; } }
            public static string ModifiedBy { get { return "ModifiedBy"; } }

        }
        #endregion
        public event InitNewRowHandler InitNewRow;
        public virtual void OnInitNewRow(InitNewRowEventArgs e)
        {
            InitNewRow?.Invoke(this, e);
        }
        public LineBase()
        {
            Id = 0;
            WFStatus = WorkflowStatusEnum.Draft;
            CreatedBy = MySession.Session.UserId;
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
            ModifiedBy = MySession.Session.UserId;
            
            
            var baseTypeId = (int)GetBaseTypeEnum();
           
            this.BaseType = baseTypeId;
        }
        [NotMapped]
        public string LastErrorMessage { get; set; }
        public virtual bool IsBusinessObject()
        {
            /*Business object is an Entity class which represent securable, updatable and displayed to user
               Eeach Entity class which will be BO need to override this method to return true
               Each enity has true value will be creating securable mapping record */
            return false;
        }
        public virtual BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.None;
        }
        public virtual Exception GetLineExceptionDetails(AppDbContext _db, LineBaseCRUDEnum _CRUDType)
        {
            string ls_expName;
            BaseType lo_BaseType = _db.BaseTypes.Find(this.BaseType);
            ls_expName = $"Error when {_CRUDType.ToString()} {lo_BaseType.BaseTypeName}  Id:{this.Id} ";
            var exp = new Exception(ls_expName);
            exp.Data.Add("EntityObject", this);
            exp.Data.Add("BusinessError", LastErrorMessage);

            return exp;
        }
        public virtual bool ValidateLine(AppDbContext _db, LineBaseCRUDEnum _CRUDType)
        {
            /*Put validation on this logic*/
            //Permission checking should be here 
            //Error message will be saved at LastErrorMessage to be used
            bool lb_Return = true;

            return lb_Return;
        }
        public virtual void OnCreate(AppDbContext _db)
        {
            CreatedBy = MySession.Session.UserId;
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
            ModifiedBy = MySession.Session.UserId;
            if (!ValidateLine(_db, LineBaseCRUDEnum.Create))
            {

                throw GetLineExceptionDetails(_db,LineBaseCRUDEnum.Create);
            }

            Id = Id == null || Id == 0? DB_Util.LineBaseSequNextVal(_db):Id;
            
            var baseTypeId = (int)GetBaseTypeEnum();

            this.BaseType = baseTypeId;

        }
        public virtual void OnUpdate(AppDbContext _db, DbEntityEntry _entryStatus)
        {
            if (!ValidateLine(_db, LineBaseCRUDEnum.Update))
            {
                throw GetLineExceptionDetails(_db, LineBaseCRUDEnum.Update);
            }
            ModifiedAt = DateTime.Now;
            ModifiedBy = MySession.Session.UserId;
        }
        public virtual void OnDelete(AppDbContext _db)
        {
            if (!ValidateLine(_db, LineBaseCRUDEnum.Delete))
            {

                throw GetLineExceptionDetails(_db, LineBaseCRUDEnum.Delete);
            }
        }

        public virtual void BuildMetaData(AppDbContext _db)
        {
            //In Childs each class should create records
            //BaseType
            //SecRole 
            //This method will be called when seed database 
             
        }




        #region DB_Fields

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long? Id { get; set; }
        [StringLength(50),Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime? CreatedAt { get; set; }
        [StringLength(50),Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }
        [Required]
        public int BaseType { get; set; }

        [Required]
        public WorkflowStatusEnum WFStatus { get; set; }
        #endregion
    }
}
