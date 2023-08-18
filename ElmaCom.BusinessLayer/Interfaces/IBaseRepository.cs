namespace ElmaCom.BusinessLayer.Interfaces
{
    public interface IBaseRepository<T> where T: class
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);

        T GetById(int id);

        IEnumerable<T> GetAll(bool isTracking);

        int SaveChanges();
    }
}
