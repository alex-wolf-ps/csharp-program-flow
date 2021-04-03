using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Q1Results.CoffeeScore < Q1Results.FoodScore)
            {
                tasks.Add("Revisit recipes for quality and taste.");
            }

            double rewardsMemberPercentage = Q1Results.NumberRewardsMembers / Q1Results.NumberResponded;

            if (rewardsMemberPercentage < .25)
            {
                Console.WriteLine("Todo: Use the funds to market the rewards program");
            }
            else if(rewardsMemberPercentage > .25 && rewardsMemberPercentage < .75)
            {
                Console.WriteLine($"Todo: Use the funds to give coffee to the percent of loyal customers.");
            }
            else
            {
                Console.WriteLine("Todo: Use the funds to give them 10% off!");
            }


            switch (Q1Results.AreaToImprove)
            {
                case "Service":
                    Console.Write("ToDo: Speak with service manager");
                    break;
                case "Pricing":
                    Console.WriteLine("ToDo: Work with suppliers to lower costs");
                    break;
                case "Cleanliness":
                    Console.WriteLine("Todo: Research dedicated cleaning service options.");
                    break;
                default:
                    Console.WriteLine("Check the comments to get ideas");
                    break;
            }
        }

        static void GenerateMetricsReport()
        {
            // Calculated Values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
            Console.WriteLine($"Overall Score: {overallScore}");

            // Logical comparisons
            bool higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool customersRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

            Console.WriteLine($"Coffee Score Higher Than Food: {higherCoffeeScore}");
            Console.WriteLine($"Customers Would Recommend Us: {customersRecommend}");
            Console.WriteLine($"Hate Granola, Love Cappucino: {noGranolaYesCappucino}");
        }
    }
}
