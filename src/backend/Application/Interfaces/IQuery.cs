namespace Application.Interfaces
{
    public interface IQuery<T, ID> where T : class
    {
        Task<T> RecoveryById(ID id);
    }
}
