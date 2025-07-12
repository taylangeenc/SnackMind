namespace SnackMindData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SnackMind : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        DatabaseName = c.String(),
                        City = c.String(),
                        Town = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        FirmRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Firms", t => t.FirmRef, cascadeDelete: false)
                .Index(t => t.FirmRef);
            
            CreateTable(
                "dbo.CashShifts",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        OpeningCash = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClosingCash = c.Decimal(precision: 18, scale: 2),
                        OpenedDate = c.DateTime(nullable: false),
                        ClosedDate = c.DateTime(),
                        BranchRef = c.Guid(nullable: false),
                        UserRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Branches", t => t.BranchRef, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserRef, cascadeDelete: false)
                .Index(t => t.BranchRef)
                .Index(t => t.UserRef);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        TransactionCode = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDate = c.DateTime(nullable: false),
                        OrderRef = c.Guid(nullable: false),
                        CashShiftRef = c.Guid(),
                        PaymentTypeRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.CashShifts", t => t.CashShiftRef)
                .ForeignKey("dbo.Orders", t => t.OrderRef, cascadeDelete: false)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentTypeRef, cascadeDelete: false)
                .Index(t => t.OrderRef)
                .Index(t => t.CashShiftRef)
                .Index(t => t.PaymentTypeRef);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsPaid = c.Boolean(nullable: false),
                        OpenedDate = c.DateTime(nullable: false),
                        ClosedDate = c.DateTime(),
                        BranchRef = c.Guid(nullable: false),
                        TableRef = c.Guid(nullable: false),
                        UserRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Branches", t => t.BranchRef, cascadeDelete: false)
                .ForeignKey("dbo.Tables", t => t.TableRef, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserRef, cascadeDelete: false)
                .Index(t => t.BranchRef)
                .Index(t => t.TableRef)
                .Index(t => t.UserRef);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsPrintedToKitchen = c.Boolean(nullable: false),
                        ProductRef = c.Guid(nullable: false),
                        ProductVariantRef = c.Guid(nullable: false),
                        OrderRef = c.Guid(nullable: false),
                        OrderItemStateRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Orders", t => t.OrderRef, cascadeDelete: false)
                .ForeignKey("dbo.OrderItemStates", t => t.OrderItemStateRef, cascadeDelete: false)
                .ForeignKey("dbo.Products", t => t.ProductRef, cascadeDelete: false)
                .ForeignKey("dbo.ProductVariants", t => t.ProductVariantRef, cascadeDelete: false)
                .Index(t => t.ProductRef)
                .Index(t => t.ProductVariantRef)
                .Index(t => t.OrderRef)
                .Index(t => t.OrderItemStateRef);
            
            CreateTable(
                "dbo.OrderItemStates",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        StockCode = c.String(),
                        ImagePath = c.String(),
                        Barcode = c.String(),
                        SalesPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsComposite = c.Boolean(nullable: false),
                        CategoryRef = c.Guid(nullable: false),
                        UnitRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryRef, cascadeDelete: false)
                .ForeignKey("dbo.Units", t => t.UnitRef, cascadeDelete: false)
                .Index(t => t.CategoryRef)
                .Index(t => t.UnitRef);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        ParentCategoryRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.ParentCategories", t => t.ParentCategoryRef, cascadeDelete: false)
                .Index(t => t.ParentCategoryRef);
            
            CreateTable(
                "dbo.ParentCategories",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.ProductPurchaseOrderItems",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReceivedDate = c.DateTime(),
                        ProductRef = c.Guid(nullable: false),
                        PurchaseOrderRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Products", t => t.ProductRef, cascadeDelete: false)
                .ForeignKey("dbo.PurchaseOrders", t => t.PurchaseOrderRef, cascadeDelete: false)
                .Index(t => t.ProductRef)
                .Index(t => t.PurchaseOrderRef);
            
            CreateTable(
                "dbo.PurchaseOrders",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        OrderCode = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        ExpectedDeliveryDate = c.DateTime(),
                        SupplierRef = c.Guid(nullable: false),
                        PurchaseOrderStateRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.PurchaseOrderStates", t => t.PurchaseOrderStateRef, cascadeDelete: false)
                .ForeignKey("dbo.Suppliers", t => t.SupplierRef, cascadeDelete: false)
                .Index(t => t.SupplierRef)
                .Index(t => t.PurchaseOrderStateRef);
            
            CreateTable(
                "dbo.IngredientPurchaseOrderItems",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReceivedDate = c.DateTime(),
                        IngredientRef = c.Guid(nullable: false),
                        PurchaseOrderRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Ingredients", t => t.IngredientRef, cascadeDelete: false)
                .ForeignKey("dbo.PurchaseOrders", t => t.PurchaseOrderRef, cascadeDelete: false)
                .Index(t => t.IngredientRef)
                .Index(t => t.PurchaseOrderRef);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        CostPerUnit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinStockLevel = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxStockLevel = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsPerishable = c.Boolean(nullable: false),
                        ExpirationDate = c.DateTime(),
                        UnitRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Units", t => t.UnitRef, cascadeDelete: false)
                .Index(t => t.UnitRef);
            
            CreateTable(
                "dbo.ProductStockMovements",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MovementDate = c.DateTime(nullable: false),
                        ProductStockRef = c.Guid(nullable: false),
                        UnitRef = c.Guid(nullable: false),
                        WarehouseRef = c.Guid(nullable: false),
                        UserRef = c.Guid(nullable: false),
                        StockMovementTypeRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        mdlIngredient_Ref = c.Guid(),
                        mdlProduct_Ref = c.Guid(),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.ProductStocks", t => t.ProductStockRef, cascadeDelete: false)
                .ForeignKey("dbo.StockMovementTypes", t => t.StockMovementTypeRef, cascadeDelete: false)
                .ForeignKey("dbo.Units", t => t.UnitRef, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserRef, cascadeDelete: false)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseRef, cascadeDelete: false)
                .ForeignKey("dbo.Ingredients", t => t.mdlIngredient_Ref)
                .ForeignKey("dbo.Products", t => t.mdlProduct_Ref)
                .Index(t => t.ProductStockRef)
                .Index(t => t.UnitRef)
                .Index(t => t.WarehouseRef)
                .Index(t => t.UserRef)
                .Index(t => t.StockMovementTypeRef)
                .Index(t => t.mdlIngredient_Ref)
                .Index(t => t.mdlProduct_Ref);
            
            CreateTable(
                "dbo.ProductStocks",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductRef = c.Guid(nullable: false),
                        UnitRef = c.Guid(nullable: false),
                        WarehouseRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Products", t => t.ProductRef, cascadeDelete: false)
                .ForeignKey("dbo.Units", t => t.UnitRef, cascadeDelete: false)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseRef, cascadeDelete: false)
                .Index(t => t.ProductRef)
                .Index(t => t.UnitRef)
                .Index(t => t.WarehouseRef);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Abbreviation = c.String(),
                        IsDefault = c.Boolean(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.IngredientStockMovements",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MovementDate = c.DateTime(nullable: false),
                        IngredientStockRef = c.Guid(nullable: false),
                        UnitRef = c.Guid(nullable: false),
                        WarehouseRef = c.Guid(nullable: false),
                        UserRef = c.Guid(nullable: false),
                        StockMovementTypeRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.IngredientStocks", t => t.IngredientStockRef, cascadeDelete: false)
                .ForeignKey("dbo.StockMovementTypes", t => t.StockMovementTypeRef, cascadeDelete: false)
                .ForeignKey("dbo.Units", t => t.UnitRef, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserRef, cascadeDelete: false)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseRef, cascadeDelete: false)
                .Index(t => t.IngredientStockRef)
                .Index(t => t.UnitRef)
                .Index(t => t.WarehouseRef)
                .Index(t => t.UserRef)
                .Index(t => t.StockMovementTypeRef);
            
            CreateTable(
                "dbo.IngredientStocks",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IngredientRef = c.Guid(nullable: false),
                        UnitRef = c.Guid(nullable: false),
                        WarehouseRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Ingredients", t => t.IngredientRef, cascadeDelete: false)
                .ForeignKey("dbo.Units", t => t.UnitRef, cascadeDelete: false)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseRef, cascadeDelete: false)
                .Index(t => t.IngredientRef)
                .Index(t => t.UnitRef)
                .Index(t => t.WarehouseRef);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        BranchRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Branches", t => t.BranchRef, cascadeDelete: false)
                .Index(t => t.BranchRef);
            
            CreateTable(
                "dbo.StockMovementTypes",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        LoginName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        ImagePath = c.String(),
                        BranchRef = c.Guid(nullable: false),
                        RoleRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Branches", t => t.BranchRef, cascadeDelete: false)
                .ForeignKey("dbo.Roles", t => t.RoleRef, cascadeDelete: false)
                .Index(t => t.BranchRef)
                .Index(t => t.RoleRef);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Permission = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.Saves",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Action = c.String(),
                        Detail = c.String(),
                        LoggedDate = c.DateTime(nullable: false),
                        FirmRef = c.Guid(nullable: false),
                        BranchRef = c.Guid(nullable: false),
                        UserRef = c.Guid(nullable: false),
                        SaveTypeRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Branches", t => t.BranchRef, cascadeDelete: false)
                .ForeignKey("dbo.Firms", t => t.FirmRef, cascadeDelete: false)
                .ForeignKey("dbo.SaveTypes", t => t.SaveTypeRef, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserRef, cascadeDelete: false)
                .Index(t => t.FirmRef)
                .Index(t => t.BranchRef)
                .Index(t => t.UserRef)
                .Index(t => t.SaveTypeRef);
            
            CreateTable(
                "dbo.Firms",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        ImagePath = c.String(),
                        Address = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.SaveTypes",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.RecipeItems",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IngredientRef = c.Guid(nullable: false),
                        UnitRef = c.Guid(nullable: false),
                        RecipeRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Ingredients", t => t.IngredientRef, cascadeDelete: false)
                .ForeignKey("dbo.Recipes", t => t.RecipeRef, cascadeDelete: false)
                .ForeignKey("dbo.Units", t => t.UnitRef, cascadeDelete: false)
                .Index(t => t.IngredientRef)
                .Index(t => t.UnitRef)
                .Index(t => t.RecipeRef);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        ProductRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Products", t => t.ProductRef, cascadeDelete: false)
                .Index(t => t.ProductRef);
            
            CreateTable(
                "dbo.PurchaseOrderStates",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.ProductVariants",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        ExtraPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Products", t => t.ProductRef, cascadeDelete: false)
                .Index(t => t.ProductRef);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                        Capacity = c.Int(nullable: false),
                        IsCanReserved = c.Boolean(nullable: false),
                        ZoneRef = c.Guid(nullable: false),
                        TableStateRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.TableStates", t => t.TableStateRef, cascadeDelete: false)
                .ForeignKey("dbo.Zones", t => t.ZoneRef, cascadeDelete: false)
                .Index(t => t.ZoneRef)
                .Index(t => t.TableStateRef);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        GuestCount = c.Int(nullable: false),
                        ReservedDate = c.DateTime(nullable: false),
                        TableRef = c.Guid(nullable: false),
                        CustomerRef = c.Guid(nullable: false),
                        ReservationStateRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Customers", t => t.CustomerRef, cascadeDelete: false)
                .ForeignKey("dbo.ReservationStates", t => t.ReservationStateRef, cascadeDelete: false)
                .ForeignKey("dbo.Tables", t => t.TableRef, cascadeDelete: false)
                .Index(t => t.TableRef)
                .Index(t => t.CustomerRef)
                .Index(t => t.ReservationStateRef);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.ReservationStates",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.TableStates",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.Zones",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        IsOutdoor = c.Boolean(nullable: false),
                        BranchRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Branches", t => t.BranchRef, cascadeDelete: false)
                .Index(t => t.BranchRef);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.Printers",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        IPAddress = c.String(),
                        Quantity = c.Int(nullable: false),
                        BranchRef = c.Guid(nullable: false),
                        PrintDestinationRef = c.Guid(nullable: false),
                        PrintStateRef = c.Guid(nullable: false),
                        PrinterConnectionTypeRef = c.Guid(nullable: false),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref)
                .ForeignKey("dbo.Branches", t => t.BranchRef, cascadeDelete: false)
                .ForeignKey("dbo.PrintDestinations", t => t.PrintDestinationRef, cascadeDelete: false)
                .ForeignKey("dbo.PrinterConnectionTypes", t => t.PrinterConnectionTypeRef, cascadeDelete: false)
                .ForeignKey("dbo.PrintStates", t => t.PrintStateRef, cascadeDelete: false)
                .Index(t => t.BranchRef)
                .Index(t => t.PrintDestinationRef)
                .Index(t => t.PrintStateRef)
                .Index(t => t.PrinterConnectionTypeRef);
            
            CreateTable(
                "dbo.PrintDestinations",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.PrinterConnectionTypes",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
            CreateTable(
                "dbo.PrintStates",
                c => new
                    {
                        Ref = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ref);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Printers", "PrintStateRef", "dbo.PrintStates");
            DropForeignKey("dbo.Printers", "PrinterConnectionTypeRef", "dbo.PrinterConnectionTypes");
            DropForeignKey("dbo.Printers", "PrintDestinationRef", "dbo.PrintDestinations");
            DropForeignKey("dbo.Printers", "BranchRef", "dbo.Branches");
            DropForeignKey("dbo.Branches", "FirmRef", "dbo.Firms");
            DropForeignKey("dbo.CashShifts", "UserRef", "dbo.Users");
            DropForeignKey("dbo.Payments", "PaymentTypeRef", "dbo.PaymentTypes");
            DropForeignKey("dbo.Payments", "OrderRef", "dbo.Orders");
            DropForeignKey("dbo.Orders", "UserRef", "dbo.Users");
            DropForeignKey("dbo.Orders", "TableRef", "dbo.Tables");
            DropForeignKey("dbo.Tables", "ZoneRef", "dbo.Zones");
            DropForeignKey("dbo.Zones", "BranchRef", "dbo.Branches");
            DropForeignKey("dbo.Tables", "TableStateRef", "dbo.TableStates");
            DropForeignKey("dbo.Reservations", "TableRef", "dbo.Tables");
            DropForeignKey("dbo.Reservations", "ReservationStateRef", "dbo.ReservationStates");
            DropForeignKey("dbo.Reservations", "CustomerRef", "dbo.Customers");
            DropForeignKey("dbo.OrderItems", "ProductVariantRef", "dbo.ProductVariants");
            DropForeignKey("dbo.OrderItems", "ProductRef", "dbo.Products");
            DropForeignKey("dbo.Products", "UnitRef", "dbo.Units");
            DropForeignKey("dbo.ProductVariants", "ProductRef", "dbo.Products");
            DropForeignKey("dbo.ProductStockMovements", "mdlProduct_Ref", "dbo.Products");
            DropForeignKey("dbo.ProductPurchaseOrderItems", "PurchaseOrderRef", "dbo.PurchaseOrders");
            DropForeignKey("dbo.PurchaseOrders", "SupplierRef", "dbo.Suppliers");
            DropForeignKey("dbo.PurchaseOrders", "PurchaseOrderStateRef", "dbo.PurchaseOrderStates");
            DropForeignKey("dbo.IngredientPurchaseOrderItems", "PurchaseOrderRef", "dbo.PurchaseOrders");
            DropForeignKey("dbo.IngredientPurchaseOrderItems", "IngredientRef", "dbo.Ingredients");
            DropForeignKey("dbo.Ingredients", "UnitRef", "dbo.Units");
            DropForeignKey("dbo.ProductStockMovements", "mdlIngredient_Ref", "dbo.Ingredients");
            DropForeignKey("dbo.ProductStockMovements", "WarehouseRef", "dbo.Warehouses");
            DropForeignKey("dbo.ProductStockMovements", "UserRef", "dbo.Users");
            DropForeignKey("dbo.ProductStockMovements", "UnitRef", "dbo.Units");
            DropForeignKey("dbo.ProductStockMovements", "StockMovementTypeRef", "dbo.StockMovementTypes");
            DropForeignKey("dbo.ProductStockMovements", "ProductStockRef", "dbo.ProductStocks");
            DropForeignKey("dbo.ProductStocks", "WarehouseRef", "dbo.Warehouses");
            DropForeignKey("dbo.ProductStocks", "UnitRef", "dbo.Units");
            DropForeignKey("dbo.RecipeItems", "UnitRef", "dbo.Units");
            DropForeignKey("dbo.RecipeItems", "RecipeRef", "dbo.Recipes");
            DropForeignKey("dbo.Recipes", "ProductRef", "dbo.Products");
            DropForeignKey("dbo.RecipeItems", "IngredientRef", "dbo.Ingredients");
            DropForeignKey("dbo.IngredientStockMovements", "WarehouseRef", "dbo.Warehouses");
            DropForeignKey("dbo.IngredientStockMovements", "UserRef", "dbo.Users");
            DropForeignKey("dbo.Saves", "UserRef", "dbo.Users");
            DropForeignKey("dbo.Saves", "SaveTypeRef", "dbo.SaveTypes");
            DropForeignKey("dbo.Saves", "FirmRef", "dbo.Firms");
            DropForeignKey("dbo.Saves", "BranchRef", "dbo.Branches");
            DropForeignKey("dbo.Users", "RoleRef", "dbo.Roles");
            DropForeignKey("dbo.Users", "BranchRef", "dbo.Branches");
            DropForeignKey("dbo.IngredientStockMovements", "UnitRef", "dbo.Units");
            DropForeignKey("dbo.IngredientStockMovements", "StockMovementTypeRef", "dbo.StockMovementTypes");
            DropForeignKey("dbo.IngredientStockMovements", "IngredientStockRef", "dbo.IngredientStocks");
            DropForeignKey("dbo.IngredientStocks", "WarehouseRef", "dbo.Warehouses");
            DropForeignKey("dbo.Warehouses", "BranchRef", "dbo.Branches");
            DropForeignKey("dbo.IngredientStocks", "UnitRef", "dbo.Units");
            DropForeignKey("dbo.IngredientStocks", "IngredientRef", "dbo.Ingredients");
            DropForeignKey("dbo.ProductStocks", "ProductRef", "dbo.Products");
            DropForeignKey("dbo.ProductPurchaseOrderItems", "ProductRef", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryRef", "dbo.ProductCategories");
            DropForeignKey("dbo.ProductCategories", "ParentCategoryRef", "dbo.ParentCategories");
            DropForeignKey("dbo.OrderItems", "OrderItemStateRef", "dbo.OrderItemStates");
            DropForeignKey("dbo.OrderItems", "OrderRef", "dbo.Orders");
            DropForeignKey("dbo.Orders", "BranchRef", "dbo.Branches");
            DropForeignKey("dbo.Payments", "CashShiftRef", "dbo.CashShifts");
            DropForeignKey("dbo.CashShifts", "BranchRef", "dbo.Branches");
            DropIndex("dbo.Printers", new[] { "PrinterConnectionTypeRef" });
            DropIndex("dbo.Printers", new[] { "PrintStateRef" });
            DropIndex("dbo.Printers", new[] { "PrintDestinationRef" });
            DropIndex("dbo.Printers", new[] { "BranchRef" });
            DropIndex("dbo.Zones", new[] { "BranchRef" });
            DropIndex("dbo.Reservations", new[] { "ReservationStateRef" });
            DropIndex("dbo.Reservations", new[] { "CustomerRef" });
            DropIndex("dbo.Reservations", new[] { "TableRef" });
            DropIndex("dbo.Tables", new[] { "TableStateRef" });
            DropIndex("dbo.Tables", new[] { "ZoneRef" });
            DropIndex("dbo.ProductVariants", new[] { "ProductRef" });
            DropIndex("dbo.Recipes", new[] { "ProductRef" });
            DropIndex("dbo.RecipeItems", new[] { "RecipeRef" });
            DropIndex("dbo.RecipeItems", new[] { "UnitRef" });
            DropIndex("dbo.RecipeItems", new[] { "IngredientRef" });
            DropIndex("dbo.Saves", new[] { "SaveTypeRef" });
            DropIndex("dbo.Saves", new[] { "UserRef" });
            DropIndex("dbo.Saves", new[] { "BranchRef" });
            DropIndex("dbo.Saves", new[] { "FirmRef" });
            DropIndex("dbo.Users", new[] { "RoleRef" });
            DropIndex("dbo.Users", new[] { "BranchRef" });
            DropIndex("dbo.Warehouses", new[] { "BranchRef" });
            DropIndex("dbo.IngredientStocks", new[] { "WarehouseRef" });
            DropIndex("dbo.IngredientStocks", new[] { "UnitRef" });
            DropIndex("dbo.IngredientStocks", new[] { "IngredientRef" });
            DropIndex("dbo.IngredientStockMovements", new[] { "StockMovementTypeRef" });
            DropIndex("dbo.IngredientStockMovements", new[] { "UserRef" });
            DropIndex("dbo.IngredientStockMovements", new[] { "WarehouseRef" });
            DropIndex("dbo.IngredientStockMovements", new[] { "UnitRef" });
            DropIndex("dbo.IngredientStockMovements", new[] { "IngredientStockRef" });
            DropIndex("dbo.ProductStocks", new[] { "WarehouseRef" });
            DropIndex("dbo.ProductStocks", new[] { "UnitRef" });
            DropIndex("dbo.ProductStocks", new[] { "ProductRef" });
            DropIndex("dbo.ProductStockMovements", new[] { "mdlProduct_Ref" });
            DropIndex("dbo.ProductStockMovements", new[] { "mdlIngredient_Ref" });
            DropIndex("dbo.ProductStockMovements", new[] { "StockMovementTypeRef" });
            DropIndex("dbo.ProductStockMovements", new[] { "UserRef" });
            DropIndex("dbo.ProductStockMovements", new[] { "WarehouseRef" });
            DropIndex("dbo.ProductStockMovements", new[] { "UnitRef" });
            DropIndex("dbo.ProductStockMovements", new[] { "ProductStockRef" });
            DropIndex("dbo.Ingredients", new[] { "UnitRef" });
            DropIndex("dbo.IngredientPurchaseOrderItems", new[] { "PurchaseOrderRef" });
            DropIndex("dbo.IngredientPurchaseOrderItems", new[] { "IngredientRef" });
            DropIndex("dbo.PurchaseOrders", new[] { "PurchaseOrderStateRef" });
            DropIndex("dbo.PurchaseOrders", new[] { "SupplierRef" });
            DropIndex("dbo.ProductPurchaseOrderItems", new[] { "PurchaseOrderRef" });
            DropIndex("dbo.ProductPurchaseOrderItems", new[] { "ProductRef" });
            DropIndex("dbo.ProductCategories", new[] { "ParentCategoryRef" });
            DropIndex("dbo.Products", new[] { "UnitRef" });
            DropIndex("dbo.Products", new[] { "CategoryRef" });
            DropIndex("dbo.OrderItems", new[] { "OrderItemStateRef" });
            DropIndex("dbo.OrderItems", new[] { "OrderRef" });
            DropIndex("dbo.OrderItems", new[] { "ProductVariantRef" });
            DropIndex("dbo.OrderItems", new[] { "ProductRef" });
            DropIndex("dbo.Orders", new[] { "UserRef" });
            DropIndex("dbo.Orders", new[] { "TableRef" });
            DropIndex("dbo.Orders", new[] { "BranchRef" });
            DropIndex("dbo.Payments", new[] { "PaymentTypeRef" });
            DropIndex("dbo.Payments", new[] { "CashShiftRef" });
            DropIndex("dbo.Payments", new[] { "OrderRef" });
            DropIndex("dbo.CashShifts", new[] { "UserRef" });
            DropIndex("dbo.CashShifts", new[] { "BranchRef" });
            DropIndex("dbo.Branches", new[] { "FirmRef" });
            DropTable("dbo.PrintStates");
            DropTable("dbo.PrinterConnectionTypes");
            DropTable("dbo.PrintDestinations");
            DropTable("dbo.Printers");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Zones");
            DropTable("dbo.TableStates");
            DropTable("dbo.ReservationStates");
            DropTable("dbo.Customers");
            DropTable("dbo.Reservations");
            DropTable("dbo.Tables");
            DropTable("dbo.ProductVariants");
            DropTable("dbo.Suppliers");
            DropTable("dbo.PurchaseOrderStates");
            DropTable("dbo.Recipes");
            DropTable("dbo.RecipeItems");
            DropTable("dbo.SaveTypes");
            DropTable("dbo.Firms");
            DropTable("dbo.Saves");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.StockMovementTypes");
            DropTable("dbo.Warehouses");
            DropTable("dbo.IngredientStocks");
            DropTable("dbo.IngredientStockMovements");
            DropTable("dbo.Units");
            DropTable("dbo.ProductStocks");
            DropTable("dbo.ProductStockMovements");
            DropTable("dbo.Ingredients");
            DropTable("dbo.IngredientPurchaseOrderItems");
            DropTable("dbo.PurchaseOrders");
            DropTable("dbo.ProductPurchaseOrderItems");
            DropTable("dbo.ParentCategories");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.OrderItemStates");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Payments");
            DropTable("dbo.CashShifts");
            DropTable("dbo.Branches");
        }
    }
}