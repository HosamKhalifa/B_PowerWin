using B_PowerWin.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace B_PowerWin
{
   public class AppDbContext:DbContext
    {
        public AppDbContext():base("name=MyDB")
        {
            
        }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Entity<UILabelLangTxt>().HasKey(tbl => new { tbl.LabelId, tbl.LabelType, tbl.LangId });
           modelBuilder.Entity<EnumTable>().HasKey(tbl => new { tbl.SysName, tbl.ValueId});
           modelBuilder.Entity<SysSequenceValue>().HasKey(x => new { x.SequNum, x.SysSequRecycle, x.CurrentRecycleValue });

            /* 
            modelBuilder.HasSequence<Int64>(DB_Util.LINE_BASE_SEQU);
            modelBuilder.Entity<LineBase>()
                                           .Property(o => o.Id)
                                           .HasDefaultValueSql(" DEFAULT NEXT VALUE FOR line_base_sequ ");
            modelBuilder.Entity<LineBase>()
                                           .Property(o => o.CreatedAt)
                                           .(" getdate() ");
            modelBuilder.Entity<LineBase>()
                                           .Property(o => o.ModifiedAt)
                                           .HasDefaultValueSql(" getdate() ");
           */

            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            
            foreach (var item in this.ChangeTracker.Entries().Where(x => x.State == EntityState.Modified ))
            {
                //item.Property("ModifiedAt").CurrentValue = DateTime.Now;
                //item.Property("ModifiedBy").CurrentValue = MySession.Session.UserId;
                if(item.Entity is ILineBase)
                {
                    ((ILineBase)item.Entity).OnUpdate(this);
                }

            }
            foreach (var item in this.ChangeTracker.Entries().Where(x => x.State == EntityState.Added))
            {
                if (item.Entity is ILineBase)
                {
                    ((ILineBase)item.Entity).OnCreate(this);
                }
                #region OldCode
                /*
              *  var mem_Id = item.Property("Id");
               if (mem_Id != null && (mem_Id.CurrentValue == null || (long?)mem_Id.CurrentValue == 0))
               {
                   var parent = mem_Id.EntityEntry;
                   if (parent.Entity is LineBase)
                   {
                       mem_Id.CurrentValue = DB_Util.LineBaseSequNextVal(this);
                   }
               }

               var mem_CreatedAt = item.Property("CreatedAt");
               if (mem_CreatedAt != null)
               {
                   var parent = mem_CreatedAt.EntityEntry;
                   if (parent.Entity is LineBase)
                   {
                       mem_CreatedAt.CurrentValue = DateTime.Now;
                       item.Property("CreatedBy").CurrentValue = MySession.Session.UserId;
                       item.Property("MofifiedAt").CurrentValue = DateTime.Now;
                       item.Property("MofifiedBy").CurrentValue = MySession.Session.UserId;

                   }
               }
              */

                #endregion
            }
            foreach (var item in this.ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted))
            {
                if (item.Entity is ILineBase)
                {
                    ((ILineBase)item.Entity).OnDelete(this);
                }
            }

            return base.SaveChanges();

        }

        public virtual void CancelChanges()
        {
            var changes = this.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            foreach (var obj in changes)
            {
                switch (obj.State)
                {
                  
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;
                    default:
                        break;
                }
            }
        }


        #region Tables
        public DbSet<BaseType> BaseTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<LineBase> Lines { get; set; }
        public DbSet<AccountBase> Accounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AccountGroup> AccountGroups { get; set; }
        public DbSet<JournalType> JournalTypes { get; set; }
        public DbSet<LedgerPostingProfile> LedgerPostingProfiles { get; set; }
        public DbSet<LedgerPostingProfileSetup> LedgerPostingProfileSetups { get; set; }
        public DbSet<DocumentBase> Documents { get; set; }
        public DbSet<DocumentLine> DocumentLines { get; set; }
        public DbSet<SysSequence> SysSequences { get; set; }
        public DbSet<SysSequenceValue> SysSequenceValues { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<DimDefault> DimDefaults { get; set; }
        public DbSet<InventDimDefault> InventDimDefaults { get; set; }
        public DbSet<UILabel> UILabels { get; set; }
        public DbSet<UILabelLangTxt> UILabelTxts { get; set; }
        public DbSet<EnumTable> EnumTables { get; set; }
        //***********UIGridLayout**************************************************************
        public DbSet<UIGridMaster> UIGridMasters { get; set; }
        public DbSet<UIGridLayoutHeader> UIGridLayoutHeaders { get; set; }
        public DbSet<UIGridLayoutLine> UIGridLayoutLine { get; set; }
        //***********GL**************************************************************
        #region Tables_GL
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<LedgerCalender> LedgerCalenders { get; set; }
        public DbSet<LedgerYear> LedgerYears { get; set; }
        public DbSet<LedgerPeriod> LedgerPeriods { get; set; }
        public DbSet<LedgerJournal> LedgerJournals { get; set; }
        public DbSet <LedgerCOA> LedgerCOAs { get; set; }
        public DbSet<MainAccount> MainAccounts { get; set; }
        public DbSet<MainAccountGroup> MainAccountGroups { get; set; }
        public DbSet<BusinessUnit> BusinessUnits { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Cash> Cashes { get; set; }

        public DbSet<DocumentGL> DocumentGLs { get; set; }
        public DbSet<TaxGroup> TaxGroups { get; set; }
        public DbSet<TaxCode> TaxCodes { get; set; }
        public DbSet<TaxGroupMemberSetup> TaxGroupMemberSetups { get; set; }
        public DbSet<TaxCodeValueSetup> TaxCodeValueSetups { get; set; }

        #endregion
        //***********Inventory**************************************************************
        #region Tables_Inventory
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemSize> ItemSizes { get; set; }
        public DbSet<ItemColor> ItemColors { get; set; }
        public DbSet<ItemVariants> ItemVariants { get; set; }

        public DbSet<ItemBatch> ItemBatches { get; set; }
        public DbSet<ItemBatchSerial> ItemBatchSerials { get; set; }
        public DbSet<InventStore> InventStores { get; set; }

        public DbSet<DocumentLineInvent> DocumentLineInvents { get; set; }

        #endregion
        //***********HR**************************************************************
        #region Tables_HR
        public DbSet<Employee> Employees { get; set; }

        #endregion

        //***********AP*********************************************************
        #region Tables_AP
      
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<PaymentTerm> PaymentTerms { get; set; }

        #endregion

        //***********AR*********************************************************
        #region Tables_AR
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pos> Pos { get; set; }


        #endregion

        //***********Security*********************************************************
        #region Tables_Security
        public DbSet<SecAccessType> SecAccessTypes { get; set; }
        public DbSet<SecPrincipal> Principals { get; set; }
        public DbSet<SecPrincipalRole> SecPrincipalRoles { get; set; }
        public DbSet<SecPrincipalRoleAction> SecPrincipalRoleActions { get; set; }
        public DbSet<SecPrincipalRoleForm> SecPrincipalRoleForm { get; set; }
        public DbSet<SecPrincipalRoleJournal> SecPrincipalRoleJournals { get; set; }
        public DbSet<SecPrincipalRoleMaster> SecPrincipalRoleMasters { get; set; }
        public DbSet<SecPrincipalRoleReport> SecPrincipalRoleReports { get; set; }
        public DbSet<SecPrincipalRoleResponsibility> SecPrincipalRoleResponsibilities { get; set; }
        public DbSet<SecPrincipalUser> SecPrincipalUsers { get; set; }
        public DbSet<SecPrincipalRoleMem> SecPrincipalRoleMems { get; set; }
        #endregion







        #endregion



    }
}
