using System.Configuration;

namespace USDAFoodProject
{
    internal class AppSettingsHelper
    {
        public static string AccessKey
        {
            get
            {
                return ConfigurationManager.AppSettings["accessKey"];
            }
        }

        public static string ApiUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["apiUrl"];
            }
        }
    }
}