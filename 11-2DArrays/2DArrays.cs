using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Solution
    {
        static void Main(string[] args)
        {
            int rowSize = 6;
            int colSize = 6;
            int hourglassSize = 3;
            int sum = 0;
            List<int> result = new List<int>();
            /*
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            */

            //radek,sloupec

            int[][] arr = new int[][]
            {
                new int[] {1,1,1,0,0,0},
                new int[] {0,1,0,0,0,0},
                new int[] {1,1,1,0,0,0},
                new int[] {0,0,2,4,4,0},
                new int[] {0,0,0,2,0,0},
                new int[] {0,0,1,2,4,0}
            };

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.Write("\n");
            }

            Console.WriteLine("");

            for (int i = 0; i <= (rowSize - hourglassSize); i++)
            {
                for (int j = 0; j <= (colSize - hourglassSize); j++)
                {
                    sum += arr[i][j];
                    sum += arr[i][j+1];
                    sum += arr[i][j+2];
                    sum += arr[i+1][j+1];
                    sum += arr[i+2][j];
                    sum += arr[i+2][j+1];
                    sum += arr[i+2][j+2];
                    result.Add(sum);
                    sum = 0;
                }
            }

            Console.WriteLine("Maximalni hodnota presypacich hodin:");
            Console.WriteLine(result.Max());
            Console.ReadKey();


        }
    }
}
