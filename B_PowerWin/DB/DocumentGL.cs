using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_PowerWin.SharedExt;
using System.Data.Entity.Migrations;

namespace B_PowerWin.DB
{
    [Table("doc_gl")]
   public class DocumentGL:DocumentBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class DocumentGLFields
        {
            public static string CurrencyCode { get { return "CurrencyCode"; } }
            public static string CurrencyExch { get { return "CurrencyExch"; } }
            public static string DocTotalCC { get { return "DocTotalCC"; } }
            public static string DocTotalFC { get { return "DocTotalFC"; } }

        }

        #endregion
        public DocumentGL():base()
        {

        }
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.DocumentGL;
        }
        public override void OnCreate(AppDbContext _db)
        {
            long? li_DisplayNumSequVersion = null;
            var jourTypeRow = _db.JournalTypes.Find(this.JournalTypeId);
            BaseType = (int)BaseTypeEnum.DocumentGL;
            TransDayId = TransDate.HasValue ? TransDate.Value.DayID() : 0;
            DisplayNum = jourTypeRow.JourDocumentNextValue(_db, TransDate,out li_DisplayNumSequVersion);
            DisplayNumSequVersion = li_DisplayNumSequVersion;

            base.OnCreate(_db);
        }

        public override void BuildMetaData(AppDbContext _db)
        {
            //Base entity
            var le_BaseType = GetBaseTypeEnum();
            var lt_BaseType = new BaseType() { BaseTypeId = (int)le_BaseType, BaseTypeName = le_BaseType.ToString(), RecordTypeType = BaseTypeTypeEnum.Document};
            _db.BaseTypes.AddOrUpdate(lt_BaseType);

            //Security role
            var lt_Role = new SecPrincipalRoleMaster() { ObjectId = (int)le_BaseType, PrincipalId = $"{lt_BaseType.BaseTypeName}{lt_BaseType.RecordTypeType.ToString()}", PrincipalName = lt_BaseType.BaseTypeName, RoleType = SecAccessTypeTypeEnum.Master };
            _db.SecPrincipalRoleMasters.AddOrUpdate(lt_Role);
            base.BuildMetaData(_db);
        }

        public decimal? DocTotalCC { get; set; }
        [StringLength(5)]
        public string CurrencyCode { get; set; }
        [Required]
        public decimal? CurrencyExch { get; set; }
        public decimal? DocTotalFC { get; set; }



        

    }
}
