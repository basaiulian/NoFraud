// This file was auto-generated by ML.NET Model Builder. 

using System;
using ConsoleApp1ML.Model;

namespace ConsoleApp1ML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Col0 = 132187,
                Trans_date_trans_time = @"14-03-19 0:55",
                Cc_num = 4.91E+18F,
                Amt = 2999999999999999972.15F,
                First = @"Jeremy",
                Last = @"Chavez",
                City = @"Mesa",
                State = @"AZ",
                Lat = 33.4317F,
                Long = -111.8469F,
                Merch_lat = 33.192118F,
                Merch_long = -112.242884F
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Is_fraud with predicted Is_fraud from sample data...\n\n");
            Console.WriteLine($"Col0: {sampleData.Col0}");
            Console.WriteLine($"Trans_date_trans_time: {sampleData.Trans_date_trans_time}");
            Console.WriteLine($"Cc_num: {sampleData.Cc_num}");
            Console.WriteLine($"Amt: {sampleData.Amt}");
            Console.WriteLine($"First: {sampleData.First}");
            Console.WriteLine($"Last: {sampleData.Last}");
            Console.WriteLine($"City: {sampleData.City}");
            Console.WriteLine($"State: {sampleData.State}");
            Console.WriteLine($"Lat: {sampleData.Lat}");
            Console.WriteLine($"Long: {sampleData.Long}");
            Console.WriteLine($"Merch_lat: {sampleData.Merch_lat}");
            Console.WriteLine($"Merch_long: {sampleData.Merch_long}");
            Console.WriteLine($"\n\nPredicted Is_fraud value {predictionResult.Prediction} \nPredicted Is_fraud scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}