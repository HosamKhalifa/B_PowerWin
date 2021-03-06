using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB.Query
{
    [NotMapped]
   public class VendorListPageQuery
    {
        public static string DDL_SQL { get { return "CREATE OR ALTER VIEW[dbo].[VendorListPageQuery]  AS SELECT L.Id, A.ReferenceNum, A.DisplayNum, A.Name, A.CompanyId, A.TaxGroupId, A.Country_IsoCode, A.Description, A.GroupId, dbo.SF_AccountGroupFullName(a.GroupId)  GroupFullName,L.CreatedBy, L.CreatedAt, L.ModifiedBy,L.ModifiedAt, L.WFStatus FROM line_base AS L INNER JOIN  account_base AS A ON L.Id = A.Id INNER JOIN  vendor AS v ON v.Id = A.Id GO "; } }
        public static string SELECT_SQL { get {return "SELECT  Id, ReferenceNum, DisplayNum, Name, CompanyId, TaxGroupId, Country_IsoCode, Description, GroupId, GroupFullName,CreatedBy, CreatedAt, ModifiedBy, ModifiedAt, WFStatus FROM    VendorListPageQuery AS V"; } }
        public long? Id { get; set; }
        public string ReferenceNum { get; set; }
        public string DisplayNum { get; set; }
        public string Name { get; set; }
        public int? CompanyId { get; set; }
        public long? TaxGroupId { get; set; }
        public string Country_IsoCode { get; set; }
        public string Description { get; set; }
        public long? GroupId { get; set; }
        public string GroupFullName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public WorkflowStatusEnum WFStatus { get; set; }
    }
}
