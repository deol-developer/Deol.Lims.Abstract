namespace Deol.Lims.Abstract
{
    public interface IMessageHandler
    {
        IEnumerable<string[]>? Handle(IEnumerable<string[]> message);

        Task<IEnumerable<string[]>?> HandleAsync(IEnumerable<string[]> message, CancellationToken concelationToken);
    }
}
