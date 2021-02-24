using System.Net.Http;

namespace LerningWithWarzone.source.utils
{
    public class ProgramHttpClient
    {
        private ProgramHttpClient()
        {
        }

        private static ProgramHttpClient _programHttpClient;

        private static readonly object _lock = new object();

        public HttpClient client { get; } = new HttpClient();

        public static ProgramHttpClient GetInstance
        {
            get
            {
                if (_programHttpClient == null)
                {
                    lock (_lock)
                    {
                        if (_programHttpClient == null)
                        {
                            _programHttpClient = new ProgramHttpClient();
                        }
                    }
                }
                return _programHttpClient;
            }
        }
    }
}