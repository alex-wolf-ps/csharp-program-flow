using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculated Values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
            Console.WriteLine($"Overall Score: {overallScore}");

            // Logical comparisons
            bool isCoffeeScoreLower = Q1Results.CoffeeScore < Q1Results.FoodScore;
            bool customersRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

            Console.WriteLine($"Coffee Score Higher Than Food: {isCoffeeScoreLower}");
            Console.WriteLine($"Customers Would Recommend Us: {customersRecommend}");
            Console.WriteLine($"Hate Granola, Love Cappucino: {noGranolaYesCappucino}");
        }
    }
}
