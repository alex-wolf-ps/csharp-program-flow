using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffeeSurveys.Reports
{
    public static class Q1Results
    {
        // Aggregate ratings
        public static double ServiceScore { get; set; } = 8.0;

        public static double CoffeeScore { get; set; } = 4.0;

        public static double PriceScore { get; set; } = 6.0;

        public static double FoodScore { get; set; } = 7.5;

        public static double WouldRecommend { get; set; } = 6.5;

        public static string FavoriteProduct { get; set; } = "Cappucino";

        public static string LeastFavoriteProduct { get; set; } = "Granola";

        public static string AreaToImprove { get; set; } = "MobileApp";

        // Aggregate counts
        public static double NumberSurveyed { get; set; } = 500;

        public static double NumberResponded { get; set; } = 325;

        public static double NumberRewardsMembers { get; set; } = 130;

        public static List<SurveyResponse> Responses = new List<SurveyResponse>()
        {
            new SurveyResponse()
            {
                EmailAddress = "test@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Latte",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Coffee and service are great!"
            },
            new SurveyResponse()
            {
                EmailAddress = "test@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Cappucino",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 5.0,
                Comments = "Your mobile app is not very user friendly and prices are too high."
            },
            new SurveyResponse()
            {
                EmailAddress = "test@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "Cleanliness",
                FavoriteProduct = "Americano",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "The store I went into was not clean."
            },
            new SurveyResponse()
            {
                EmailAddress = "test@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Cappucino",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 4.0,
                Comments = "Your prices are higher than the surrounding stores."
            },
            new SurveyResponse()
            {
                EmailAddress = "test@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "Other",
                FavoriteProduct = "Iced Coffee",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 6.0,
                Comments = "I like the stores but your coffee is too expensive."
            },
            new SurveyResponse()
            {
                EmailAddress = "test@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Green tea macha",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 7.0,
                Comments = "Your staff are very friendly."
            }
        };
    }
}
