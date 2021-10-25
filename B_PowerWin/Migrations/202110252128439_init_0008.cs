namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0008 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.account_base", name: "MainAccount_Id", newName: "MainAccountId");
            RenameColumn(table: "dbo.main_account", name: "MainAccountGroup_Id", newName: "MainAccountGroupId");
            RenameColumn(table: "dbo.pos", name: "ArAccount_Id", newName: "ArAccountId");
            RenameColumn(table: "dbo.pos", name: "CashAccount_Id", newName: "CashAccountId");
            RenameColumn(table: "dbo.pos", name: "ExpenseJournal_Id", newName: "ExpenseJournalId");
            RenameColumn(table: "dbo.pos", name: "InventTransferJournal_Id", newName: "InventTransferJournalId");
            RenameColumn(table: "dbo.pos", name: "PosManager_Id", newName: "PosManagerId");
            RenameColumn(table: "dbo.pos", name: "SalesJournal_Id", newName: "SalesJournalId");
            RenameColumn(table: "dbo.ledger_journal", name: "Document_Id", newName: "DocumentId");
            RenameColumn(table: "dbo.ledger_journal", name: "Journal_Id", newName: "JournalId");
            RenameColumn(table: "dbo.ledger_journal", name: "PostingPeriod_PeriodId", newName: "PostingPeriodId");
            RenameIndex(table: "dbo.account_base", name: "IX_MainAccount_Id", newName: "IX_MainAccountId");
            RenameIndex(table: "dbo.ledger_journal", name: "IX_Journal_Id", newName: "IX_JournalId");
            RenameIndex(table: "dbo.ledger_journal", name: "IX_Document_Id", newName: "IX_DocumentId");
            RenameIndex(table: "dbo.ledger_journal", name: "IX_PostingPeriod_PeriodId", newName: "IX_PostingPeriodId");
            RenameIndex(table: "dbo.main_account", name: "IX_MainAccountGroup_Id", newName: "IX_MainAccountGroupId");
            RenameIndex(table: "dbo.pos", name: "IX_ArAccount_Id", newName: "IX_ArAccountId");
            RenameIndex(table: "dbo.pos", name: "IX_CashAccount_Id", newName: "IX_CashAccountId");
            RenameIndex(table: "dbo.pos", name: "IX_PosManager_Id", newName: "IX_PosManagerId");
            RenameIndex(table: "dbo.pos", name: "IX_SalesJournal_Id", newName: "IX_SalesJournalId");
            RenameIndex(table: "dbo.pos", name: "IX_ExpenseJournal_Id", newName: "IX_ExpenseJournalId");
            RenameIndex(table: "dbo.pos", name: "IX_InventTransferJournal_Id", newName: "IX_InventTransferJournalId");
            CreateTable(
                "dbo.business_unit",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        BusinessUnitCode = c.String(maxLength: 10),
                        BusinessUnitName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.BusinessUnitCode, unique: true, name: "business_unit_code_uq")
                .Index(t => t.BusinessUnitName, unique: true, name: "business_unit_name_uq");
            
            CreateTable(
                "dbo.invent_store",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.site",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.department",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.equipment",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Purpose",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.doc_line", "BusinessUnitId", c => c.Long());
            AddColumn("dbo.doc_line", "CashId", c => c.Long());
            AddColumn("dbo.doc_line", "OffsetBusinessUnitId", c => c.Long());
            AddColumn("dbo.doc_line", "OffsetCashId", c => c.Long());
            AddColumn("dbo.dim_default", "BusinessUnitId", c => c.Long());
            AddColumn("dbo.dim_default", "CashId", c => c.Long());
            AddColumn("dbo.invent_dim_default", "BusinessUnitId", c => c.Long());
            AddColumn("dbo.invent_dim_default", "InventStoreId", c => c.Long());
            AlterColumn("dbo.main_account", "IsTotal", c => c.Boolean(nullable: false));
            AlterColumn("dbo.item_variants", "BarCode", c => c.String(maxLength: 50));
            AlterColumn("dbo.ui_grid_master", "GridCSharpCodeName", c => c.String(nullable: false, maxLength: 300));
            CreateIndex("dbo.dim_default", "BusinessUnitId");
            CreateIndex("dbo.dim_default", "SiteId");
            CreateIndex("dbo.dim_default", "DeptId");
            CreateIndex("dbo.dim_default", "EqupId");
            CreateIndex("dbo.dim_default", "ProjectId");
            CreateIndex("dbo.dim_default", "PurposeId");
            CreateIndex("dbo.dim_default", "BankId");
            CreateIndex("dbo.dim_default", "CashId");
            CreateIndex("dbo.dim_default", "CustId");
            CreateIndex("dbo.dim_default", "VendId");
            CreateIndex("dbo.dim_default", "EmplId");
            CreateIndex("dbo.dim_default", "PosId");
            CreateIndex("dbo.invent_dim_default", "BusinessUnitId");
            CreateIndex("dbo.invent_dim_default", "SiteId");
            CreateIndex("dbo.invent_dim_default", "PosId");
            CreateIndex("dbo.invent_dim_default", "InventStoreId");
            CreateIndex("dbo.invent_dim_default", "VendId");
            CreateIndex("dbo.invent_dim_default", "ItemId");
            CreateIndex("dbo.invent_dim_default", "ItemGroupId");
            CreateIndex("dbo.invent_dim_default", "ItemSizeId");
            CreateIndex("dbo.invent_dim_default", "ItemColorId");
            CreateIndex("dbo.invent_dim_default", "ItemVariantId");
            CreateIndex("dbo.invent_dim_default", "ItemBatchId");
            CreateIndex("dbo.ledger_period", "YearId");
            CreateIndex("dbo.ui_grid_master", "GridCSharpCodeName", unique: true, name: "ui_grid_master_csharpcodename_uq");
            CreateIndex("dbo.item_variants", "BarCode", unique: true, name: "item_variants_barcode_uq");
            AddForeignKey("dbo.dim_default", "BankId", "dbo.bank", "Id");
            AddForeignKey("dbo.invent_dim_default", "BusinessUnitId", "dbo.business_unit", "Id");
            AddForeignKey("dbo.invent_dim_default", "InventStoreId", "dbo.invent_store", "Id");
            AddForeignKey("dbo.invent_dim_default", "ItemId", "dbo.item", "Id");
            AddForeignKey("dbo.invent_dim_default", "ItemBatchId", "dbo.item_batch", "Id");
            AddForeignKey("dbo.invent_dim_default", "ItemColorId", "dbo.item_color", "Id");
            AddForeignKey("dbo.invent_dim_default", "ItemGroupId", "dbo.account_group", "Id");
            AddForeignKey("dbo.invent_dim_default", "ItemSizeId", "dbo.item_size", "Id");
            AddForeignKey("dbo.invent_dim_default", "ItemVariantId", "dbo.item_variants", "Id");
            AddForeignKey("dbo.ledger_period", "YearId", "dbo.ledger_year", "YearId");
            AddForeignKey("dbo.invent_dim_default", "PosId", "dbo.pos", "Id");
            AddForeignKey("dbo.invent_dim_default", "SiteId", "dbo.site", "Id");
            AddForeignKey("dbo.invent_dim_default", "VendId", "dbo.vendor", "Id");
            AddForeignKey("dbo.dim_default", "BusinessUnitId", "dbo.business_unit", "Id");
            AddForeignKey("dbo.dim_default", "CashId", "dbo.cash", "Id");
            AddForeignKey("dbo.dim_default", "CustId", "dbo.customer", "Id");
            AddForeignKey("dbo.dim_default", "DeptId", "dbo.department", "Id");
            AddForeignKey("dbo.dim_default", "EmplId", "dbo.Employee", "Id");
            AddForeignKey("dbo.dim_default", "EqupId", "dbo.equipment", "Id");
            AddForeignKey("dbo.dim_default", "PosId", "dbo.pos", "Id");
            AddForeignKey("dbo.dim_default", "ProjectId", "dbo.Project", "Id");
            AddForeignKey("dbo.dim_default", "PurposeId", "dbo.Purpose", "Id");
            AddForeignKey("dbo.dim_default", "SiteId", "dbo.site", "Id");
            AddForeignKey("dbo.dim_default", "VendId", "dbo.vendor", "Id");
            DropColumn("dbo.doc_line", "BusinessUnit");
            DropColumn("dbo.doc_line", "OffsetBusinessUnit");
            DropColumn("dbo.dim_default", "BusinessUnit");
            DropColumn("dbo.invent_dim_default", "BusinessUnit");
            DropColumn("dbo.invent_dim_default", "WarehouseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.invent_dim_default", "WarehouseId", c => c.Long());
            AddColumn("dbo.invent_dim_default", "BusinessUnit", c => c.Long());
            AddColumn("dbo.dim_default", "BusinessUnit", c => c.Long());
            AddColumn("dbo.doc_line", "OffsetBusinessUnit", c => c.Long());
            AddColumn("dbo.doc_line", "BusinessUnit", c => c.Long());
            DropForeignKey("dbo.Purpose", "Id", "dbo.account_base");
            DropForeignKey("dbo.Project", "Id", "dbo.account_base");
            DropForeignKey("dbo.equipment", "Id", "dbo.account_base");
            DropForeignKey("dbo.department", "Id", "dbo.account_base");
            DropForeignKey("dbo.site", "Id", "dbo.account_base");
            DropForeignKey("dbo.invent_store", "Id", "dbo.account_base");
            DropForeignKey("dbo.business_unit", "Id", "dbo.line_base");
            DropForeignKey("dbo.dim_default", "VendId", "dbo.vendor");
            DropForeignKey("dbo.dim_default", "SiteId", "dbo.site");
            DropForeignKey("dbo.dim_default", "PurposeId", "dbo.Purpose");
            DropForeignKey("dbo.dim_default", "ProjectId", "dbo.Project");
            DropForeignKey("dbo.dim_default", "PosId", "dbo.pos");
            DropForeignKey("dbo.dim_default", "EqupId", "dbo.equipment");
            DropForeignKey("dbo.dim_default", "EmplId", "dbo.Employee");
            DropForeignKey("dbo.dim_default", "DeptId", "dbo.department");
            DropForeignKey("dbo.dim_default", "CustId", "dbo.customer");
            DropForeignKey("dbo.dim_default", "CashId", "dbo.cash");
            DropForeignKey("dbo.dim_default", "BusinessUnitId", "dbo.business_unit");
            DropForeignKey("dbo.invent_dim_default", "VendId", "dbo.vendor");
            DropForeignKey("dbo.invent_dim_default", "SiteId", "dbo.site");
            DropForeignKey("dbo.invent_dim_default", "PosId", "dbo.pos");
            DropForeignKey("dbo.ledger_period", "YearId", "dbo.ledger_year");
            DropForeignKey("dbo.invent_dim_default", "ItemVariantId", "dbo.item_variants");
            DropForeignKey("dbo.invent_dim_default", "ItemSizeId", "dbo.item_size");
            DropForeignKey("dbo.invent_dim_default", "ItemGroupId", "dbo.account_group");
            DropForeignKey("dbo.invent_dim_default", "ItemColorId", "dbo.item_color");
            DropForeignKey("dbo.invent_dim_default", "ItemBatchId", "dbo.item_batch");
            DropForeignKey("dbo.invent_dim_default", "ItemId", "dbo.item");
            DropForeignKey("dbo.invent_dim_default", "InventStoreId", "dbo.invent_store");
            DropForeignKey("dbo.invent_dim_default", "BusinessUnitId", "dbo.business_unit");
            DropForeignKey("dbo.dim_default", "BankId", "dbo.bank");
            DropIndex("dbo.Purpose", new[] { "Id" });
            DropIndex("dbo.Project", new[] { "Id" });
            DropIndex("dbo.equipment", new[] { "Id" });
            DropIndex("dbo.department", new[] { "Id" });
            DropIndex("dbo.site", new[] { "Id" });
            DropIndex("dbo.invent_store", new[] { "Id" });
            DropIndex("dbo.business_unit", "business_unit_name_uq");
            DropIndex("dbo.business_unit", "business_unit_code_uq");
            DropIndex("dbo.business_unit", new[] { "Id" });
            DropIndex("dbo.item_variants", "item_variants_barcode_uq");
            DropIndex("dbo.ui_grid_master", "ui_grid_master_csharpcodename_uq");
            DropIndex("dbo.ledger_period", new[] { "YearId" });
            DropIndex("dbo.invent_dim_default", new[] { "ItemBatchId" });
            DropIndex("dbo.invent_dim_default", new[] { "ItemVariantId" });
            DropIndex("dbo.invent_dim_default", new[] { "ItemColorId" });
            DropIndex("dbo.invent_dim_default", new[] { "ItemSizeId" });
            DropIndex("dbo.invent_dim_default", new[] { "ItemGroupId" });
            DropIndex("dbo.invent_dim_default", new[] { "ItemId" });
            DropIndex("dbo.invent_dim_default", new[] { "VendId" });
            DropIndex("dbo.invent_dim_default", new[] { "InventStoreId" });
            DropIndex("dbo.invent_dim_default", new[] { "PosId" });
            DropIndex("dbo.invent_dim_default", new[] { "SiteId" });
            DropIndex("dbo.invent_dim_default", new[] { "BusinessUnitId" });
            DropIndex("dbo.dim_default", new[] { "PosId" });
            DropIndex("dbo.dim_default", new[] { "EmplId" });
            DropIndex("dbo.dim_default", new[] { "VendId" });
            DropIndex("dbo.dim_default", new[] { "CustId" });
            DropIndex("dbo.dim_default", new[] { "CashId" });
            DropIndex("dbo.dim_default", new[] { "BankId" });
            DropIndex("dbo.dim_default", new[] { "PurposeId" });
            DropIndex("dbo.dim_default", new[] { "ProjectId" });
            DropIndex("dbo.dim_default", new[] { "EqupId" });
            DropIndex("dbo.dim_default", new[] { "DeptId" });
            DropIndex("dbo.dim_default", new[] { "SiteId" });
            DropIndex("dbo.dim_default", new[] { "BusinessUnitId" });
            AlterColumn("dbo.ui_grid_master", "GridCSharpCodeName", c => c.String(maxLength: 300));
            AlterColumn("dbo.item_variants", "BarCode", c => c.String());
            AlterColumn("dbo.main_account", "IsTotal", c => c.Int(nullable: false));
            DropColumn("dbo.invent_dim_default", "InventStoreId");
            DropColumn("dbo.invent_dim_default", "BusinessUnitId");
            DropColumn("dbo.dim_default", "CashId");
            DropColumn("dbo.dim_default", "BusinessUnitId");
            DropColumn("dbo.doc_line", "OffsetCashId");
            DropColumn("dbo.doc_line", "OffsetBusinessUnitId");
            DropColumn("dbo.doc_line", "CashId");
            DropColumn("dbo.doc_line", "BusinessUnitId");
            DropTable("dbo.Purpose");
            DropTable("dbo.Project");
            DropTable("dbo.equipment");
            DropTable("dbo.department");
            DropTable("dbo.site");
            DropTable("dbo.invent_store");
            DropTable("dbo.business_unit");
            RenameIndex(table: "dbo.pos", name: "IX_InventTransferJournalId", newName: "IX_InventTransferJournal_Id");
            RenameIndex(table: "dbo.pos", name: "IX_ExpenseJournalId", newName: "IX_ExpenseJournal_Id");
            RenameIndex(table: "dbo.pos", name: "IX_SalesJournalId", newName: "IX_SalesJournal_Id");
            RenameIndex(table: "dbo.pos", name: "IX_PosManagerId", newName: "IX_PosManager_Id");
            RenameIndex(table: "dbo.pos", name: "IX_CashAccountId", newName: "IX_CashAccount_Id");
            RenameIndex(table: "dbo.pos", name: "IX_ArAccountId", newName: "IX_ArAccount_Id");
            RenameIndex(table: "dbo.main_account", name: "IX_MainAccountGroupId", newName: "IX_MainAccountGroup_Id");
            RenameIndex(table: "dbo.ledger_journal", name: "IX_PostingPeriodId", newName: "IX_PostingPeriod_PeriodId");
            RenameIndex(table: "dbo.ledger_journal", name: "IX_DocumentId", newName: "IX_Document_Id");
            RenameIndex(table: "dbo.ledger_journal", name: "IX_JournalId", newName: "IX_Journal_Id");
            RenameIndex(table: "dbo.account_base", name: "IX_MainAccountId", newName: "IX_MainAccount_Id");
            RenameColumn(table: "dbo.ledger_journal", name: "PostingPeriodId", newName: "PostingPeriod_PeriodId");
            RenameColumn(table: "dbo.ledger_journal", name: "JournalId", newName: "Journal_Id");
            RenameColumn(table: "dbo.ledger_journal", name: "DocumentId", newName: "Document_Id");
            RenameColumn(table: "dbo.pos", name: "SalesJournalId", newName: "SalesJournal_Id");
            RenameColumn(table: "dbo.pos", name: "PosManagerId", newName: "PosManager_Id");
            RenameColumn(table: "dbo.pos", name: "InventTransferJournalId", newName: "InventTransferJournal_Id");
            RenameColumn(table: "dbo.pos", name: "ExpenseJournalId", newName: "ExpenseJournal_Id");
            RenameColumn(table: "dbo.pos", name: "CashAccountId", newName: "CashAccount_Id");
            RenameColumn(table: "dbo.pos", name: "ArAccountId", newName: "ArAccount_Id");
            RenameColumn(table: "dbo.main_account", name: "MainAccountGroupId", newName: "MainAccountGroup_Id");
            RenameColumn(table: "dbo.account_base", name: "MainAccountId", newName: "MainAccount_Id");
        }
    }
}
