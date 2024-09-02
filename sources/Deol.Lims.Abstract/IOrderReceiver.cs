namespace Deol.Lims.Abstract
{
    public interface IOrderReceiver
    {
        Task<string[]> ReceiveOrderAsync(string sampleNr, string equipmentCode, CancellationToken cancellationToken);

        string[] ReceiveOrder(string sampleNr, string equipmentCode);
    }
}
