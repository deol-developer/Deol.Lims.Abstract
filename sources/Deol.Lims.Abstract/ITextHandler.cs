namespace Deol.Lims.Abstract
{
    public interface ITextHandler
    {
        string? Handle(string message);

        Task<string?> HandleAsync(string message, CancellationToken cancelationToken);
    }
}
