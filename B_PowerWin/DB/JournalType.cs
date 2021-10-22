using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("journal_type")]
    public class JournalType:LineBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.JournalType;
        }
        public int? CompanyId { get; set; }
        [Required]
        public JournalTypeEnum JourType { get; set; }
        [StringLength(100),Required]
        public string JourName { get; set; }
        public PostingLayerEnum PostingLayer { get; set; }
        public long? SequId { get; set; }
        public bool SequGenerateAtPosting { get; set; }

        public JournalTypeDetailSummaryEnum DetailSummary { get; set; }
        public bool AmountsInclueTax { get; set; }




    }
}
