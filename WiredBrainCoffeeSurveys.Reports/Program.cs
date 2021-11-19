using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WiredBrainCoffeeSurveys.Reports.Services;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitApp = false;
            var surveyResults = SurveyDataService.GetSurveyDataByFileName();

            do
            {
                Console.WriteLine("Please specify a report to run or other option: (r)ewards, (c)omments, (t)asks, (d)ataChange, or (q)uit");
                var selectedReport = Console.ReadLine();

                switch (selectedReport)
                {
                    case "rewards" or "r":
                        RewardsReportService.GenerateWinnerEmails(surveyResults);
                        break;
                    case "comments" or "c":
                        CommentsReportService.GenerateCommentsReport(surveyResults);
                        break;
                    case "tasks" or "t":
                        TasksReportService.GenerateTasksReport(surveyResults);
                        break;
                    case "dataChange" or "d":
                        surveyResults = SurveyDataService.GetSurveyDataByFileName();
                        break;
                    case "quit" or "q":
                        quitApp = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, that's not a valid option.");
                        break;
                }

                Console.WriteLine();
            }
            while (!quitApp);
        }
    }
}
