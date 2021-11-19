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
                Console.WriteLine("Please specify a report to run or other option: rewards, comments, tasks, dataChange, or quit");
                var selectedReport = Console.ReadLine();

                switch (selectedReport)
                {
                    case "rewards":
                        RewardsReportService.GenerateWinnerEmails(surveyResults);
                        break;
                    case "comments":
                        CommentsReportService.GenerateCommentsReport(surveyResults);
                        break;
                    case "tasks":
                        TasksReportService.GenerateTasksReport(surveyResults);
                        break;
                    case "dataChange":
                        surveyResults = SurveyDataService.GetSurveyDataByFileName();
                        break;
                    case "quit":
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
