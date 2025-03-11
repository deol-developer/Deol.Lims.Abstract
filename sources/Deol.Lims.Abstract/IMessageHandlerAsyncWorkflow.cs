namespace Deol.Lims.Abstract
{
    public interface IMessageHandlerAsyncWorkflow : IMessageHandler
    {
        Task StartBackgroundHandlingAsync(CancellationToken cancellationToken);
        int OutputMessageCount { get; }
        IEnumerable<string[]>? GetNextOutputMessage();
        void AddOutputMessage(IEnumerable<string[]> message);
    }
}
