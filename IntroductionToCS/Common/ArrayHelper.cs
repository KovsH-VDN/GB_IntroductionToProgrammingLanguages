using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.Common
{
    public static class ArrayHelper
    {
        public static int[] CreateIntArray(int length)
        {
            Random random = new Random();

            return Enumerable.Range(0, length).Select(n => random.Next()).ToArray();
        }
        public static int[] CreateIntArrayInRange(int length, int min, int max)
        {
            Random random = new Random();

            return Enumerable.Range(0, length).Select(n => random.Next(min, max)).ToArray();
        }
        public static double[] CreateDoubleArray(int length, int min, int max)
        {
            Random random = new Random();

            return Enumerable.Range(0, length).Select(n => random.Next(min, max) + random.NextDouble()).ToArray();
        }
        public static double[] CreateDoubleArrayInRange(int length, int min, int max, int round)
        {
            Random random = new Random();

            return Enumerable.Range(0, length).Select(n => Math.Round(random.Next(min, max) + random.NextDouble(), round)).ToArray();
        }
    }
}
