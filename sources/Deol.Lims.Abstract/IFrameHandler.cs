namespace Deol.Lims.Abstract
{
    public interface IFrameHandler
    {
        byte[]? Handle(byte[] frame);
        Task<byte[]?> HandleAsync (byte[] frame, CancellationToken cancellationToken);
    }
}
