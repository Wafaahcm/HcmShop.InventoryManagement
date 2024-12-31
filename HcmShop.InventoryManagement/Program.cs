
using HcmShop.InventoryManagement.Domain.General;
using HcmShop.InventoryManagement.Domain.ProductManagement;

Product.ChangeStockTreshold(10);
Product.StockTreshold = 10;

//Price samplePrice = new Price(10, Currency.Euro);
Price samplePrice = new() { ItemPrice = 10, Currency = Currency.Euro };

//Product p1 = new Product(1, "Sugar", "Lorem ipsum", samplePrice, UnitType.perKg, 100);
Product p1 = new Product(1) { Name = "Sugar", Description = "Lorem ipsum", Price = samplePrice, UnitType = UnitType.perKg };
p1.IncreaseStock(15);
p1.Description = "Description";

//var p2 = new Product(2, "Cake decorations", "Lorem ipsum", samplePrice, UnitType.perItem, 20);
var p2 = new Product(2, "Cake decorations", "Lorem ipsum", new Price() { ItemPrice = 8, Currency = Currency.Euro }, UnitType.perItem, 20);
p2.Description = "Another Description";
//Product p3 = new(3, "Straweberry","Lorem ipsum", samplePrice, UnitType.perBox, 30);
Product p3 = new(3, "Strawberry", "Lorem ipsum", new Price() { ItemPrice = 3, Currency = Currency.Euro }, UnitType.perBox, 10);