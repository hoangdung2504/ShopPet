using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopThuCung_2021.Api
{
    public class _Api
    {
        public HttpClient Initial(string api_url)
        {
            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            var client = new HttpClient(handler);

            //client.BaseAddress = new Uri("https://localhost:44373/");
            if (api_url.ToUpper() == "SYS_API")
            {
                client.BaseAddress = new Uri(Startup.api_url);
            }

            return client;
        }
    }
}
