using System.Net;

namespace ArkoMebel.Domain.Exceptions
{
    public class GlobalExceptions
    {
        public HttpStatusCode StatusCode { get; } = HttpStatusCode.NotFound;
        public string TitleMessage { get; set; } = default!;
    }
}
