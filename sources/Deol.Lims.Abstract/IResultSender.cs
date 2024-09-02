namespace Deol.Lims.Abstract
{
    public interface IResultSender
    {
        Task SendResultAsync(string sampleNr, string testCode, string testValue, string equipmentCode, CancellationToken cancellationToken);
        Task SendResultAsync(SampleResult result, string equipmentCode, CancellationToken cancellationToken);
        Task SendResultAsync(IEnumerable<SampleResult> results, string equipmentCode, CancellationToken cancellationToken);

        void SendResult(string sampleNr, string testCode, string testValue, string equipmentCode);
        void SendResult(SampleResult result, string equipmentCode);
        void SendResult(IEnumerable<SampleResult> results, string equipmentCode);
    }

    public readonly struct TestResult(string code, string value)
    {
        private readonly string _code = code;
        private readonly string _value = value;

        public string Code => _code;
        public string Value => _value;

        public override string ToString()
        {
            return $"{Code} = {Value}";
        }

        public void Deconstruct(out string code, out string value)
        {
            code = Code;
            value = Value;
        }
    }

    public class SampleResult
    {
        public string SampleNr { get; }

        public List<TestResult> Results { get; }

        public SampleResult(string sampleNr)
        {
            SampleNr = sampleNr;
            Results = [];
        }

        public SampleResult(string sampleNr, IEnumerable<TestResult> results)
        {
            SampleNr = sampleNr;
            Results = [];
            Results.AddRange(results);
        }
    }
}
