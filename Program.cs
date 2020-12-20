using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            long[] resultArray = new long[n + 1];
            for (int i = 0; i < m; i++)
            {
                string[] queries = Console.ReadLine().Split(' ');

                int a = int.Parse(queries[0]);
                int b = int.Parse(queries[1]);
                int k = int.Parse(queries[2]);

                resultArray[a] += k;
                if (b + 1 <= n)
                {
                    resultArray[b + 1] -= k;
                }
            }

            long tempMax = 0;
            long max = 0;
            for (int i = 1; i <= n; i++)
            {
                tempMax += resultArray[i];
                if (tempMax > max) max = tempMax;
            }


            long result = max;

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
