namespace Application.Interfaces
{
    public interface IQueryService<Response, ID> where Response : class
    {
        Task<Response> GetById(ID id);
    }
}
