namespace ThirdGroup_1.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);

        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);

   
    }
}
