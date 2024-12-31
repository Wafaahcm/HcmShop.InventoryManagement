using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HcmShop.InventoryManagement.Domain.ProductManagement
{
    public partial class Product
    {
        public static int StockTreshold = 5;

        public static void ChangeStockTreshold(int newStockTreshold)
        {
            if(newStockTreshold > 0)  StockTreshold = newStockTreshold;
        }
        private void UpdateLowStock()
        {
            if (AmountInStock < StockTreshold)
            {
                IsBelowStockThreshold = true;
            }
        }

        private void Log(string message)
        {

            Console.WriteLine(message);
        }

        private string CreateSimpleProductRepresentation()
        {
            return $"Product {Id} ({Name})";
        }
    }
}
