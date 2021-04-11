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

        // Individual survey responses
        public static List<SurveyResponse> Responses = new List<SurveyResponse>()
        {
            new SurveyResponse()
            {
                EmailAddress = "test1@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 9.0,
                PriceScore = 7.0,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Latte",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Coffee and service are great!"
            },
            new SurveyResponse()
            {
                EmailAddress = "test2@sample.com",
                CoffeeScore = 10.0,
                FoodScore = 6.0,
                PriceScore = 7.0,
                ServiceScore = 7.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Cappucino",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "The mobile app looks bad on Android devices."
            },
            new SurveyResponse()
            {
                EmailAddress = "test3@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "Cleanliness",
                FavoriteProduct = "Americano",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Overall I had a great experience, I like the store design."
            },
            new SurveyResponse()
            {
                EmailAddress = "test4@sample.com",
                CoffeeScore = 9.0,
                FoodScore = 5.0,
                PriceScore = 7.5,
                ServiceScore = 8.5,
                AreaToImprove = "Pricing",
                FavoriteProduct = "Cappucino",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 4.0,
                Comments = "The pickup area should be by the door. Also Your prices are much higher than the surrounding stores."
            },
            new SurveyResponse()
            {
                EmailAddress = "test5@sample.com",
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
                EmailAddress = "test6@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Green tea macha",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 7.5,
                Comments = "Your staff are very friendly but your mobile app is too slow."
            },
            new SurveyResponse()
            {
                EmailAddress = "test7@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Green tea macha",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 7.5,
                Comments = "The mobile app doesn't work on tablets."
            },
            new SurveyResponse()
            {
                EmailAddress = "test8@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Green tea macha",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 6.5,
                Comments = "So close to recommending but your prices are so high."
            }
        };
    }
}
