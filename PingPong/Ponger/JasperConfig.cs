using Jasper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Ponger
{
    // SAMPLE: PongerJasperConfig
    internal class JasperConfig : JasperOptions
    {
        public JasperConfig()
        {
            // Listen for incoming messages using the
            // lightweight TCP transport at port
            // 2222
            Endpoints.ListenAtPort(2222);
        }
    }
    // ENDSAMPLE

}
