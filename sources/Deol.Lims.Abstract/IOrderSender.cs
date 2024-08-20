namespace Deol.Lims.Abstract
{
    public interface IOrderSender
    {
        Task SendOrderAsync(SampleOrder order, CancellationToken cancellationToken);

        Task SendOrderAsync(IEnumerable<SampleOrder> orders, CancellationToken cancellationToken);
    }

    public class SampleOrder
    {
        public string SampleNr { get; }

        public List<string> Orders { get; }

        public SampleOrder(string sampleNr)
        {
            SampleNr = sampleNr;
            Orders = [];
        }

        public SampleOrder(string sampleNr, IEnumerable<string> orders)
        {
            SampleNr = sampleNr;
            Orders = [];
            Orders.AddRange(orders);
        }
    }
}
