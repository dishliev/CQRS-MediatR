namespace CQRS_MediatR
{
    public class ErrorResource
    {
        public bool Success => false;
        public List<string> Messages { get; private set; }

        public ErrorResource(List<string> messages)
        {
            this.Messages = messages ?? new List<string>();
        }
    }
}
