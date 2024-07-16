namespace Application.Interfaces
{
    public interface ICommandService<Request, Response, ID> where Request : class where Response : class
    { 
        Task<Response> Create(Request request);
    }
}
