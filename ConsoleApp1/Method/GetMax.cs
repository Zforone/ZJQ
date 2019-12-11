using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
     public class GetMax
    {
        public double GetMaxInArray(double[] score)
        {
            double maxScore;
            if (score[0] > score[1])
            {
                maxScore = score[0];
            }
            else
            {
                maxScore = score[1];
            }
            for (int i = 0; i < score.Length - 1;)
            {
                double j = score[i + 1];
                if (maxScore < j)
                {
                    maxScore = j;
                }
                else
                {
                    //nothing
                }
                i++;
            }
            return maxScore;
        }
    }
}
