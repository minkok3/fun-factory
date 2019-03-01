using WebApp.Domain;

namespace WebApp.Extensions
{
    public static class ComponentExtensions
    {
        public static void AdjustStockQuantities(this Component product, int qty)
        {
            product.StockQty = product.StockQty - qty;
        }
    }
}