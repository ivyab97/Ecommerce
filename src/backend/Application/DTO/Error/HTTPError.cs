using System.Net;

namespace Application.DTO.Error
{
    public class HTTPError : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public HTTPError(HttpStatusCode statusCode, string message) : base (message)
        {
            StatusCode = statusCode;
        }
    }
}
