using Project4.Entities;

namespace Project4.DataAccess
{
    // Aşağıda -- Referance type anlamına gelir. Ayrıca interface'ler(referans olmalarına rağmen) new'lenemediğinden de aşağıya new yazıyoruz
    public interface IEntitiyRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
