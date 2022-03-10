namespace FluentBuilder.Interfaces
{
    public interface IRepository<T>
    {
        public T GetById(int id);

        public T GetByName(string name);
    }
}