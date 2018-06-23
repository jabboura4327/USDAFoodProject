using System;

namespace USDAFoodProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // pass in foodId# https://ndb.nal.usda.gov/ndb/search/list
            FoodService food = new FoodService("01009");
            food.GetFoodReportData();
            Console.ReadLine();
        }
    }
}