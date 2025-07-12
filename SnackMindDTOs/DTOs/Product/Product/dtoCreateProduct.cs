using System;

namespace SnackMindDTOs.DTOs.Product.Product
{
    public class dtoCreateProduct
    {
        public string Name { get; set; }
        public string StockCode { get; set; }
        public string ImagePath { get; set; }
        public string Barcode { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal CostPrice { get; set; }
        public decimal TaxRate { get; set; }
        public bool IsComposite { get; set; }

        public Guid CategoryRef { get; set; }
        public Guid UnitRef { get; set; }

        public string Description { get; set; }
    }
}