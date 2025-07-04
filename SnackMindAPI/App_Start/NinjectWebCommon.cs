[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SnackMindAPI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(SnackMindAPI.App_Start.NinjectWebCommon), "Stop")]

namespace SnackMindAPI.App_Start
{

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    using SnackMindCore.RepositoryBase;

    using SnackMindData.Repository;
    using SnackMindData.UnitOfWork;

    using SnackMindService.Service.ServiceBase.Lookup;
    using SnackMindService.Service.ServiceBase.Order.Order;
    using SnackMindService.Service.ServiceBase.Payment.Payment;
    using SnackMindService.Service.ServiceBase.Place.Branch;
    using SnackMindService.Service.ServiceBase.Place.Firm;
    using SnackMindService.Service.ServiceBase.Place.Warehouse;
    using SnackMindService.Service.ServiceBase.Place.Zone;
    using SnackMindService.Service.ServiceBase.Product.Category;
    using SnackMindService.Service.ServiceBase.Product.Product;
    using SnackMindService.Service.ServiceBase.Product.Recipe.Ingredient;
    using SnackMindService.Service.ServiceBase.Product.Recipe.Recipe;
    using SnackMindService.Service.ServiceBase.Product.Stock;
    using SnackMindService.Service.ServiceBase.Product.Unit;
    using SnackMindService.Service.ServiceBase.Product.Variant;
    using SnackMindService.Service.ServiceBase.Reservation.Customer;
    using SnackMindService.Service.ServiceBase.Reservation.Reservation;
    using SnackMindService.Service.ServiceBase.Setting.Log;
    using SnackMindService.Service.ServiceBase.Setting.Printer;
    using SnackMindService.Service.ServiceBase.Table.Table;
    using SnackMindService.Service.ServiceBase.User.CashShift;
    using SnackMindService.Service.ServiceBase.User.Role;
    using SnackMindService.Service.ServiceBase.User.User;
    using SnackMindService.Service.ServiceBaseClass.Lookup;
    using SnackMindService.Service.ServiceBaseClass.Order.Order;
    using SnackMindService.Service.ServiceBaseClass.Payment.Payment;
    using SnackMindService.Service.ServiceBaseClass.Place.Branch;
    using SnackMindService.Service.ServiceBaseClass.Place.Firm;
    using SnackMindService.Service.ServiceBaseClass.Place.Warehouse;
    using SnackMindService.Service.ServiceBaseClass.Place.Zone;
    using SnackMindService.Service.ServiceBaseClass.Product.Category;
    using SnackMindService.Service.ServiceBaseClass.Product.Product;
    using SnackMindService.Service.ServiceBaseClass.Product.Recipe.Ingredient;
    using SnackMindService.Service.ServiceBaseClass.Product.Recipe.Recipe;
    using SnackMindService.Service.ServiceBaseClass.Product.Stock;
    using SnackMindService.Service.ServiceBaseClass.Product.Unit;
    using SnackMindService.Service.ServiceBaseClass.Product.Variant;
    using SnackMindService.Service.ServiceBaseClass.Reservation.Customer;
    using SnackMindService.Service.ServiceBaseClass.Reservation.Reservation;
    using SnackMindService.Service.ServiceBaseClass.Setting.Log;
    using SnackMindService.Service.ServiceBaseClass.Setting.Printer;
    using SnackMindService.Service.ServiceBaseClass.Table.Table;
    using SnackMindService.Service.ServiceBaseClass.User.CashShift;
    using SnackMindService.Service.ServiceBaseClass.User.Role;
    using SnackMindService.Service.ServiceBaseClass.User.User;

    using System;
    using System.Diagnostics;
    using System.Web;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
            Debug.WriteLine("ninject start");
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind(typeof(ISmRepository<>)).To(typeof(SmRepository<>));
            // Place
            kernel.Bind<IFirmService>().To<mngFirm>();
            kernel.Bind<IBranchService>().To<mngBranch>();
            kernel.Bind<IWarehouseService>().To<mngWarehouse>();
            kernel.Bind<IZoneService>().To<mngZone>();

            // Product
            kernel.Bind<IProductService>().To<mngProduct>();
            kernel.Bind<IProductCategoryService>().To<mngProductCategory>();
            kernel.Bind<IParentCategoryService>().To<mngParentCategory>();
            kernel.Bind<IUnitService>().To<mngUnit>();
            kernel.Bind<IProductVariantService>().To<mngProductVariant>();

            // Recipe & Ingredient
            kernel.Bind<IRecipeService>().To<mngRecipe>();
            kernel.Bind<IRecipeItemService>().To<mngRecipeItem>();
            kernel.Bind<IIngredientService>().To<mngIngredient>();

            // Stock
            kernel.Bind<IProductStockService>().To<mngProductStock>();
            kernel.Bind<IIngredientStockService>().To<mngIngredientStock>();
            kernel.Bind<IProductStockMovementService>().To<mngProductStockMovement>();
            kernel.Bind<IIngredientStockMovementService>().To<mngIngredientStockMovement>();
            kernel.Bind<IStockMovementTypeService>().To<mngStockMovementType>();

            // Payment
            kernel.Bind<IPaymentService>().To<mngPayment>();
            kernel.Bind<IPaymentTypeService>().To<mngPaymentType>();

            // Table
            kernel.Bind<ITableService>().To<mngTable>();
            kernel.Bind<ITableStateService>().To<mngTableState>();

            // Reservation
            kernel.Bind<IReservationService>().To<mngReservation>();
            kernel.Bind<ICustomerService>().To<mngCustomer>();
            kernel.Bind<IReservationStateService>().To<mngReservationState>();

            // Log & Setting
            kernel.Bind<ILogService>().To<mngLog>();
            kernel.Bind<ILogTypeService>().To<mngLogType>();
            kernel.Bind<IPrinterService>().To<mngPrinter>();
            kernel.Bind<IPrintDestinationService>().To<mngPrintDestination>();
            kernel.Bind<IPrintStateService>().To<mngPrintState>();
            kernel.Bind<IPrinterConnectionTypeService>().To<mngPrinterConnectionType>();

            // User & Role
            kernel.Bind<IUserService>().To<mngUser>();
            kernel.Bind<IRoleService>().To<mngRole>();
            kernel.Bind<ICashShiftService>().To<mngCashShift>();

            // Order
            kernel.Bind<IOrderService>().To<mngOrder>();
            kernel.Bind<IOrderItemService>().To<mngOrderItem>();
            kernel.Bind<IOrderItemStateService>().To<mngOrderItemState>();
        }
    }
}