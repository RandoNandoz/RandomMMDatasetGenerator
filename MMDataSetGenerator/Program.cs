using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MMDataSetGenerator
{
    static class Program
    {

        private static DatasetGenerator _datasetGenerator = new DatasetGenerator();
        private static Random _random = new Random();
        static void Main(string[] args)
        {
            int defaultInputDeviationTolerance = 4;
            int intuserinput;
            int userDefinedInputDeviationTolerance = 0;
            #region iterator

            
            Console.WriteLine("How many times would you like to execute this?");
            int iterationTimes;
            int.TryParse(Console.ReadLine(), out iterationTimes);
          
            

            #endregion

            #region UserInput

            Console.WriteLine("How many M&Ms are you going to get?");
            intuserinput = Convert.ToInt32(GetReturnUserInput());
            Console.WriteLine($"Standard deviation of your inputted value is {defaultInputDeviationTolerance}, " +
                              "if you would like another value, please input it here.");
            try
            {
                userDefinedInputDeviationTolerance = Convert.ToInt32(GetReturnUserInput());
            }
            catch (Exception e)
            {
                Console.WriteLine("No, or malformed input detected, going with default value of 4");
                userDefinedInputDeviationTolerance = defaultInputDeviationTolerance;
            }

            #endregion
            #region Logic

            for (int i = 0; i < iterationTimes; i++)
            {
                Console.WriteLine($"This is iteration {i+1}");
                _datasetGenerator.GenerateDataMnMDataset(_random.Next(
                    intuserinput - userDefinedInputDeviationTolerance,
                    intuserinput + userDefinedInputDeviationTolerance));
            
                foreach (KeyValuePair<string,int> keyValuePair in _datasetGenerator.MnMDictionary)
                {
                    Console.WriteLine($"{keyValuePair.Key}, {keyValuePair.Value}");
                }
            }

            #endregion

            // Console.WriteLine(_datasetGenerator.GenerateDataMnMDataset(_random.Next(Intuserinput-= userDefinedInputDeviationTolerance, Intuserinput += userDefinedInputDeviationTolerance)));
        }
        private static string GetReturnUserInput()
        {
            string userInput;
            try
            {
                userInput = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Malformed input");
                GetReturnUserInput();
                throw;
            }

            return userInput;
        }
    }
    

}