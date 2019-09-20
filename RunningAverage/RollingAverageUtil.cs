using System;
using System.Collections.Generic;
using System.Linq;

namespace RunningAverage
{
    public static class RollingAverageUtil
    {

        public static double[] Compute(int WindowSize, double[] dArray)
        {
            //some basic error checking
            if (WindowSize <= 0) throw new Exception("Window size cannot be less than 1!");
            if (dArray == null || dArray.Length == 0) throw new Exception("Array cannot be null or empty!");



            double[] result = new double[dArray.Length];
            double currentAverage = 0;

            for (int i = 0; i < dArray.Length; i++)
            {
                if (i < WindowSize) //we haven't hit the max windowsize4
                {
                    currentAverage = (double)(currentAverage * (i) / (i + 1)) + (double)(dArray[i] / (i + 1));
                }
                else
                {
                    //we remove the oldest element value (-) and add the newest element and then divide by count to get additive
                    var additive = (-dArray[i - WindowSize] + dArray[i]) / WindowSize;
                    currentAverage += additive;
                }
                //add it to the current average and assign

                result[i] = currentAverage;
            }

            return result;
        }



        [Obsolete("This is an example of how to Compute the rolling average a little bit slower. Do not use.", true)]
        public static double[] ComputeSlower(int WindowSize, double[] dArray)
        {
            //some basic error checking
            if (WindowSize <= 0) throw new Exception("Window size cannot be less than 1!");
            if (dArray == null || dArray.Length == 0) throw new Exception("Array cannot be null or empty!");

            List<double> Averaginglist = new List<double>();

            double[] result = new double[dArray.Length];
            double currentAverage = 0;

            for (int i = 0; i < dArray.Length; i++)
            {
                if (i < WindowSize) //we haven't hit the max windowsize4
                {
                    Averaginglist.Add(dArray[i]);
                }
                else
                {
                    //we remove the oldest element 
                    Averaginglist.RemoveAt(0);
                    Averaginglist.Add(dArray[i]);
                }
                result[i] = Averaginglist.Average();
            }

            return result;
        }


    }
}