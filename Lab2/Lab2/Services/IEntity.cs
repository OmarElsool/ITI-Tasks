namespace Lab2.Services
{
    public interface IEntity<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void Delete(int id);

    }
}
