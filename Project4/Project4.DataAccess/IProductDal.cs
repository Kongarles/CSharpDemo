using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public interface IProductDal : IEntitiyRepository<Product>, IAsyncEntityRepository<Product>
    { //Product yazılan yere string int vb yazılmasın sadece referans tipleri yazılsın diye şunu yapıyoruz: IEntityRepository tıklayıp f12 yap

    }
}
