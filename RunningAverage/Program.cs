using System;

namespace RunningAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //RollingAverageUtil.Compute(3, null);

            int windowSize = 0;
            double[] dArray = new double[0];

            while (windowSize <= 0) //we don't have a valid window size
            {


                Console.WriteLine("Please enter a window size (int greater than 0)");
                var sWindowSize = Console.ReadLine();

                //error checking
                if (!int.TryParse(sWindowSize, out windowSize))
                    Console.WriteLine("You did not enter a valid interger.");
                else if (windowSize <= 0)
                    Console.WriteLine("You cannot enter less than 1.");

            }

            while (dArray == null || dArray.Length == 0) //we don't have a array
            {
                try
                {
                    Console.WriteLine("Please enter an Array of doubles seperated by ','");
                    var sCSVArray = Console.ReadLine();
                    var sArray = sCSVArray.Split(',',StringSplitOptions.RemoveEmptyEntries);
                    dArray = Array.ConvertAll(sArray, Double.Parse);

                }
                catch (FormatException ex)
                {

                    Console.WriteLine("One of the values entered was not a double.");
                    continue;
                }
                if (dArray.Length <= 0)
                    Console.WriteLine("You haven't entered an array.");


            }

            var result = RollingAverageUtil.Compute(windowSize, dArray);


            Console.WriteLine(string.Join(",", result));
            Console.ReadLine();

        }
    }
}
