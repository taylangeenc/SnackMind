using SnackMindModel.Model.Order.Order;
using SnackMindModel.Model.Payment.Payment;
using SnackMindModel.Model.Place.Branch;
using SnackMindModel.Model.Place.Firm;
using SnackMindModel.Model.Place.Warehouse;
using SnackMindModel.Model.Place.Zone;
using SnackMindModel.Model.Product.Category;
using SnackMindModel.Model.Product.Ingredient;
using SnackMindModel.Model.Product.Product;
using SnackMindModel.Model.Product.Recipe;
using SnackMindModel.Model.Product.Stock;
using SnackMindModel.Model.Product.Stock.Ingredient;
using SnackMindModel.Model.Product.Stock.Product;
using SnackMindModel.Model.Product.Unit;
using SnackMindModel.Model.Product.Variant;
using SnackMindModel.Model.Purchase.Purchase.Ingredient;
using SnackMindModel.Model.Purchase.Purchase.Product;
using SnackMindModel.Model.Purchase.Purchase.Purchase;
using SnackMindModel.Model.Purchase.Supplier;
using SnackMindModel.Model.Reservation.Customer;
using SnackMindModel.Model.Reservation.Reservation;
using SnackMindModel.Model.Setting.Printer;
using SnackMindModel.Model.Setting.Save;
using SnackMindModel.Model.Table.Table;
using SnackMindModel.Model.User.CashShift;
using SnackMindModel.Model.User.Role;
using SnackMindModel.Model.User.User;

using System.Data.Entity;

namespace SnackMindData.Context
{
    public class SmContext : DbContext
    {
        public SmContext() : base("name=SnackMind") 
        {

        }

        #region DbSet
        public DbSet<mdlFirm> Firms { get; set; }
        public DbSet<mdlBranch> Branches { get; set; }
        public DbSet<mdlCashShift> CashShifts { get; set; }
        public DbSet<mdlCustomer> Customers { get; set; }
        public DbSet<mdlIngredient> Ingredients { get; set; }
        public DbSet<mdlIngredientPurchaseOrderItem> IngredientPurchaseOrderItems { get; set; }
        public DbSet<mdlIngredientStock> IngredientStocks { get; set; }
        public DbSet<mdlIngredientStockMovement> IngredientStockMovements { get; set; }
        public DbSet<mdlSave> Saves { get; set; }
        public DbSet<mdlSaveType> SaveTypes { get; set; }
        public DbSet<mdlOrder> Orders { get; set; }
        public DbSet<mdlOrderItem> OrderItems { get; set; }
        public DbSet<mdlOrderItemState> OrderItemStates { get; set; }
        public DbSet<mdlParentCategory> ParentCategories { get; set; }
        public DbSet<mdlPayment> Payments { get; set; }
        public DbSet<mdlPaymentType> PaymentTypes { get; set; }
        public DbSet<mdlPrinter> Printers { get; set; }
        public DbSet<mdlPrinterConnectionType> PrinterConnectionTypes { get; set; }
        public DbSet<mdlProduct> Products { get; set; }
        public DbSet<mdlProductCategory> ProductCategories { get; set; }
        public DbSet<mdlProductPurchaseOrderItem> ProductPurchaseOrderItems { get; set; }
        public DbSet<mdlProductStock> ProductStocks { get; set; }
        public DbSet<mdlProductStockMovement> ProductStockMovements { get; set; }
        public DbSet<mdlProductVariant> ProductVariants { get; set; }
        public DbSet<mdlPurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<mdlPurchaseOrderState> PurchaseOrderStates { get; set; }
        public DbSet<mdlRecipe> Recipes { get; set; }
        public DbSet<mdlRecipeItem> RecipeItems { get; set; }
        public DbSet<mdlReservation> Reservations { get; set; }
        public DbSet<mdlReservationState> ReservationStates { get; set; }
        public DbSet<mdlStockMovementType> StockMovementTypes { get; set; }
        public DbSet<mdlTable> Tables { get; set; }
        public DbSet<mdlTableState> TableStates { get; set; }
        public DbSet<mdlUnit> Units { get; set; }
        public DbSet<mdlWarehouse> Warehouses { get; set; }
        public DbSet<mdlZone> Zones { get; set; }
        public DbSet<mdlSupplier> Suppliers { get; set; }
        public DbSet<mdlRole> Roles { get; set; }
        public DbSet<mdlUser> Users { get; set; }
        public DbSet<mdlPrintDestination> PrintDestinations { get; set; }
        public DbSet<mdlPrintState> PrintStates { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Table
            modelBuilder.Entity<mdlFirm>().ToTable("Firms");
            modelBuilder.Entity<mdlBranch>().ToTable("Branches");
            modelBuilder.Entity<mdlCashShift>().ToTable("CashShifts");
            modelBuilder.Entity<mdlCustomer>().ToTable("Customers");
            modelBuilder.Entity<mdlIngredient>().ToTable("Ingredients");
            modelBuilder.Entity<mdlIngredientPurchaseOrderItem>().ToTable("IngredientPurchaseOrderItems");
            modelBuilder.Entity<mdlIngredientStock>().ToTable("IngredientStocks");
            modelBuilder.Entity<mdlIngredientStockMovement>().ToTable("IngredientStockMovements");
            modelBuilder.Entity<mdlSave>().ToTable("Saves");
            modelBuilder.Entity<mdlSaveType>().ToTable("SaveTypes");
            modelBuilder.Entity<mdlOrder>().ToTable("Orders");
            modelBuilder.Entity<mdlOrderItem>().ToTable("OrderItems");
            modelBuilder.Entity<mdlOrderItemState>().ToTable("OrderItemStates");
            modelBuilder.Entity<mdlParentCategory>().ToTable("ParentCategories");
            modelBuilder.Entity<mdlPayment>().ToTable("Payments");
            modelBuilder.Entity<mdlPaymentType>().ToTable("PaymentTypes");
            modelBuilder.Entity<mdlPrinter>().ToTable("Printers");
            modelBuilder.Entity<mdlPrinterConnectionType>().ToTable("PrinterConnectionTypes");
            modelBuilder.Entity<mdlProduct>().ToTable("Products");
            modelBuilder.Entity<mdlProductCategory>().ToTable("ProductCategories");
            modelBuilder.Entity<mdlProductPurchaseOrderItem>().ToTable("ProductPurchaseOrderItems");
            modelBuilder.Entity<mdlProductStock>().ToTable("ProductStocks");
            modelBuilder.Entity<mdlProductStockMovement>().ToTable("ProductStockMovements");
            modelBuilder.Entity<mdlProductVariant>().ToTable("ProductVariants");
            modelBuilder.Entity<mdlPurchaseOrder>().ToTable("PurchaseOrders");
            modelBuilder.Entity<mdlPurchaseOrderState>().ToTable("PurchaseOrderStates");
            modelBuilder.Entity<mdlRecipe>().ToTable("Recipes");
            modelBuilder.Entity<mdlRecipeItem>().ToTable("RecipeItems");
            modelBuilder.Entity<mdlReservation>().ToTable("Reservations");
            modelBuilder.Entity<mdlReservationState>().ToTable("ReservationStates");
            modelBuilder.Entity<mdlStockMovementType>().ToTable("StockMovementTypes");
            modelBuilder.Entity<mdlTable>().ToTable("Tables");
            modelBuilder.Entity<mdlTableState>().ToTable("TableStates");
            modelBuilder.Entity<mdlUnit>().ToTable("Units");
            modelBuilder.Entity<mdlWarehouse>().ToTable("Warehouses");
            modelBuilder.Entity<mdlZone>().ToTable("Zones");
            modelBuilder.Entity<mdlSupplier>().ToTable("Suppliers");
            modelBuilder.Entity<mdlRole>().ToTable("Roles");
            modelBuilder.Entity<mdlUser>().ToTable("Users");
            modelBuilder.Entity<mdlPrintDestination>().ToTable("PrintDestinations");
            modelBuilder.Entity<mdlPrintState>().ToTable("PrintStates");
            #endregion

            #region Primary Key
            modelBuilder.Entity<mdlBranch>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlCashShift>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlCustomer>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlFirm>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlIngredient>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlIngredientPurchaseOrderItem>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlIngredientStock>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlIngredientStockMovement>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlSave>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlSaveType>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlOrder>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlOrderItem>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlOrderItemState>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlParentCategory>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlPayment>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlPaymentType>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlPrintDestination>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlPrintState>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlPrinter>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlPrinterConnectionType>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlProduct>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlProductCategory>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlProductPurchaseOrderItem>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlProductStock>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlProductStockMovement>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlProductVariant>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlPurchaseOrder>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlPurchaseOrderState>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlRecipe>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlRecipeItem>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlReservation>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlReservationState>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlRole>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlStockMovementType>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlSupplier>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlTable>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlTableState>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlUnit>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlUser>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlWarehouse>().HasKey(x => x.Ref);
            modelBuilder.Entity<mdlZone>().HasKey(x => x.Ref);

            #endregion

            #region Foreign Key
            modelBuilder.Entity<mdlBranch>()
                .HasRequired(x => x.Firm)
                .WithMany(x => x.Branches)
                .HasForeignKey(x => x.FirmRef);

            modelBuilder.Entity<mdlWarehouse>()
                .HasRequired(x => x.Branch)
                .WithMany(x => x.Warehouses)
                .HasForeignKey(x => x.BranchRef);

            modelBuilder.Entity<mdlProductStock>()
                .HasRequired(x => x.Product)
                .WithMany(x => x.ProductStocks)
                .HasForeignKey(x => x.ProductRef);
            modelBuilder.Entity<mdlProductStock>()
                .HasRequired(x => x.Unit)
                .WithMany(x => x.ProductStocks)
                .HasForeignKey(x => x.UnitRef);
            modelBuilder.Entity<mdlProductStock>()
                .HasRequired(x => x.Warehouse)
                .WithMany(x => x.ProductStocks)
                .HasForeignKey(x => x.WarehouseRef);

            modelBuilder.Entity<mdlIngredientStock>()
                .HasRequired(x => x.Ingredient)
                .WithMany(x => x.IngredientStocks)
                .HasForeignKey(x => x.IngredientRef);
            modelBuilder.Entity<mdlIngredientStock>()
                .HasRequired(x => x.Unit)
                .WithMany(x => x.IngredientStocks)
                .HasForeignKey(x => x.UnitRef);
            modelBuilder.Entity<mdlIngredientStock>()
                .HasRequired(x => x.Warehouse)
                .WithMany(x => x.IngredientStocks)
                .HasForeignKey(x => x.WarehouseRef);

            modelBuilder.Entity<mdlProductStockMovement>()
                .HasRequired(x => x.ProductStock)
                .WithMany(x => x.ProductStockMovements)
                .HasForeignKey(x => x.ProductStockRef);
            modelBuilder.Entity<mdlProductStockMovement>()
                .HasRequired(x => x.Unit)
                .WithMany(x => x.ProductStockMovements)
                .HasForeignKey(x => x.UnitRef);
            modelBuilder.Entity<mdlProductStockMovement>()
                .HasRequired(x => x.Warehouse)
                .WithMany(x => x.ProductStockMovements)
                .HasForeignKey(x => x.WarehouseRef);
            modelBuilder.Entity<mdlProductStockMovement>()
                .HasRequired(x => x.User)
                .WithMany(x => x.ProductStockMovements)
                .HasForeignKey(x => x.UserRef);
            modelBuilder.Entity<mdlProductStockMovement>()
                .HasRequired(x => x.StockMovementType)
                .WithMany(x => x.ProductStockMovements)
                .HasForeignKey(x => x.StockMovementTypeRef);

            modelBuilder.Entity<mdlIngredientStockMovement>()
                .HasRequired(x => x.IngredientStock)
                .WithMany(x => x.IngredientStockMovements)
                .HasForeignKey(x => x.IngredientStockRef);
            modelBuilder.Entity<mdlIngredientStockMovement>()
                .HasRequired(x => x.Unit)
                .WithMany(x => x.IngredientStockMovements)
                .HasForeignKey(x => x.UnitRef);
            modelBuilder.Entity<mdlIngredientStockMovement>()
                .HasRequired(x => x.Warehouse)
                .WithMany(x => x.IngredientStockMovements)
                .HasForeignKey(x => x.WarehouseRef);
            modelBuilder.Entity<mdlIngredientStockMovement>()
                .HasRequired(x => x.User)
                .WithMany(x => x.IngredientStockMovements)
                .HasForeignKey(x => x.UserRef);
            modelBuilder.Entity<mdlIngredientStockMovement>()
                .HasRequired(x => x.StockMovementType)
                .WithMany(x => x.IngredientStockMovements)
                .HasForeignKey(x => x.StockMovementTypeRef);

            modelBuilder.Entity<mdlProduct>()
                .HasRequired(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryRef);
            modelBuilder.Entity<mdlProduct>()
                .HasRequired(x => x.Unit)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.UnitRef);

            modelBuilder.Entity<mdlProduct>()
                .HasRequired(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryRef);
            modelBuilder.Entity<mdlProduct>()
                .HasRequired(x => x.Unit)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.UnitRef);

            modelBuilder.Entity<mdlIngredient>()
                .HasRequired(x => x.Unit)
                .WithMany(x => x.Ingredients)
                .HasForeignKey(x => x.UnitRef);

            modelBuilder.Entity<mdlProductCategory>()
                .HasRequired(x => x.ParentCategory)
                .WithMany(x => x.ProductCategories)
                .HasForeignKey(x => x.ParentCategoryRef);

            modelBuilder.Entity<mdlProductVariant>()
                .HasRequired(x => x.Product)
                .WithMany(x => x.ProductVariants)
                .HasForeignKey(x => x.ProductRef);

            modelBuilder.Entity<mdlRecipeItem>()
                .HasRequired(x => x.Ingredient)
                .WithMany(x => x.RecipeItems)
                .HasForeignKey(x => x.IngredientRef);
            modelBuilder.Entity<mdlRecipeItem>()
                .HasRequired(x => x.Unit)
                .WithMany(x => x.RecipeItems)
                .HasForeignKey(x => x.UnitRef);
            modelBuilder.Entity<mdlRecipeItem>()
                .HasRequired(x => x.Recipe)
                .WithMany(x => x.RecipeItems)
                .HasForeignKey(x => x.RecipeRef);

            modelBuilder.Entity<mdlRecipe>()
                .HasRequired(x => x.Product)
                .WithMany(x => x.Recipes)
                .HasForeignKey(x => x.ProductRef);

            modelBuilder.Entity<mdlUser>()
                .HasRequired(x => x.Branch)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.BranchRef);
            modelBuilder.Entity<mdlUser>()
                .HasRequired(x => x.Role)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.RoleRef);

            modelBuilder.Entity<mdlCashShift>()
                .HasRequired(x => x.Branch)
                .WithMany(x => x.CashShifts)
                .HasForeignKey(x => x.BranchRef);
            modelBuilder.Entity<mdlCashShift>()
                .HasRequired(x => x.User)
                .WithMany(x => x.CashShifts)
                .HasForeignKey(x => x.UserRef);

            modelBuilder.Entity<mdlOrderItem>()
                .HasRequired(x => x.Product)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.ProductRef);
            modelBuilder.Entity<mdlOrderItem>()
                .HasRequired(x => x.ProductVariant)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.ProductVariantRef);
            modelBuilder.Entity<mdlOrderItem>()
                .HasRequired(x => x.Order)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.OrderRef);
            modelBuilder.Entity<mdlOrderItem>()
                .HasRequired(x => x.OrderItemState)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.OrderItemStateRef);

            modelBuilder.Entity<mdlOrder>()
                .HasRequired(x => x.Branch)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.BranchRef);
            modelBuilder.Entity<mdlOrder>()
                .HasRequired(x => x.Table)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.TableRef);
            modelBuilder.Entity<mdlOrder>()
                .HasRequired(x => x.User)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.UserRef);

            modelBuilder.Entity<mdlTable>()
                .HasRequired(x => x.Zone)
                .WithMany(x => x.Tables)
                .HasForeignKey(x => x.ZoneRef);
            modelBuilder.Entity<mdlTable>()
                .HasRequired(x => x.TableState)
                .WithMany(x => x.Tables)
                .HasForeignKey(x => x.TableStateRef);

            modelBuilder.Entity<mdlReservation>()
                .HasRequired(x => x.Table)
                .WithMany(x => x.Reservations)
                .HasForeignKey(x => x.TableRef);
            modelBuilder.Entity<mdlReservation>()
                .HasRequired(x => x.Customer)
                .WithMany(x => x.Reservations)
                .HasForeignKey(x => x.CustomerRef);
            modelBuilder.Entity<mdlReservation>()
                .HasRequired(x => x.ReservationState)
                .WithMany(x => x.Reservations)
                .HasForeignKey(x => x.ReservationStateRef);

            modelBuilder.Entity<mdlProductPurchaseOrderItem>()
                .HasRequired(x => x.Product)
                .WithMany(x => x.ProductPurchaseOrderItems)
                .HasForeignKey(x => x.ProductRef);
            modelBuilder.Entity<mdlProductPurchaseOrderItem>()
                .HasRequired(x => x.PurchaseOrder)
                .WithMany(x => x.ProductPurchaseOrderItems)
                .HasForeignKey(x => x.PurchaseOrderRef);

            modelBuilder.Entity<mdlIngredientPurchaseOrderItem>()
                .HasRequired(x => x.Ingredient)
                .WithMany(x => x.IngredientPurchaseOrderItems)
                .HasForeignKey(x => x.IngredientRef);
            modelBuilder.Entity<mdlIngredientPurchaseOrderItem>()
                .HasRequired(x => x.PurchaseOrder)
                .WithMany(x => x.IngredientPurchaseOrderItems)
                .HasForeignKey(x => x.PurchaseOrderRef);

            modelBuilder.Entity<mdlPayment>()
                .HasRequired(x => x.Order)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.OrderRef);
            modelBuilder.Entity<mdlPayment>()
                .HasOptional(x => x.CashShift)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.CashShiftRef);
            modelBuilder.Entity<mdlPayment>()
                .HasRequired(x => x.PaymentType)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.PaymentTypeRef);

            modelBuilder.Entity<mdlPurchaseOrder>()
                .HasRequired(x => x.Supplier)
                .WithMany(x => x.PurchaseOrders)
                .HasForeignKey(x => x.SupplierRef);
            modelBuilder.Entity<mdlPurchaseOrder>()
                .HasRequired(x => x.PurchaseOrderState)
                .WithMany(x => x.PurchaseOrders)
                .HasForeignKey(x => x.PurchaseOrderStateRef);

            modelBuilder.Entity<mdlZone>()
                .HasRequired(x => x.Branch)
                .WithMany(x => x.Zones)
                .HasForeignKey(x => x.BranchRef);

            modelBuilder.Entity<mdlPrinter>()
                .HasRequired(x => x.Branch)
                .WithMany(x => x.Printers)
                .HasForeignKey(x => x.BranchRef);
            modelBuilder.Entity<mdlPrinter>()
                .HasRequired(x => x.PrintDestination)
                .WithMany(x => x.Printers)
                .HasForeignKey(x => x.PrintDestinationRef);
            modelBuilder.Entity<mdlPrinter>()
                .HasRequired(x => x.PrintState)
                .WithMany(x => x.Printers)
                .HasForeignKey(x => x.PrintStateRef);
            modelBuilder.Entity<mdlPrinter>()
                .HasRequired(x => x.PrinterConnectionType)
                .WithMany(x => x.Printers)
                .HasForeignKey(x => x.PrinterConnectionTypeRef);

            modelBuilder.Entity<mdlSave>()
                .HasRequired(x => x.Firm)
                .WithMany(x => x.Saves)
                .HasForeignKey(x => x.FirmRef);
            modelBuilder.Entity<mdlSave>()
                .HasRequired(x => x.Branch)
                .WithMany(x => x.Saves)
                .HasForeignKey(x => x.BranchRef);
            modelBuilder.Entity<mdlSave>()
                .HasRequired(x => x.User)
                .WithMany(x => x.Saves)
                .HasForeignKey(x => x.UserRef);
            modelBuilder.Entity<mdlSave>()
                .HasRequired(x => x.SaveType)
                .WithMany(x => x.Saves)
                .HasForeignKey(x => x.SaveTypeRef);
            #endregion
        }
    }
}