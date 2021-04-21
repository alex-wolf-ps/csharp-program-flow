using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateTasksReport();
        }

        static void GenerateTasksReport()
        {
            var tasks = new List<string>();

            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            if (Q1Results.CoffeeScore < Q1Results.FoodScore)
            {
                tasks.Add("Revisit recipes for quality and taste.");
            }

            double rewardsMemberPercentage = Q1Results.NumberRewardsMembers / Q1Results.NumberResponded;

            if (rewardsMemberPercentage < .25)
            {
                Console.WriteLine("Todo: Use the funds to market the rewards program");
            }
            else if (rewardsMemberPercentage > .25 && rewardsMemberPercentage < .75)
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
    }
}
