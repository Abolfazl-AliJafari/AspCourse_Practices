using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    public static class Algorithms
    {
        public static int Factorial(int Number)
        {
            if (Number == 0)
                return 1;
            else
            {
                return Number * Factorial(Number - 1);
            }
        }
        public static int BinarySearcher(int[] Array, int Search, int Left, int Right)
        {
            if (Right >= Left)
            {
                int mid = Left + (Right - Left) / 2;
                if (Array[mid] == Search)
                {
                    return mid;
                }
                if (Array[mid] > Search)
                {
                    return BinarySearcher(Array, Search, Left, mid - 1);
                }
                return BinarySearcher(Array, Search, mid + 1, Right);
            }
            return -1;
        }
        public static int LinearSearcher(int[] Array, int Search)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == Search)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int[] Binery_InsertionSorter(int[] Arry)
        {
            for (int i = 1; i < Arry.Length; i++)
            {
                int x = Arry[i];
                int index = Array.BinarySearch(Arry, 0, i, x);
                int j = Math.Abs(index + 1);

                Array.Copy(Arry, j, Arry, j + 1,i - j);
                Arry[j] = x;
            }
            return Arry;
        }
        public static int[] BubbleSorter(int[] Array)
        {
            int n = Array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        int save = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = save;
                    }
                }
            }
            return Array;
        }
    }
}
