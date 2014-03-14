using CheckIt.Data.Infras.Logging.NLog;
using System.Data.Entity;

namespace CheckIt.Domain
{
    public class CheckItDbConfiguration : DbConfiguration
    {
        public CheckItDbConfiguration()
        {
            this.AddInterceptor(NLogLogger.Instance);
        }
    }
}
