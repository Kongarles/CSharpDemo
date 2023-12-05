using Project4.DataAccess;
using Project4.Entities;

namespace Project4.Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName == "Laptop")
            {
                throw new DuplicateProductException("Laptop Ekleyemezsiniz");
            }
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {

            //iş kodları buraya yazılır

            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public Task<List<Product>> GetAllASync()
        {
            return _productDal.GetAllASync();
        }
    }
}
