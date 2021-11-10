﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace B_PowerWin.DB
{
    [Table("doc_base")]
   public class DocumentBase:LineBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class DocumentBaseFields
        {
            public static string Address { get { return "Address"; } }
            public static string City { get { return "City"; } }
            public static string CityId { get { return "CityId"; } }
            public static string CompanyId { get { return "CompanyId"; } }
            public static string ContactName { get { return "ContactName"; } }
            public static string Country { get { return "Country"; } }
            public static string CountryId { get { return "CountryId"; } }
            public static string DisplayNum { get { return "DisplayNum"; } }
            public static string DisplayNumSequVersion { get { return "DisplayNumSequVersion"; } }
            public static string HeadAccountBaseTypeId { get { return "HeadAccountBaseTypeId"; } }
            public static string HeadAccountId { get { return "HeadAccountId"; } }
            public static string HeadAccountName { get { return "HeadAccountName"; } }
            public static string HeadLedgerAccountId { get { return "HeadLedgerAccountId"; } }
            public static string JournalType { get { return "JournalType"; } }
            public static string JournalTypeId { get { return "JournalTypeId"; } }
            public static string LedgerJournals { get { return "LedgerJournals"; } }
            public static string ParnetId { get { return "ParnetId"; } }
            public static string PostingPeriod { get { return "PostingPeriod"; } }
            public static string ReferenceNum { get { return "ReferenceNum"; } }
            public static string TaxCardNum { get { return "TaxCardNum"; } }
            public static string TaxCommRegisterNum { get { return "TaxCommRegisterNum"; } }
            public static string TaxFileNum { get { return "TaxFileNum"; } }
            public static string TaxGroup { get { return "TaxGroup"; } }
            public static string TransDate { get { return "TransDate"; } }
            public static string TransDayId { get { return "TransDayId"; } }
        }
       
        
        #endregion
        public DocumentBase():base()
        {
            CompanyId = MySession.Session.Company.Id;
        }
        [Required]
        public int? CompanyId { get; set; }
        [Required,ForeignKey("JournalType")]
        public long? JournalTypeId { get; set; }
        public virtual JournalType JournalType { get; set; }//Reference 
        [StringLength(50), Required]
        public string DisplayNum { get; set; }
        public long? DisplayNumSequVersion { get; set; }
        [StringLength(50)]
        public string ReferenceNum { get; set; }
        [Required]
        public DateTime? TransDate { get; set; }
        
        public int? TransDayId { get; set; }
        public int HeadAccountBaseTypeId { get; set; }/*Ledger,Customer,Vendor,Bank,Cash*/
        public long? HeadAccountId { get; set; }
        [StringLength(250)]
        public string HeadAccountName { get; set; }
        public long? HeadLedgerAccountId { get; set; }
        public long? PostingPeriod { get; set; }
     
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(150)]
        public string ContactName { get; set; }
        [StringLength(5),ForeignKey("Country")]
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }
        [ForeignKey("City")]
        public long? CityId { get; set; }
        public virtual City City { get; set; }
        public long? TaxGroup { get; set; }
        public string TaxFileNum { get; set; }
        public string TaxCardNum { get; set; }
        public string TaxCommRegisterNum { get; set; }


        
        public virtual ICollection<LedgerJournal> LedgerJournals { get; set; }

    }
}
