namespace Deol.Lims.Abstract
{
    public interface IListener
    {
        //void Start();
        //void Stop();

        Task StartAsync(CancellationToken cancellationToken);
        Task StopAsync(CancellationToken cancellationToken);
    }
}
