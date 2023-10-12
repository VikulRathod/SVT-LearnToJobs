namespace Site.Web.API.Client.Config
{
    public class AppConfig
    {
        static IConfiguration _config;
        public AppConfig(IConfiguration config)
        {
            _config = config;
        }

        public static string WebApiEndPointAddress
        {
            get
            {
                return _config["ApiBaseAddress"];
            }
        }
    }

    public abstract class GlobalConstants
    {
        public static string JsonHttpHeader = "application/json";
    }
}
