using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffeeSurveys.Reports
{
    public class SurveyResults
    {
        // Aggregate ratings
        public double ServiceScore { get; set; }

        public double CoffeeScore { get; set; }

        public double PriceScore { get; set; }

        public double FoodScore { get; set; }

        public double WouldRecommend { get; set; }

        public string FavoriteProduct { get; set; }

        public string LeastFavoriteProduct { get; set; }

        public string AreaToImprove { get; set; }

        // Aggregate counts
        public double NumberSurveyed { get; set; }

        public double NumberResponded { get; set; }

        public double NumberRewardsMembers { get; set; }

        // Individual survey responses
        public List<SurveyResponse> Responses { get; set; }
    }
}
