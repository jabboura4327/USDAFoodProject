using System;
using System.Net;

namespace USDAFoodProject
{
    internal static class WebRequestExtensions
    {
        /// <summary>
        /// Creates a web request using the API method
        /// </summary>
        /// <param name="foodId">Specifies the food id#</param>
        /// <returns></returns>
        public static WebRequest Request(string foodId)
        {
            var apiUri = new Uri(AppSettingsHelper.ApiUrl + "?ndbno=" + foodId + "&api_key=" + AppSettingsHelper.AccessKey);

            return WebRequest.Create(apiUri).GetHeaders();
        }

        public static WebRequest GetHeaders(this WebRequest req)
        {
            req.Headers["ContentType"] = "application/json";
            return req;
        }
    }
}