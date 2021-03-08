using System;
using System.Collections.Generic;
using System.Linq;

namespace pipes.console
{
    public class Program
    {
        private static int[] Min(List<int> A)
        {
            int result = int.MaxValue;
            int index = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                if (A[i] < result)
                {
                    result = A[i];
                    index = i;
                }
            }
            return new int[] { index, result };
        }

        public static int MaxShows(int N, int H, int[] A)
        {
            //this is default OUTPUT. You can change it.
            int result = 0;
            //write your Logic here:
            var listOfPipes = A.ToList();

            while (Min(listOfPipes)[1] < H)
            {
                var firstPipe = Min(listOfPipes);
                listOfPipes.RemoveAt(firstPipe[0]);
                var secondPipe = Min(listOfPipes);
                listOfPipes.RemoveAt(secondPipe[0]);

                listOfPipes.Add(firstPipe[1] + secondPipe[1]);
                result += secondPipe[1];
            }
            return result;
        }

        static void Main(string[] args)
        {
            // INPUT [uncomment & modify if required]
            int N = 0;
            int i = 0;
            int H = 0;
            Console.WriteLine("N & H:");
            string[] tokens1 = Console.ReadLine().Split();
            N = Convert.ToInt32(tokens1[0]);
            H = Convert.ToInt32(tokens1[1]);
            int[] A = new int[N];
            Console.WriteLine("A:");
            string[] tokens = Console.ReadLine().Split();
            for (i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt32(tokens[i]);
            }
            // OUTPUT [uncomment & modify if required]
            Console.WriteLine(MaxShows(N, H, A));
        }
    }
}