using Project4.Business;
using Project4.DataAccess;
using Project4.Entities;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetAllASync().Result)
{
    Console.WriteLine(product.ProductId);
}

//productManager.Delete(new Product {ProductId=78, ProductName = "Masa 2", CategoryId=2, QuantityPerUnit = "6 ayaklı masa", UnitPrice = 1200, UnitsInStock = 4 });

//Console.WriteLine(productManager.GetById(28).ProductName);


//foreach (var product in productManager.GetAll())
//{
//    Console.WriteLine(product.ProductName);
//}

//try
//{
//    productManager.Add(new Product { ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "4 ayaklı masa", UnitPrice = 1000, UnitsInStock = 10 });
//}
//catch (DuplicateProductException exception)
//{
//    Console.WriteLine(exception.Message);
//}

//PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
//foreach (var personel in personelManager.GetAll())
//{
//    Console.WriteLine("{0} / {1} / {2}", personel.Id, personel.Name, personel.SurName);
//}