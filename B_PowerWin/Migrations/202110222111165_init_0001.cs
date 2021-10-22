namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.line_base",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        CreatedBy = c.String(maxLength: 50),
                        CreatedAt = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        ModifiedAt = c.DateTime(nullable: false),
                        ParnetId = c.Long(),
                        BaseType_BaseTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.base_type", t => t.BaseType_BaseTypeId)
                .Index(t => t.BaseType_BaseTypeId);
            
            CreateTable(
                "dbo.base_type",
                c => new
                    {
                        BaseTypeId = c.Int(nullable: false),
                        BaseTypeName = c.String(maxLength: 100),
                        RecordTypeType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BaseTypeId);
            
            CreateTable(
                "dbo.city",
                c => new
                    {
                        CityId = c.Long(nullable: false),
                        CityName = c.String(nullable: false, maxLength: 50),
                        Country_IsoCode = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.country", t => t.Country_IsoCode, cascadeDelete: true)
                .Index(t => t.Country_IsoCode);
            
            CreateTable(
                "dbo.country",
                c => new
                    {
                        IsoCode = c.String(nullable: false, maxLength: 5),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IsoCode);
            
            CreateTable(
                "dbo.ledger_period",
                c => new
                    {
                        PeriodId = c.Int(nullable: false, identity: true),
                        PeriodName = c.String(),
                        PeriodNum = c.Int(),
                        Quarter = c.Int(),
                        PeriodClass = c.Int(),
                        YearId = c.Int(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PeriodId);
            
            CreateTable(
                "dbo.company",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 250),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(),
                        ModifiedBy = c.String(nullable: false, maxLength: 50),
                        ModifiedAt = c.DateTime(),
                        Currency = c.String(maxLength: 5),
                        Calender = c.Int(),
                        COA = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.currency",
                c => new
                    {
                        CurrCode = c.String(nullable: false, maxLength: 5),
                        CurrName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.CurrCode);
            
            CreateTable(
                "dbo.dim_default",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BusinessUnit = c.Long(),
                        SiteId = c.Long(),
                        DeptId = c.Long(),
                        EqupId = c.Long(),
                        ProjectId = c.Long(),
                        PurposeId = c.Long(),
                        BankId = c.Long(),
                        CustId = c.Long(),
                        VendId = c.Long(),
                        EmplId = c.Long(),
                        PosId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.invent_dim_default",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BusinessUnit = c.Long(),
                        SiteId = c.Long(),
                        PosId = c.Long(),
                        WarehouseId = c.Long(),
                        VendId = c.Long(),
                        ItemId = c.Long(),
                        ItemGroupId = c.Long(),
                        ItemSizeId = c.Long(),
                        ItemColorId = c.Long(),
                        ItemVariantId = c.Long(),
                        ItemBatchId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ledger_calender",
                c => new
                    {
                        CalenderId = c.Int(nullable: false, identity: true),
                        CalenderName = c.String(maxLength: 100),
                        StartMonth = c.Int(),
                        ClosingPeriods = c.Int(),
                    })
                .PrimaryKey(t => t.CalenderId);
            
            CreateTable(
                "dbo.ledger_year",
                c => new
                    {
                        YearId = c.Int(nullable: false, identity: true),
                        YearName = c.String(maxLength: 100),
                        IsOpen = c.Boolean(nullable: false),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        CalenderId_CalenderId = c.Int(),
                    })
                .PrimaryKey(t => t.YearId)
                .ForeignKey("dbo.ledger_calender", t => t.CalenderId_CalenderId)
                .Index(t => t.CalenderId_CalenderId);
            
            CreateTable(
                "dbo.sec_principal",
                c => new
                    {
                        PrincipalId = c.String(nullable: false, maxLength: 120),
                        PrincipalName = c.String(maxLength: 120),
                    })
                .PrimaryKey(t => t.PrincipalId);
            
            CreateTable(
                "dbo.sec_access_type",
                c => new
                    {
                        AccessType = c.Int(nullable: false, identity: true),
                        AccessTypeName = c.String(maxLength: 100),
                        AccessTypeDescription = c.String(maxLength: 100),
                        AccessTypeType = c.Int(nullable: false),
                        AllowRead = c.Int(nullable: false),
                        AllowCreate = c.Int(nullable: false),
                        AllowRemove = c.Int(nullable: false),
                        AllowApprove = c.Int(nullable: false),
                        AllowReject = c.Int(nullable: false),
                        AllowPost = c.Int(nullable: false),
                        AllowUnpost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccessType);
            
            CreateTable(
                "dbo.ui_label",
                c => new
                    {
                        LabelId = c.String(nullable: false, maxLength: 200),
                        FieldName = c.String(maxLength: 200),
                        LookupCode = c.Int(nullable: false),
                        LookupFilterExp = c.String(maxLength: 200),
                        Grid_IsHidden = c.Boolean(nullable: false),
                        Grid_IsDisabled = c.Boolean(nullable: false),
                        Grid_Width = c.Int(nullable: false),
                        Grid_VisibleOrder = c.Int(nullable: false),
                        Grid_LookupFormRef = c.Int(nullable: false),
                        BaseType_BaseTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.LabelId)
                .ForeignKey("dbo.base_type", t => t.BaseType_BaseTypeId)
                .Index(t => t.BaseType_BaseTypeId);
            
            CreateTable(
                "dbo.ui_label_lang_txt",
                c => new
                    {
                        LabelId = c.String(nullable: false, maxLength: 200),
                        LabelType = c.Int(nullable: false),
                        LangId = c.String(nullable: false, maxLength: 5),
                        Txt = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => new { t.LabelId, t.LabelType, t.LangId })
                .ForeignKey("dbo.ui_label", t => t.LabelId, cascadeDelete: true)
                .Index(t => t.LabelId);
            
            CreateTable(
                "dbo.account_base",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        MainAccount_Id = c.Long(),
                        TaxGroup_Id = c.Long(),
                        Country_IsoCode = c.String(maxLength: 5),
                        CompanyId = c.Int(),
                        Name = c.String(nullable: false, maxLength: 250),
                        DisplayNum = c.String(nullable: false, maxLength: 50),
                        ReferenceNum = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        GroupId = c.Long(),
                        DisplayNumSequ = c.Long(nullable: false),
                        MainAccountSetManually = c.Boolean(nullable: false),
                        Suspended = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .ForeignKey("dbo.main_account", t => t.MainAccount_Id)
                .ForeignKey("dbo.tax_group", t => t.TaxGroup_Id)
                .ForeignKey("dbo.country", t => t.Country_IsoCode)
                .Index(t => t.Id)
                .Index(t => t.MainAccount_Id)
                .Index(t => t.TaxGroup_Id)
                .Index(t => t.Country_IsoCode);
            
            CreateTable(
                "dbo.account_group",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        GroupedBaseType_BaseTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .ForeignKey("dbo.base_type", t => t.GroupedBaseType_BaseTypeId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.GroupedBaseType_BaseTypeId);
            
            CreateTable(
                "dbo.account_address",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        City_CityId = c.Long(),
                        Country_IsoCode = c.String(maxLength: 5),
                        Addr = c.String(maxLength: 250),
                        ContactName = c.String(maxLength: 150),
                        TaxGroup = c.Long(),
                        TaxFileNum = c.String(maxLength: 50),
                        TaxCardNum = c.String(maxLength: 50),
                        TaxCommRegisterNum = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .ForeignKey("dbo.city", t => t.City_CityId)
                .ForeignKey("dbo.country", t => t.Country_IsoCode)
                .Index(t => t.Id)
                .Index(t => t.City_CityId)
                .Index(t => t.Country_IsoCode);
            
            CreateTable(
                "dbo.bank",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        CreditLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.doc_base",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        City_CityId = c.Long(),
                        Country_IsoCode = c.String(maxLength: 5),
                        CompanyId = c.Int(),
                        TransDate = c.DateTime(),
                        TransDayId = c.Int(),
                        HeadAccountBaseTypeId = c.Int(nullable: false),
                        HeadAccountId = c.Long(),
                        HeadAccountName = c.String(maxLength: 250),
                        HeadLedgerAccountId = c.Long(),
                        PostingPeriod = c.Long(),
                        Address = c.String(maxLength: 250),
                        ContactName = c.String(maxLength: 150),
                        TaxGroup = c.Long(),
                        TaxFileNum = c.String(),
                        TaxCardNum = c.String(),
                        TaxCommRegisterNum = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .ForeignKey("dbo.city", t => t.City_CityId)
                .ForeignKey("dbo.country", t => t.Country_IsoCode)
                .Index(t => t.Id)
                .Index(t => t.City_CityId)
                .Index(t => t.Country_IsoCode);
            
            CreateTable(
                "dbo.doc_gl",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        DocTotalCC = c.Decimal(precision: 18, scale: 2),
                        CurrencyCode = c.String(maxLength: 5),
                        CurrencyExch = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DocTotalFC = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.doc_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.doc_line",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        DocumentId = c.Long(),
                        LineNum = c.Int(),
                        LedgerActType = c.Int(nullable: false),
                        LedgerActId = c.Long(),
                        MainAccount = c.Long(),
                        BusinessUnit = c.Long(),
                        SiteId = c.Long(),
                        DeptId = c.Long(),
                        EqupId = c.Long(),
                        ProjectId = c.Long(),
                        PurposeId = c.Long(),
                        BankId = c.Long(),
                        CustId = c.Long(),
                        VendId = c.Long(),
                        EmplId = c.Long(),
                        PosId = c.Long(),
                        OffsetMainAccount = c.Long(),
                        OffsetBusinessUnit = c.Long(),
                        OffsetSiteId = c.Long(),
                        OffsetDeptId = c.Long(),
                        OffsetEqupId = c.Long(),
                        OffsetProjectId = c.Long(),
                        OffsetPurposeId = c.Long(),
                        OffsetBankId = c.Long(),
                        OffsetCustId = c.Long(),
                        OffsetVendId = c.Long(),
                        OffsetEmplId = c.Long(),
                        OffsetPosId = c.Long(),
                        LineTxt = c.String(maxLength: 200),
                        Qty = c.Decimal(precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InitValueFC = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrencyCode = c.String(maxLength: 5),
                        ExchRate = c.Decimal(precision: 18, scale: 2),
                        InitValue = c.Decimal(precision: 18, scale: 2),
                        DiscountId = c.Long(),
                        DiscountRate = c.Decimal(precision: 18, scale: 2),
                        DiscountValue = c.Decimal(precision: 18, scale: 2),
                        BeforeTaxValue = c.Decimal(precision: 18, scale: 2),
                        TaxGroupId = c.Long(),
                        TaxCodeId = c.Long(),
                        TaxAmount = c.Decimal(precision: 18, scale: 2),
                        LineValue = c.Decimal(precision: 18, scale: 2),
                        LineTotalEffect = c.Int(nullable: false),
                        CostPrice = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.doc_line_invent",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        WarehouseId = c.Long(),
                        ItemId = c.Long(),
                        ItemGroupId = c.Long(),
                        ItemSizeId = c.Long(),
                        ItemColorId = c.Long(),
                        ItemVariantId = c.Long(),
                        ItemBatchId = c.Long(),
                        SerialList = c.String(),
                        ItemDesc = c.String(maxLength: 250),
                        PurchPrice = c.Decimal(precision: 18, scale: 2),
                        SalesPrice = c.Decimal(precision: 18, scale: 2),
                        TargetWarehouseId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.doc_line", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        IdentityCard = c.String(maxLength: 30),
                        InsuranceNum = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.item_batch",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        GuaranteeVendorId_Id = c.Long(),
                        BatchNum = c.String(maxLength: 60),
                        BatchName = c.String(maxLength: 60),
                        ExpireDate = c.DateTime(),
                        GuaranteeMonths = c.Int(),
                        ItemBatchType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .ForeignKey("dbo.vendor", t => t.GuaranteeVendorId_Id)
                .Index(t => t.Id)
                .Index(t => t.GuaranteeVendorId_Id);
            
            CreateTable(
                "dbo.item_batch_serial",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SerialNum = c.String(maxLength: 60),
                        SerialReference = c.String(maxLength: 30),
                        ItemSerialStatus = c.Int(nullable: false),
                        ItemBatch = c.Long(),
                        CustId = c.Long(),
                        CustName = c.String(maxLength: 100),
                        PosId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.item_color",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Item_Id = c.Long(),
                        SizeEnum = c.Int(nullable: false),
                        ItemColorName = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .ForeignKey("dbo.item", t => t.Item_Id)
                .Index(t => t.Id)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.item",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        PurchPrice = c.Decimal(precision: 18, scale: 2),
                        SalesPrice = c.Decimal(precision: 18, scale: 2),
                        SalesPriceMin = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.item_size",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Item_Id = c.Long(),
                        SizeEnum = c.Int(nullable: false),
                        ItemSizeName = c.String(maxLength: 60),
                        BasicSizeConvertFactor = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .ForeignKey("dbo.item", t => t.Item_Id)
                .Index(t => t.Id)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.item_variants",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        BarCode = c.String(),
                        PurchPrice = c.Decimal(precision: 18, scale: 2),
                        SalesPrice = c.Decimal(precision: 18, scale: 2),
                        SalesPriceMin = c.Decimal(precision: 18, scale: 2),
                        BuyFromCustomer = c.Boolean(nullable: false),
                        Item = c.Long(),
                        ItemSizeId = c.Long(),
                        ItemColorId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.journal_type",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        CompanyId = c.Int(),
                        JourType = c.Int(nullable: false),
                        JourName = c.String(nullable: false, maxLength: 100),
                        PostingLayer = c.Int(nullable: false),
                        SequId = c.Long(),
                        SequGenerateAtPosting = c.Boolean(nullable: false),
                        DetailSummary = c.Int(nullable: false),
                        AmountsInclueTax = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ledger_journal",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Document_Id = c.Long(),
                        Journal_Id = c.Long(),
                        PostingPeriod_PeriodId = c.Int(),
                        CompanyId = c.Long(),
                        JourType = c.Int(nullable: false),
                        DetailSummary = c.Int(nullable: false),
                        PostingLayer = c.Int(nullable: false),
                        PostingDate = c.DateTime(),
                        DocumentDate = c.DateTime(),
                        VoucherNum = c.String(maxLength: 30),
                        Txt = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .ForeignKey("dbo.doc_base", t => t.Document_Id)
                .ForeignKey("dbo.journal_type", t => t.Journal_Id)
                .ForeignKey("dbo.ledger_period", t => t.PostingPeriod_PeriodId)
                .Index(t => t.Id)
                .Index(t => t.Document_Id)
                .Index(t => t.Journal_Id)
                .Index(t => t.PostingPeriod_PeriodId);
            
            CreateTable(
                "dbo.main_account_group",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        GroupNum = c.String(maxLength: 50),
                        GroupName = c.String(nullable: false, maxLength: 100),
                        MainAccountType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.main_account",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        MainAccountGroup_Id = c.Long(),
                        MainAccountType = c.Int(nullable: false),
                        IsTotal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .ForeignKey("dbo.main_account_group", t => t.MainAccountGroup_Id)
                .Index(t => t.Id)
                .Index(t => t.MainAccountGroup_Id);
            
            CreateTable(
                "dbo.payment_term",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        PaymTermCode = c.String(maxLength: 30),
                        PaymTermName = c.String(maxLength: 60),
                        DownPaymentPercentage = c.Decimal(precision: 18, scale: 2),
                        PaymentsCount = c.Int(),
                        DaysBetweenPayments = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.pos",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ArAccount_Id = c.Long(),
                        CashAccount_Id = c.Long(),
                        ExpenseJournal_Id = c.Long(),
                        InventTransferJournal_Id = c.Long(),
                        PosManager_Id = c.Long(),
                        SalesJournal_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .ForeignKey("dbo.main_account", t => t.ArAccount_Id)
                .ForeignKey("dbo.main_account", t => t.CashAccount_Id)
                .ForeignKey("dbo.journal_type", t => t.ExpenseJournal_Id)
                .ForeignKey("dbo.journal_type", t => t.InventTransferJournal_Id)
                .ForeignKey("dbo.Employee", t => t.PosManager_Id)
                .ForeignKey("dbo.journal_type", t => t.SalesJournal_Id)
                .Index(t => t.Id)
                .Index(t => t.ArAccount_Id)
                .Index(t => t.CashAccount_Id)
                .Index(t => t.ExpenseJournal_Id)
                .Index(t => t.InventTransferJournal_Id)
                .Index(t => t.PosManager_Id)
                .Index(t => t.SalesJournal_Id);
            
            CreateTable(
                "dbo.sec_principal_role_mem",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        RolePrincipalId = c.String(maxLength: 120),
                        MemberPrincipalId = c.String(maxLength: 120),
                        EffectiveFrom = c.DateTime(),
                        EffectiveTo = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.sec_principal_role",
                c => new
                    {
                        PrincipalId = c.String(nullable: false, maxLength: 120),
                        RoleType = c.Int(nullable: false),
                        ObjectId = c.Long(),
                    })
                .PrimaryKey(t => t.PrincipalId)
                .ForeignKey("dbo.sec_principal", t => t.PrincipalId)
                .Index(t => t.PrincipalId);
            
            CreateTable(
                "dbo.sec_principal_user",
                c => new
                    {
                        PrincipalId = c.String(nullable: false, maxLength: 120),
                        UserKey = c.Int(nullable: false),
                        EmplId = c.Long(),
                        Pwd = c.String(maxLength: 500),
                        UserImage = c.Binary(),
                        DefaultCompany = c.Int(),
                        LastUserJob = c.Long(),
                        EffectiveFrom = c.DateTime(),
                        EffectiveTo = c.DateTime(),
                    })
                .PrimaryKey(t => t.PrincipalId)
                .ForeignKey("dbo.sec_principal", t => t.PrincipalId)
                .Index(t => t.PrincipalId);
            
            CreateTable(
                "dbo.tax_code",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ApTaxAccount_Id = c.Long(),
                        ArTaxAccount_Id = c.Long(),
                        SettlementTaxAccount_Id = c.Long(),
                        CompanyId = c.Int(),
                        TaxCodeId = c.String(maxLength: 10),
                        TaxCodeName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .ForeignKey("dbo.main_account", t => t.ApTaxAccount_Id)
                .ForeignKey("dbo.main_account", t => t.ArTaxAccount_Id)
                .ForeignKey("dbo.main_account", t => t.SettlementTaxAccount_Id)
                .Index(t => t.Id)
                .Index(t => t.ApTaxAccount_Id)
                .Index(t => t.ArTaxAccount_Id)
                .Index(t => t.SettlementTaxAccount_Id);
            
            CreateTable(
                "dbo.tax_code_value_setup",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        TaxCodeId = c.Long(),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        FromAmount = c.Decimal(precision: 18, scale: 2),
                        ToAmount = c.Decimal(precision: 18, scale: 2),
                        TaxValueType = c.Int(nullable: false),
                        TaxValue = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.tax_group_member_setup",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        TaxGroupId = c.Long(),
                        TaxCodeId = c.Long(),
                        IsDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.tax_group",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        CompanyId = c.Int(),
                        GroupName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.vendor",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.cash",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Employee = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.account_base", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.cash", "Id", "dbo.account_base");
            DropForeignKey("dbo.vendor", "Id", "dbo.account_base");
            DropForeignKey("dbo.tax_group", "Id", "dbo.line_base");
            DropForeignKey("dbo.tax_group_member_setup", "Id", "dbo.line_base");
            DropForeignKey("dbo.tax_code_value_setup", "Id", "dbo.line_base");
            DropForeignKey("dbo.tax_code", "SettlementTaxAccount_Id", "dbo.main_account");
            DropForeignKey("dbo.tax_code", "ArTaxAccount_Id", "dbo.main_account");
            DropForeignKey("dbo.tax_code", "ApTaxAccount_Id", "dbo.main_account");
            DropForeignKey("dbo.tax_code", "Id", "dbo.line_base");
            DropForeignKey("dbo.sec_principal_user", "PrincipalId", "dbo.sec_principal");
            DropForeignKey("dbo.sec_principal_role", "PrincipalId", "dbo.sec_principal");
            DropForeignKey("dbo.sec_principal_role_mem", "Id", "dbo.line_base");
            DropForeignKey("dbo.pos", "SalesJournal_Id", "dbo.journal_type");
            DropForeignKey("dbo.pos", "PosManager_Id", "dbo.Employee");
            DropForeignKey("dbo.pos", "InventTransferJournal_Id", "dbo.journal_type");
            DropForeignKey("dbo.pos", "ExpenseJournal_Id", "dbo.journal_type");
            DropForeignKey("dbo.pos", "CashAccount_Id", "dbo.main_account");
            DropForeignKey("dbo.pos", "ArAccount_Id", "dbo.main_account");
            DropForeignKey("dbo.pos", "Id", "dbo.account_base");
            DropForeignKey("dbo.payment_term", "Id", "dbo.line_base");
            DropForeignKey("dbo.main_account", "MainAccountGroup_Id", "dbo.main_account_group");
            DropForeignKey("dbo.main_account", "Id", "dbo.account_base");
            DropForeignKey("dbo.main_account_group", "Id", "dbo.line_base");
            DropForeignKey("dbo.ledger_journal", "PostingPeriod_PeriodId", "dbo.ledger_period");
            DropForeignKey("dbo.ledger_journal", "Journal_Id", "dbo.journal_type");
            DropForeignKey("dbo.ledger_journal", "Document_Id", "dbo.doc_base");
            DropForeignKey("dbo.ledger_journal", "Id", "dbo.line_base");
            DropForeignKey("dbo.journal_type", "Id", "dbo.line_base");
            DropForeignKey("dbo.item_variants", "Id", "dbo.account_base");
            DropForeignKey("dbo.item_size", "Item_Id", "dbo.item");
            DropForeignKey("dbo.item_size", "Id", "dbo.line_base");
            DropForeignKey("dbo.item", "Id", "dbo.account_base");
            DropForeignKey("dbo.item_color", "Item_Id", "dbo.item");
            DropForeignKey("dbo.item_color", "Id", "dbo.line_base");
            DropForeignKey("dbo.item_batch_serial", "Id", "dbo.line_base");
            DropForeignKey("dbo.item_batch", "GuaranteeVendorId_Id", "dbo.vendor");
            DropForeignKey("dbo.item_batch", "Id", "dbo.line_base");
            DropForeignKey("dbo.Employee", "Id", "dbo.account_base");
            DropForeignKey("dbo.doc_line_invent", "Id", "dbo.doc_line");
            DropForeignKey("dbo.doc_line", "Id", "dbo.line_base");
            DropForeignKey("dbo.doc_gl", "Id", "dbo.doc_base");
            DropForeignKey("dbo.doc_base", "Country_IsoCode", "dbo.country");
            DropForeignKey("dbo.doc_base", "City_CityId", "dbo.city");
            DropForeignKey("dbo.doc_base", "Id", "dbo.line_base");
            DropForeignKey("dbo.customer", "Id", "dbo.account_base");
            DropForeignKey("dbo.bank", "Id", "dbo.account_base");
            DropForeignKey("dbo.account_address", "Country_IsoCode", "dbo.country");
            DropForeignKey("dbo.account_address", "City_CityId", "dbo.city");
            DropForeignKey("dbo.account_address", "Id", "dbo.line_base");
            DropForeignKey("dbo.account_group", "GroupedBaseType_BaseTypeId", "dbo.base_type");
            DropForeignKey("dbo.account_group", "Id", "dbo.account_base");
            DropForeignKey("dbo.account_base", "Country_IsoCode", "dbo.country");
            DropForeignKey("dbo.account_base", "TaxGroup_Id", "dbo.tax_group");
            DropForeignKey("dbo.account_base", "MainAccount_Id", "dbo.main_account");
            DropForeignKey("dbo.account_base", "Id", "dbo.line_base");
            DropForeignKey("dbo.ui_label_lang_txt", "LabelId", "dbo.ui_label");
            DropForeignKey("dbo.ui_label", "BaseType_BaseTypeId", "dbo.base_type");
            DropForeignKey("dbo.ledger_year", "CalenderId_CalenderId", "dbo.ledger_calender");
            DropForeignKey("dbo.city", "Country_IsoCode", "dbo.country");
            DropForeignKey("dbo.line_base", "BaseType_BaseTypeId", "dbo.base_type");
            DropIndex("dbo.cash", new[] { "Id" });
            DropIndex("dbo.vendor", new[] { "Id" });
            DropIndex("dbo.tax_group", new[] { "Id" });
            DropIndex("dbo.tax_group_member_setup", new[] { "Id" });
            DropIndex("dbo.tax_code_value_setup", new[] { "Id" });
            DropIndex("dbo.tax_code", new[] { "SettlementTaxAccount_Id" });
            DropIndex("dbo.tax_code", new[] { "ArTaxAccount_Id" });
            DropIndex("dbo.tax_code", new[] { "ApTaxAccount_Id" });
            DropIndex("dbo.tax_code", new[] { "Id" });
            DropIndex("dbo.sec_principal_user", new[] { "PrincipalId" });
            DropIndex("dbo.sec_principal_role", new[] { "PrincipalId" });
            DropIndex("dbo.sec_principal_role_mem", new[] { "Id" });
            DropIndex("dbo.pos", new[] { "SalesJournal_Id" });
            DropIndex("dbo.pos", new[] { "PosManager_Id" });
            DropIndex("dbo.pos", new[] { "InventTransferJournal_Id" });
            DropIndex("dbo.pos", new[] { "ExpenseJournal_Id" });
            DropIndex("dbo.pos", new[] { "CashAccount_Id" });
            DropIndex("dbo.pos", new[] { "ArAccount_Id" });
            DropIndex("dbo.pos", new[] { "Id" });
            DropIndex("dbo.payment_term", new[] { "Id" });
            DropIndex("dbo.main_account", new[] { "MainAccountGroup_Id" });
            DropIndex("dbo.main_account", new[] { "Id" });
            DropIndex("dbo.main_account_group", new[] { "Id" });
            DropIndex("dbo.ledger_journal", new[] { "PostingPeriod_PeriodId" });
            DropIndex("dbo.ledger_journal", new[] { "Journal_Id" });
            DropIndex("dbo.ledger_journal", new[] { "Document_Id" });
            DropIndex("dbo.ledger_journal", new[] { "Id" });
            DropIndex("dbo.journal_type", new[] { "Id" });
            DropIndex("dbo.item_variants", new[] { "Id" });
            DropIndex("dbo.item_size", new[] { "Item_Id" });
            DropIndex("dbo.item_size", new[] { "Id" });
            DropIndex("dbo.item", new[] { "Id" });
            DropIndex("dbo.item_color", new[] { "Item_Id" });
            DropIndex("dbo.item_color", new[] { "Id" });
            DropIndex("dbo.item_batch_serial", new[] { "Id" });
            DropIndex("dbo.item_batch", new[] { "GuaranteeVendorId_Id" });
            DropIndex("dbo.item_batch", new[] { "Id" });
            DropIndex("dbo.Employee", new[] { "Id" });
            DropIndex("dbo.doc_line_invent", new[] { "Id" });
            DropIndex("dbo.doc_line", new[] { "Id" });
            DropIndex("dbo.doc_gl", new[] { "Id" });
            DropIndex("dbo.doc_base", new[] { "Country_IsoCode" });
            DropIndex("dbo.doc_base", new[] { "City_CityId" });
            DropIndex("dbo.doc_base", new[] { "Id" });
            DropIndex("dbo.customer", new[] { "Id" });
            DropIndex("dbo.bank", new[] { "Id" });
            DropIndex("dbo.account_address", new[] { "Country_IsoCode" });
            DropIndex("dbo.account_address", new[] { "City_CityId" });
            DropIndex("dbo.account_address", new[] { "Id" });
            DropIndex("dbo.account_group", new[] { "GroupedBaseType_BaseTypeId" });
            DropIndex("dbo.account_group", new[] { "Id" });
            DropIndex("dbo.account_base", new[] { "Country_IsoCode" });
            DropIndex("dbo.account_base", new[] { "TaxGroup_Id" });
            DropIndex("dbo.account_base", new[] { "MainAccount_Id" });
            DropIndex("dbo.account_base", new[] { "Id" });
            DropIndex("dbo.ui_label_lang_txt", new[] { "LabelId" });
            DropIndex("dbo.ui_label", new[] { "BaseType_BaseTypeId" });
            DropIndex("dbo.ledger_year", new[] { "CalenderId_CalenderId" });
            DropIndex("dbo.city", new[] { "Country_IsoCode" });
            DropIndex("dbo.line_base", new[] { "BaseType_BaseTypeId" });
            DropTable("dbo.cash");
            DropTable("dbo.vendor");
            DropTable("dbo.tax_group");
            DropTable("dbo.tax_group_member_setup");
            DropTable("dbo.tax_code_value_setup");
            DropTable("dbo.tax_code");
            DropTable("dbo.sec_principal_user");
            DropTable("dbo.sec_principal_role");
            DropTable("dbo.sec_principal_role_mem");
            DropTable("dbo.pos");
            DropTable("dbo.payment_term");
            DropTable("dbo.main_account");
            DropTable("dbo.main_account_group");
            DropTable("dbo.ledger_journal");
            DropTable("dbo.journal_type");
            DropTable("dbo.item_variants");
            DropTable("dbo.item_size");
            DropTable("dbo.item");
            DropTable("dbo.item_color");
            DropTable("dbo.item_batch_serial");
            DropTable("dbo.item_batch");
            DropTable("dbo.Employee");
            DropTable("dbo.doc_line_invent");
            DropTable("dbo.doc_line");
            DropTable("dbo.doc_gl");
            DropTable("dbo.doc_base");
            DropTable("dbo.customer");
            DropTable("dbo.bank");
            DropTable("dbo.account_address");
            DropTable("dbo.account_group");
            DropTable("dbo.account_base");
            DropTable("dbo.ui_label_lang_txt");
            DropTable("dbo.ui_label");
            DropTable("dbo.sec_access_type");
            DropTable("dbo.sec_principal");
            DropTable("dbo.ledger_year");
            DropTable("dbo.ledger_calender");
            DropTable("dbo.invent_dim_default");
            DropTable("dbo.dim_default");
            DropTable("dbo.currency");
            DropTable("dbo.company");
            DropTable("dbo.ledger_period");
            DropTable("dbo.country");
            DropTable("dbo.city");
            DropTable("dbo.base_type");
            DropTable("dbo.line_base");
        }
    }
}
