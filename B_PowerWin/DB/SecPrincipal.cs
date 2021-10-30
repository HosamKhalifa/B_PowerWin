using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("sec_principal")]
    public class SecPrincipal: ILineBase
    {
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
            if (!ValidateLine(_db, LineBaseCRUDEnum.Create))
            {
                throw GetLineExceptionDetails(_db, LineBaseCRUDEnum.Create);
            }
            
        }
        public virtual void BuildMetaData(AppDbContext _db)
        {
            //In Childs each class should create records
            //BaseType
            //SecRole 
            //This method will be called when seed database 

        }
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

        public Exception GetLineExceptionDetails(AppDbContext _db, LineBaseCRUDEnum _CRUDType)
        {
            string ls_expName;
            
            ls_expName = $"Error when {_CRUDType.ToString()} {RoleType.ToString()}  Id:{this.PrincipalId} Name: {PrincipalName} ";
            var exp = new Exception(ls_expName);
            exp.Data.Add("EntityObject", this);
            //exp.Data.Add("BusinessError", LastErrorMessage);

            return exp;
        }

        public virtual void OnUpdate(AppDbContext _db)
        {
            if (!ValidateLine(_db, LineBaseCRUDEnum.Update))
            {

                throw GetLineExceptionDetails(_db, LineBaseCRUDEnum.Update);
            }
        }

        public virtual void OnDelete(AppDbContext _db)
        {
            if (!ValidateLine(_db, LineBaseCRUDEnum.Delete))
            {

                throw GetLineExceptionDetails(_db, LineBaseCRUDEnum.Delete);
            }
        }


        [StringLength(150),NotMapped]
        public string PrincipalFullName
        {
            get
            {
                return $"{PrincipalName} {RoleType.ToString()}";
            }
        }

        [Key,StringLength(120)]
        public string PrincipalId { get; set; }
        [StringLength(120)]
        public string PrincipalName { get; set; }
        [Required]
        public SecAccessTypeTypeEnum RoleType { get; set; }
        public virtual ICollection<SecPrincipalRoleMem> SecPrincipalRoleMems { get; set; }

    }
}
