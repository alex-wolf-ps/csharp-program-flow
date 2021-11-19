using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffeeSurveys.Reports.Services
{
    class SurveyDataService
    {
        public static SurveyResults GetSurveyDataByFileName()
        {
            Console.WriteLine("Please specify which quarter of data: q1 or q2");
            var selectedFile = Console.ReadLine();
            
            return JsonConvert.DeserializeObject<SurveyResults>
                    (File.ReadAllText($"data/{selectedFile}.json"));
        }
    }
}
