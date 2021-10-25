using B_PowerWin.DB;


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace B_PowerWin
{
    public static class DB_Util
    {
      
        
        public  const string LINE_BASE_SEQU = "line_base_sequ";
        public static long? LineBaseSequNextVal(DbContext  _context) 
        {
            long? ll_Return;
            var p = new SqlParameter("@result", System.Data.SqlDbType.BigInt)
            {
                Direction = System.Data.ParameterDirection.Output
            };
            
            _context.Database.ExecuteSqlCommand($"set @result = next value for {LINE_BASE_SEQU}", p);
            var nextVal = (Int64)p.Value;
            ll_Return = nextVal;
            return ll_Return;

        }
        public static T GetEnumFromObject<T>(object o)
        {
            T enumVal = (T)Enum.Parse(typeof(T), o.ToString());
            return enumVal;
        }
        public static BaseType GetBaseTypeFromBaseTypeEnum(AppDbContext _context,BaseTypeEnum _value) 
        {
            return _context.BaseTypes.Find(_value);
        }
        public static void LineBaseInit(LineBase   _newRecord)
        {
            //Add initalization values from current session
            

        }
        public static void SeedDatabase(AppDbContext _context) 
        {
            var values = Enum.GetValues(typeof(BaseTypeTypeEnum)).Cast<BaseTypeEnum>();
            foreach (var item in values)
            {
                var dbRecord = _context.BaseTypes.Find(((int)item));
                if (dbRecord == null || dbRecord.BaseTypeId == 0)
                {
                    _context.BaseTypes.Add(new BaseType() { BaseTypeId = (int)item, BaseTypeName = item.ToString(), RecordTypeType = BaseTypeTypeEnum.GenericLine });
                    _context.SaveChanges();
                }
            }
        }

        #region CRUD operations
        public  static  DimDefault FindOrCreateDimDefault(AppDbContext _db,long? _lineId,long? _parentLineId=null,bool _save=false) 
        {
            var dbDimDefault = _db.DimDefaults.Find(_lineId);
            if (dbDimDefault != null)
            {
                return dbDimDefault;
            }
            else
            {
                dbDimDefault = new DimDefault() {Id = _lineId };
                if(_parentLineId != null) 
                {
                    var dbParentDimDefault = _db.DimDefaults.Find(_parentLineId);
                    if(dbParentDimDefault != null) 
                    {
                        dbDimDefault.BusinessUnit = dbParentDimDefault.BusinessUnit;
                        dbDimDefault.SiteId = dbParentDimDefault.SiteId;
                        dbDimDefault.DeptId = dbParentDimDefault.DeptId;
                        dbDimDefault.EqupId = dbParentDimDefault.EqupId;
                        dbDimDefault.ProjectId = dbParentDimDefault.ProjectId;
                        dbDimDefault.PurposeId = dbParentDimDefault.PurposeId;
                        dbDimDefault.BankId = dbParentDimDefault.BankId;
                        dbDimDefault.CustId = dbParentDimDefault.CustId;
                        dbDimDefault.VendId = dbParentDimDefault.VendId;
                        dbDimDefault.EmplId = dbParentDimDefault.EmplId;
                        dbDimDefault.PosId = dbParentDimDefault.PosId;
                        if (_save)
                        {
                            _db.DimDefaults.Add(dbDimDefault);
                            _db.SaveChanges();
                        }
                    }
                }

            }
            return dbDimDefault;
        }
        public static InventDimDefault FindOrCreateInventDimDefault(AppDbContext _db, long? _lineId, long? _parentLineId = null, bool _save = false)
        {
            var dbDimDefault = _db.InventDimDefaults.Find(_lineId);
            if (dbDimDefault != null)
            {
                return dbDimDefault;
            }
            else
            {
                dbDimDefault = new InventDimDefault() { Id = _lineId };
                if (_parentLineId != null)
                {
                    var dbParentDimDefault = _db.InventDimDefaults.Find(_parentLineId);
                    if (dbParentDimDefault != null)
                    {
                        dbDimDefault.BusinessUnit = dbParentDimDefault.BusinessUnit;
                        dbDimDefault.SiteId = dbParentDimDefault.SiteId;
                        dbDimDefault.PosId = dbParentDimDefault.PosId;
                        dbDimDefault.InventStoreId = dbParentDimDefault.InventStoreId;
                        dbDimDefault.VendId = dbParentDimDefault.VendId;
                        dbDimDefault.ItemId = dbParentDimDefault.ItemId;
                        dbDimDefault.ItemGroupId = dbParentDimDefault.ItemGroupId;
                        
                        dbDimDefault.ItemSizeId = dbParentDimDefault.ItemSizeId;
                        dbDimDefault.ItemColorId = dbParentDimDefault.ItemColorId;
                        dbDimDefault.ItemVariantId = dbParentDimDefault.ItemVariantId;
                        dbDimDefault.ItemBatchId = dbParentDimDefault.ItemBatchId;

                        if (_save)
                        {
                            _db.InventDimDefaults.Add(dbDimDefault);
                            _db.SaveChanges();
                        }
                    }
                }

            }
            return dbDimDefault;
        }
        #endregion
    }
}
