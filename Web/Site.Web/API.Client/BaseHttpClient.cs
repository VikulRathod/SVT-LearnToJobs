using System.Net.Http.Headers;

namespace Site.Web.API.Client
{
    public abstract class BaseHttpClient
    {
        protected HttpClient ServiceClient;
        protected IConfiguration _config;

        protected BaseHttpClient(IConfiguration config)
        {
            _config = config;
            ServiceClient = Create(_config["ApiBaseAddress"]);
        }

        protected BaseHttpClient(string apiAddress)
        {
            ServiceClient = Create(apiAddress);
        }

        public static HttpClient Create(string apiAddress)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri(apiAddress);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
