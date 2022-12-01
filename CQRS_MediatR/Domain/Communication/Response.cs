namespace CQRS_MediatR.Domain.Communication
{
    public class Response<T>
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }
        public T Data { get; protected set; }

        public Response(bool success, string message, T data)
        {
            this.Success = success;
            this.Message = message ?? string.Empty;
            this.Data = data;
        }

        public Response(string message)
            : this(false, message, default(T))
        {
        }

        public Response(T data)
            : this(true, string.Empty, data)
        {
        }
    }
}
