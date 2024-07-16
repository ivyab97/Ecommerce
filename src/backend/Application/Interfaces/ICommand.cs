namespace Application.Interfaces
{
    public interface ICommand<T, ID> where T : class
    {
        Task<T> Insert(T entity);
    }
}
