using AutoMapper;

using SnackMindDTOs.DTOs.Order.Order;
using SnackMindDTOs.DTOs.Order.OrderItem;
using SnackMindDTOs.DTOs.Order.OrderItemState;
using SnackMindDTOs.DTOs.Payment.Payment.Payment;
using SnackMindDTOs.DTOs.Payment.Payment.PaymentType;
using SnackMindDTOs.DTOs.Place.Branch;
using SnackMindDTOs.DTOs.Place.Firm;
using SnackMindDTOs.DTOs.Place.Warehouse;
using SnackMindDTOs.DTOs.Place.Zone;
using SnackMindDTOs.DTOs.Product.Category.ParentCategory;
using SnackMindDTOs.DTOs.Product.Category.ProductCategory;
using SnackMindDTOs.DTOs.Product.Ingredient;
using SnackMindDTOs.DTOs.Product.Product;
using SnackMindDTOs.DTOs.Product.Recipe.Recipe;
using SnackMindDTOs.DTOs.Product.Recipe.RecipeItem;
using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock;
using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStock;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;
using SnackMindDTOs.DTOs.Product.Stock.StockMovementType;
using SnackMindDTOs.DTOs.Product.Unit;
using SnackMindDTOs.DTOs.Product.Variant;
using SnackMindDTOs.DTOs.Purchase.Purchase.Ingredient;
using SnackMindDTOs.DTOs.Purchase.Purchase.Product;
using SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrder;
using SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrderState;
using SnackMindDTOs.DTOs.Purchase.Supplier;
using SnackMindDTOs.DTOs.Reservation.Customer;
using SnackMindDTOs.DTOs.Reservation.Reservation.Reservation;
using SnackMindDTOs.DTOs.Reservation.Reservation.ReservationState;
using SnackMindDTOs.DTOs.Setting.Printer.PrintDestination;
using SnackMindDTOs.DTOs.Setting.Printer.Printer;
using SnackMindDTOs.DTOs.Setting.Printer.PrinterConnectionType;
using SnackMindDTOs.DTOs.Setting.Printer.PrintState;
using SnackMindDTOs.DTOs.Setting.Save.Save;
using SnackMindDTOs.DTOs.Setting.Save.SaveType;
using SnackMindDTOs.DTOs.Table.Table.Table;
using SnackMindDTOs.DTOs.Table.Table.TableState;
using SnackMindDTOs.DTOs.User.CashShift;
using SnackMindDTOs.DTOs.User.Role;
using SnackMindDTOs.DTOs.User.User;

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

namespace SnackMindService.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Branch
            CreateMap<mdlBranch, dtoBranch>().ReverseMap();
            CreateMap<mdlBranch, dtoListBranch>().ReverseMap();
            CreateMap<mdlBranch, dtoDetailBranch>().ReverseMap();
            CreateMap<dtoCreateBranch, mdlBranch>();
            CreateMap<dtoUpdateBranch, mdlBranch>();

            // Firm
            CreateMap<mdlFirm, dtoFirm>().ReverseMap();
            CreateMap<mdlFirm, dtoListFirm>().ReverseMap();
            CreateMap<mdlFirm, dtoDetailFirm>().ReverseMap();
            CreateMap<dtoCreateFirm, mdlFirm>();
            CreateMap<dtoUpdateFirm, mdlFirm>();

            // Warehouse
            CreateMap<mdlWarehouse, dtoWarehouse>().ReverseMap();
            CreateMap<mdlWarehouse, dtoListWarehouse>().ReverseMap();
            CreateMap<mdlWarehouse, dtoDetailWarehouse>().ReverseMap();
            CreateMap<dtoCreateWarehouse, mdlWarehouse>();
            CreateMap<dtoUpdateWarehouse, mdlWarehouse>();

            // Zone
            CreateMap<mdlZone, dtoZone>().ReverseMap();
            CreateMap<mdlZone, dtoListZone>().ReverseMap();
            CreateMap<mdlZone, dtoDetailZone>().ReverseMap();
            CreateMap<dtoCreateZone, mdlZone>();
            CreateMap<dtoUpdateZone, mdlZone>();

            // ParentCategory
            CreateMap<mdlParentCategory, dtoParentCategory>().ReverseMap();
            CreateMap<mdlParentCategory, dtoListParentCategory>().ReverseMap();
            CreateMap<mdlParentCategory, dtoDetailParentCategory>().ReverseMap();
            CreateMap<dtoCreateParentCategory, mdlParentCategory>();
            CreateMap<dtoUpdateParentCategory, mdlParentCategory>();

            // ProductCategory
            CreateMap<mdlProductCategory, dtoProductCategory>().ReverseMap();
            CreateMap<mdlProductCategory, dtoListProductCategory>().ReverseMap();
            CreateMap<mdlProductCategory, dtoDetailProductCategory>().ReverseMap();
            CreateMap<dtoCreateProductCategory, mdlProductCategory>();
            CreateMap<dtoUpdateProductCategory, mdlProductCategory>();

            // Ingredient
            CreateMap<mdlIngredient, dtoIngredient>().ReverseMap();
            CreateMap<mdlIngredient, dtoListIngredient>().ReverseMap();
            CreateMap<mdlIngredient, dtoDetailIngredient>().ReverseMap();
            CreateMap<dtoCreateIngredient, mdlIngredient>();
            CreateMap<dtoUpdateIngredient, mdlIngredient>();

            // Product
            CreateMap<mdlProduct, dtoProduct>().ReverseMap();
            CreateMap<mdlProduct, dtoListProduct>().ReverseMap();
            CreateMap<mdlProduct, dtoDetailProduct>().ReverseMap();
            CreateMap<dtoCreateProduct, mdlProduct>();
            CreateMap<dtoUpdateProduct, mdlProduct>();

            // Recipe
            CreateMap<mdlRecipe, dtoRecipe>().ReverseMap();
            CreateMap<mdlRecipe, dtoListRecipe>().ReverseMap();
            CreateMap<mdlRecipe, dtoDetailRecipe>().ReverseMap();
            CreateMap<dtoCreateRecipe, mdlRecipe>();
            CreateMap<dtoUpdateRecipe, mdlRecipe>();

            // RecipeItem
            CreateMap<mdlRecipeItem, dtoRecipeItem>().ReverseMap();
            CreateMap<mdlRecipeItem, dtoListRecipeItem>().ReverseMap();
            CreateMap<mdlRecipeItem, dtoDetailRecipeItem>().ReverseMap();
            CreateMap<dtoCreateRecipeItem, mdlRecipeItem>();
            CreateMap<dtoUpdateRecipeItem, mdlRecipeItem>();

            // IngredientStock
            CreateMap<mdlIngredientStock, dtoIngredientStock>().ReverseMap();
            CreateMap<mdlIngredientStock, dtoListIngredientStock>().ReverseMap();
            CreateMap<mdlIngredientStock, dtoDetailIngredientStock>().ReverseMap();
            CreateMap<dtoCreateIngredientStock, mdlIngredientStock>();
            CreateMap<dtoUpdateIngredientStock, mdlIngredientStock>();

            // IngredientStockMovement
            CreateMap<mdlIngredientStockMovement, dtoIngredientStockMovement>().ReverseMap();
            CreateMap<mdlIngredientStockMovement, dtoListIngredientStockMovement>().ReverseMap();
            CreateMap<mdlIngredientStockMovement, dtoDetailIngredientStockMovement>().ReverseMap();
            CreateMap<dtoCreateIngredientStockMovement, mdlIngredientStockMovement>();
            CreateMap<dtoUpdateIngredientStockMovement, mdlIngredientStockMovement>();

            // ProductStock
            CreateMap<mdlProductStock, dtoProductStock>().ReverseMap();
            CreateMap<mdlProductStock, dtoListProductStock>().ReverseMap();
            CreateMap<mdlProductStock, dtoDetailProductStock>().ReverseMap();
            CreateMap<dtoCreateProductStock, mdlProductStock>();
            CreateMap<dtoUpdateProductStock, mdlProductStock>();

            // ProductStockMovement
            CreateMap<mdlProductStockMovement, dtoProductStockMovement>().ReverseMap();
            CreateMap<mdlProductStockMovement, dtoListProductStockMovement>().ReverseMap();
            CreateMap<mdlProductStockMovement, dtoDetailProductStockMovement>().ReverseMap();
            CreateMap<dtoCreateProductStockMovement, mdlProductStockMovement>();
            CreateMap<dtoUpdateProductStockMovement, mdlProductStockMovement>();

            // StockMovementType
            CreateMap<mdlStockMovementType, dtoStockMovementType>().ReverseMap();
            CreateMap<mdlStockMovementType, dtoListStockMovementType>().ReverseMap();
            CreateMap<mdlStockMovementType, dtoDetailStockMovementType>().ReverseMap();
            CreateMap<dtoCreateStockMovementType, mdlStockMovementType>();
            CreateMap<dtoUpdateStockMovementType, mdlStockMovementType>();

            // Unit
            CreateMap<mdlUnit, dtoUnit>().ReverseMap();
            CreateMap<mdlUnit, dtoListUnit>().ReverseMap();
            CreateMap<mdlUnit, dtoDetailUnit>().ReverseMap();
            CreateMap<dtoCreateUnit, mdlUnit>();
            CreateMap<dtoUpdateUnit, mdlUnit>();

            // ProductVariant
            CreateMap<mdlProductVariant, dtoProductVariant>().ReverseMap();
            CreateMap<mdlProductVariant, dtoListProductVariant>().ReverseMap();
            CreateMap<mdlProductVariant, dtoDetailProductVariant>().ReverseMap();
            CreateMap<dtoCreateProductVariant, mdlProductVariant>();
            CreateMap<dtoUpdateProductVariant, mdlProductVariant>();

            // IngredientPurchaseOrderItem
            CreateMap<mdlIngredientPurchaseOrderItem, dtoIngredientPurchaseOrderItem>().ReverseMap();
            CreateMap<mdlIngredientPurchaseOrderItem, dtoListIngredientPurchaseOrderItem>().ReverseMap();
            CreateMap<mdlIngredientPurchaseOrderItem, dtoDetailIngredientPurchaseOrderItem>().ReverseMap();
            CreateMap<dtoCreateIngredientPurchaseOrderItem, mdlIngredientPurchaseOrderItem>();
            CreateMap<dtoUpdateIngredientPurchaseOrderItem, mdlIngredientPurchaseOrderItem>();

            // ProductPurchaseOrderItem
            CreateMap<mdlProductPurchaseOrderItem, dtoProductPurchaseOrderItem>().ReverseMap();
            CreateMap<mdlProductPurchaseOrderItem, dtoListProductPurchaseOrderItem>().ReverseMap();
            CreateMap<mdlProductPurchaseOrderItem, dtoDetailProductPurchaseOrderItem>().ReverseMap();
            CreateMap<dtoCreateProductPurchaseOrderItem, mdlProductPurchaseOrderItem>();
            CreateMap<dtoUpdateProductPurchaseOrderItem, mdlProductPurchaseOrderItem>();

            // PurchaseOrder
            CreateMap<mdlPurchaseOrder, dtoPurchaseOrder>().ReverseMap();
            CreateMap<mdlPurchaseOrder, dtoListPurchaseOrder>().ReverseMap();
            CreateMap<mdlPurchaseOrder, dtoDetailPurchaseOrder>().ReverseMap();
            CreateMap<dtoCreatePurchaseOrder, mdlPurchaseOrder>();
            CreateMap<dtoUpdatePurchaseOrder, mdlPurchaseOrder>();

            // PurchaseOrderState
            CreateMap<mdlPurchaseOrderState, dtoPurchaseOrderState>().ReverseMap();
            CreateMap<mdlPurchaseOrderState, dtoListPurchaseOrderState>().ReverseMap();
            CreateMap<mdlPurchaseOrderState, dtoDetailPurchaseOrderState>().ReverseMap();
            CreateMap<dtoCreatePurchaseOrderState, mdlPurchaseOrderState>();
            CreateMap<dtoUpdatePurchaseOrderState, mdlPurchaseOrderState>();

            // Supplier
            CreateMap<mdlSupplier, dtoSupplier>().ReverseMap();
            CreateMap<mdlSupplier, dtoListSupplier>().ReverseMap();
            CreateMap<mdlSupplier, dtoDetailSupplier>().ReverseMap();
            CreateMap<dtoCreateSupplier, mdlSupplier>();
            CreateMap<dtoUpdateSupplier, mdlSupplier>();

            // Customer
            CreateMap<mdlCustomer, dtoCustomer>().ReverseMap();
            CreateMap<mdlCustomer, dtoListCustomer>().ReverseMap();
            CreateMap<mdlCustomer, dtoDetailCustomer>().ReverseMap();
            CreateMap<dtoCreateCustomer, mdlCustomer>();
            CreateMap<dtoUpdateCustomer, mdlCustomer>();

            // Reservation
            CreateMap<mdlReservation, dtoReservation>().ReverseMap();
            CreateMap<mdlReservation, dtoListReservation>().ReverseMap();
            CreateMap<mdlReservation, dtoDetailReservation>().ReverseMap();
            CreateMap<dtoCreateReservation, mdlReservation>();
            CreateMap<dtoUpdateReservation, mdlReservation>();

            // ReservationState
            CreateMap<mdlReservationState, dtoReservationState>().ReverseMap();
            CreateMap<mdlReservationState, dtoListReservationState>().ReverseMap();
            CreateMap<mdlReservationState, dtoDetailReservationState>().ReverseMap();
            CreateMap<dtoCreateReservationState, mdlReservationState>();
            CreateMap<dtoUpdateReservationState, mdlReservationState>();

            // PrintDestination
            CreateMap<mdlPrintDestination, dtoPrintDestination>().ReverseMap();
            CreateMap<mdlPrintDestination, dtoListPrintDestination>().ReverseMap();
            CreateMap<mdlPrintDestination, dtoDetailPrintDestination>().ReverseMap();
            CreateMap<dtoCreatePrintDestination, mdlPrintDestination>();
            CreateMap<dtoUpdatePrintDestination, mdlPrintDestination>();

            // PrinterConnectionType
            CreateMap<mdlPrinterConnectionType, dtoPrinterConnectionType>().ReverseMap();
            CreateMap<mdlPrinterConnectionType, dtoListPrinterConnectionType>().ReverseMap();
            CreateMap<mdlPrinterConnectionType, dtoDetailPrinterConnectionType>().ReverseMap();
            CreateMap<dtoCreatePrinterConnectionType, mdlPrinterConnectionType>();
            CreateMap<dtoUpdatePrinterConnectionType, mdlPrinterConnectionType>();

            // PrintState
            CreateMap<mdlPrintState, dtoPrintState>().ReverseMap();
            CreateMap<mdlPrintState, dtoListPrintState>().ReverseMap();
            CreateMap<mdlPrintState, dtoDetailPrintState>().ReverseMap();
            CreateMap<dtoCreatePrintState, mdlPrintState>();
            CreateMap<dtoUpdatePrintState, mdlPrintState>();

            // Printer
            CreateMap<mdlPrinter, dtoPrinter>().ReverseMap();
            CreateMap<mdlPrinter, dtoListPrinter>().ReverseMap();
            CreateMap<mdlPrinter, dtoDetailPrinter>().ReverseMap();
            CreateMap<dtoCreatePrinter, mdlPrinter>();
            CreateMap<dtoUpdatePrinter, mdlPrinter>();

            // Save
            CreateMap<mdlSave, dtoSave>().ReverseMap();
            CreateMap<mdlSave, dtoListSave>().ReverseMap();
            CreateMap<mdlSave, dtoDetailSave>().ReverseMap();
            CreateMap<dtoCreateSave, mdlSave>();
            CreateMap<dtoUpdateSave, mdlSave>();

            // SaveType
            CreateMap<mdlSaveType, dtoSaveType>().ReverseMap();
            CreateMap<mdlSaveType, dtoListSaveType>().ReverseMap();
            CreateMap<mdlSaveType, dtoDetailSaveType>().ReverseMap();
            CreateMap<dtoCreateSaveType, mdlSaveType>();
            CreateMap<dtoUpdateSaveType, mdlSaveType>();

            // Table
            CreateMap<mdlTable, dtoTable>().ReverseMap();
            CreateMap<mdlTable, dtoListTable>().ReverseMap();
            CreateMap<mdlTable, dtoDetailTable>().ReverseMap();
            CreateMap<dtoCreateTable, mdlTable>();
            CreateMap<dtoUpdateTable, mdlTable>();

            // TableState
            CreateMap<mdlTableState, dtoTableState>().ReverseMap();
            CreateMap<mdlTableState, dtoListTableState>().ReverseMap();
            CreateMap<mdlTableState, dtoDetailTableState>().ReverseMap();
            CreateMap<dtoCreateTableState, mdlTableState>();
            CreateMap<dtoUpdateTableState, mdlTableState>();

            // CashShift
            CreateMap<mdlCashShift, dtoCashShift>().ReverseMap();
            CreateMap<mdlCashShift, dtoListCashShift>().ReverseMap();
            CreateMap<mdlCashShift, dtoDetailCashShift>().ReverseMap();
            CreateMap<dtoCreateCashShift, mdlCashShift>();
            CreateMap<dtoUpdateCashShift, mdlCashShift>();

            // Role
            CreateMap<mdlRole, dtoRole>().ReverseMap();
            CreateMap<mdlRole, dtoListRole>().ReverseMap();
            CreateMap<mdlRole, dtoDetailRole>().ReverseMap();
            CreateMap<dtoCreateRole, mdlRole>();
            CreateMap<dtoUpdateRole, mdlRole>();

            // User
            CreateMap<mdlUser, dtoUser>().ReverseMap();
            CreateMap<mdlUser, dtoListUser>().ReverseMap();
            CreateMap<mdlUser, dtoDetailUser>().ReverseMap();
            CreateMap<dtoCreateUser, mdlUser>();
            CreateMap<dtoUpdateUser, mdlUser>();

            // Payment
            CreateMap<mdlPayment, dtoPayment>().ReverseMap();
            CreateMap<mdlPayment, dtoListPayment>().ReverseMap();
            CreateMap<mdlPayment, dtoDetailPayment>().ReverseMap();
            CreateMap<dtoCreatePayment, mdlPayment>();
            CreateMap<dtoUpdatePayment, mdlPayment>();

            // PaymentType
            CreateMap<mdlPaymentType, dtoPaymentType>().ReverseMap();
            CreateMap<mdlPaymentType, dtoListPaymentType>().ReverseMap();
            CreateMap<mdlPaymentType, dtoDetailPaymentType>().ReverseMap();
            CreateMap<dtoCreatePaymentType, mdlPaymentType>();
            CreateMap<dtoUpdatePaymentType, mdlPaymentType>();

            // Order
            CreateMap<mdlOrder, dtoOrder>().ReverseMap();
            CreateMap<mdlOrder, dtoListOrder>().ReverseMap();
            CreateMap<mdlOrder, dtoDetailOrder>().ReverseMap();
            CreateMap<dtoCreateOrder, mdlOrder>();
            CreateMap<dtoUpdateOrder, mdlOrder>();

            // OrderItem
            CreateMap<mdlOrderItem, dtoOrderItem>().ReverseMap();
            CreateMap<mdlOrderItem, dtoListOrderItem>().ReverseMap();
            CreateMap<mdlOrderItem, dtoDetailOrderItem>().ReverseMap();
            CreateMap<dtoCreateOrderItem, mdlOrderItem>();
            CreateMap<dtoUpdateOrderItem, mdlOrderItem>();

            // OrderItemState
            CreateMap<mdlOrderItemState, dtoOrderItemState>().ReverseMap();
            CreateMap<mdlOrderItemState, dtoListOrderItemState>().ReverseMap();
            CreateMap<mdlOrderItemState, dtoDetailOrderItemState>().ReverseMap();
            CreateMap<dtoCreateOrderItemState, mdlOrderItemState>();
            CreateMap<dtoUpdateOrderItemState, mdlOrderItemState>();
        }
    }
}