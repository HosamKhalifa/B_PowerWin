using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_PowerWin.SharedExt;
namespace B_PowerWin.DB.GUI
{
    [Table("user_parameter")]
    public class UserParameter:LineBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class UserParameterFields
        {
            public static string UserKey { get { return "UserKey"; } }
            public static string QueryBaseType  { get { return "QueryBaseType"; } }
            public static string StartDate  { get { return "StartDate"; } }
            public static string EndDate { get { return "EndDate"; } }
            public static string StartTransDayId { get { return "StartTransDayId"; } }
            public static string EndTransDayId { get { return "EndTransDayId"; } }
            public static string CustomerListExp { get { return "CustomerListExp"; } }
            public static string VendorListExp { get { return "VendorListExp"; } }
            public static string StoreListExp { get { return "StoreListExp"; } }
            public static string SiteListExp { get { return "SiteListExp"; } }
            public static string DeptListExp { get { return "DeptListExp"; } }
            public static string EqupListExp { get { return "EqupListExp"; } }
            public static string BusinessUnitListExp { get { return "BusinessUnitListExp"; } }
            public static string ItemListExp { get { return "ItemListExp"; } }
            public static string ItemInventoryListExp { get { return "ItemInventoryListExp"; } }
            public static string ItemServiceListExp { get { return "ItemServiceListExp"; } }
        }
        #endregion
        [Index(name:"user_parameter_uq",IsUnique =true,Order =0)]
        public int? UserKey { get; set; }
        [Index(name: "user_parameter_uq", IsUnique = true, Order = 1)]
        public BaseTypeEnum QueryBaseType { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        int? _StartTransDayId;
        public int? StartTransDayId { get { return _StartTransDayId; }
            set {
                    int dayId =  StartDate.HasValue? StartDate.Value.DayID() : 0;
                    _StartTransDayId = dayId;
                } }
       
        int? _EndTransDayId;
        public int? EndTransDayId { get { return _EndTransDayId; }
            set {
                int dayId = EndDate.HasValue ? EndDate.Value.DayID() : 0;
                _EndTransDayId = dayId;
                } }
        [StringLength(1000)]
        public string CustomerListExp { get; set; }
        public virtual List<long?> CustomerList { get; set; }
        [StringLength(1000)]
        public string VendorListExp { get; set; }
        public virtual List<long?> VendorList { get; set; }
        [StringLength(1000)]
        public string StoreListExp { get; set; }
        public virtual List<long?> StoreList { get; set; }
        [StringLength(1000)]
        public string SiteListExp { get; set; }
        public virtual List<long?> SiteList { get; set; }
        [StringLength(1000)]
        public string DeptListExp { get; set; }
        public virtual List<long?> DeptList { get; set; }
        [StringLength(1000)]
        public string EqupListExp { get; set; }
        public virtual List<long?> EqupList { get; set; }
        [StringLength(1000)]
        public string BusinessUnitListExp { get; set; }
        public virtual List<long?> BusinessUnitList { get; set; }
        [StringLength(1000)]
        public string ItemListExp { get; set; }
        public virtual List<long?> ItemList { get; set; }
        [StringLength(1000)]
        public string ItemInventoryListExp { get; set; }
        public virtual List<long?> ItemInventoryList { get; set; }
        [StringLength(1000)]
        public string ItemServiceListExp { get; set; }
        public virtual List<long?> ItemServiceList { get; set; }
        





    }
}
