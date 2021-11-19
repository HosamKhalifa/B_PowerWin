using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ledger_posting_profile")]
    public class LedgerPostingProfile:ILineBase
    {
        public virtual BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.LedgerPostingProfile;
        }
        public virtual void BuildMetaData(AppDbContext _db)
        {
            string ls_ProfileId = $"{BaseTypeEnum.Customer.ToString().ToUpper()}";
            //Customer
            _db.LedgerPostingProfiles.AddOrUpdate(
                new LedgerPostingProfile() {
                    ProfileId = $"{BaseTypeEnum.Customer.ToString().ToUpper()}",
                    ProfileName = BaseTypeEnum.Customer.ToString(),
                    AccountBaseType = BaseTypeEnum.Customer,
                    LedgerPostingEntry = LedgerPostingEntryEnum.None,
                    ProfileType = LedgerLineTypeEnum.Cust,
                    PostingModule= LedgerPostingModuleEnum.Sales
                }
                );
            //Vendor
            _db.LedgerPostingProfiles.AddOrUpdate(
                new LedgerPostingProfile()
                {
                    ProfileId = $"{BaseTypeEnum.Vendor.ToString().ToUpper()}",
                    ProfileName = BaseTypeEnum.Vendor.ToString(),
                    AccountBaseType = BaseTypeEnum.Vendor,
                    LedgerPostingEntry = LedgerPostingEntryEnum.None,
                    ProfileType = LedgerLineTypeEnum.Vend,
                    PostingModule = LedgerPostingModuleEnum.Purchase
                }
                );
            //bank
            _db.LedgerPostingProfiles.AddOrUpdate(
                new LedgerPostingProfile()
                {
                    ProfileId = $"{BaseTypeEnum.Bank.ToString().ToUpper()}",
                    ProfileName = BaseTypeEnum.Bank.ToString(),
                    AccountBaseType = BaseTypeEnum.Bank,
                    LedgerPostingEntry = LedgerPostingEntryEnum.None,
                    ProfileType = LedgerLineTypeEnum.Bank,
                    PostingModule = LedgerPostingModuleEnum.CashAndBank
                }
                );
            //Cash
            _db.LedgerPostingProfiles.AddOrUpdate(
                new LedgerPostingProfile()
                {
                    ProfileId = $"{BaseTypeEnum.Cash.ToString().ToUpper()}",
                    ProfileName = BaseTypeEnum.Cash.ToString(),
                    AccountBaseType = BaseTypeEnum.Cash,
                    LedgerPostingEntry = LedgerPostingEntryEnum.None,
                    ProfileType = LedgerLineTypeEnum.Cash,
                    PostingModule = LedgerPostingModuleEnum.CashAndBank
                }
                );
            //Fixed assets
            _db.LedgerPostingProfiles.AddOrUpdate(
                new LedgerPostingProfile()
                {
                    ProfileId = $"{BaseTypeEnum.FixedAsset.ToString().ToUpper()}",
                    ProfileName = BaseTypeEnum.FixedAsset.ToString(),
                    AccountBaseType = BaseTypeEnum.FixedAsset,
                    LedgerPostingEntry = LedgerPostingEntryEnum.None,
                    ProfileType = LedgerLineTypeEnum.Cash,
                    PostingModule = LedgerPostingModuleEnum.FixedAsset
                }
                );
            //POS_SalesInvoice
            ls_ProfileId = $"{LedgerPostingEntryEnum.POS_SalesInvoice.ToString().ToUpper()}";
            //Customer
            _db.LedgerPostingProfiles.AddOrUpdate(
                new LedgerPostingProfile()
                {
                    ProfileId = $"{LedgerPostingEntryEnum.POS_SalesInvoice.ToString().ToUpper()}",
                    ProfileName = LedgerPostingEntryEnum.POS_SalesInvoice.ToString(),
                    AccountBaseType = BaseTypeEnum.Item,
                    LedgerPostingEntry = LedgerPostingEntryEnum.POS_SalesInvoice,
                    ProfileType = LedgerLineTypeEnum.Ledger,
                    PostingModule = LedgerPostingModuleEnum.Sales
                }
                );
            //PurchaseBill
            ls_ProfileId = $"{LedgerPostingEntryEnum.PurchaseBill.ToString().ToUpper()}";
            //Customer
            _db.LedgerPostingProfiles.AddOrUpdate(
                new LedgerPostingProfile()
                {
                    ProfileId = $"{LedgerPostingEntryEnum.PurchaseBill.ToString().ToUpper()}",
                    ProfileName = LedgerPostingEntryEnum.PurchaseBill.ToString(),
                    AccountBaseType = BaseTypeEnum.Item,
                    LedgerPostingEntry = LedgerPostingEntryEnum.PurchaseBill,
                    ProfileType = LedgerLineTypeEnum.Ledger,
                    PostingModule = LedgerPostingModuleEnum.Purchase
                }
                );

        }

        public bool IsBusinessObject()
        {
            return true;
        }

        public Exception GetLineExceptionDetails(AppDbContext _db, LineBaseCRUDEnum _CRUDType)
        {
            string ls_expName;

            ls_expName = $"Error when {_CRUDType.ToString()} LedgerPostingProfile  Id:{this.ProfileId} Name {ProfileName} ";
            var exp = new Exception(ls_expName);
            exp.Data.Add("EntityObject", this);


            return exp;
        }

        public bool ValidateLine(AppDbContext _db, LineBaseCRUDEnum _CRUDType)
        {
            return true;
        }

        public void OnCreate(AppDbContext _db)
        {
            
        }

        public virtual void OnUpdate(AppDbContext _db, DbEntityEntry _entryStatus)
        {
            if (!ValidateLine(_db, LineBaseCRUDEnum.Update))
            {

                throw GetLineExceptionDetails(_db, LineBaseCRUDEnum.Update);
            }
        }

        public void OnDelete(AppDbContext _db)
        {
           
        }


        [Key,StringLength(100)]
        public string ProfileId { get; set; }
        [StringLength(200),Required]
        public string ProfileName { get; set; }
        public LedgerLineTypeEnum ProfileType { get; set; }
        [Required]
        public BaseTypeEnum AccountBaseType { get; set; }

        [Required]
        public LedgerPostingEntryEnum LedgerPostingEntry { get; set; }
        [Required]
        public LedgerPostingModuleEnum PostingModule { get; set; }

        public virtual ICollection<LedgerPostingProfileSetup> SetupLines { get; set; }


    }
}
