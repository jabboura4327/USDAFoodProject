using Newtonsoft.Json;
using System;
using System.IO;

namespace USDAFoodProject
{
    internal class FoodService
    {
        public string foodId;

        public FoodService(string foodId)
        {
            this.foodId = foodId;
        }

        /// <summary>
        /// Gets food report data based off food id#
        /// </summary>
        public void GetFoodReportData()
        {
            using (var response = WebRequestExtensions.Request(foodId).GetResponse())
            {
                var responseData = response.GetResponseStream();
                if (responseData == null) return;

                using (StreamReader read = new StreamReader(responseData))
                {
                    var json = JsonConvert.DeserializeObject(read.ReadToEnd());
                    Console.WriteLine(json);
                }
            }
        }
    }
}