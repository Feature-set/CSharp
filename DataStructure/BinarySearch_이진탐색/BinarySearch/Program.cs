using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int first = 0;
            int last = array.Length - 1;
            int target = 3;
            int answer = 0;

            answer = BSearchRecur(array, first, last, target);
            Console.WriteLine(answer);
        }

        static public int BSearchRecur(int[] ar, int first, int last, int target)
        {
            int mid = (first + last) / 2;
            if (first > last)
                return -1; // 목표값이 배열에 없을 경우 -1을 반환

            if (ar[mid] == target)
                return mid;
            else if (target < ar[mid])
                return BSearchRecur(ar, first, mid - 1, target);
            else
                return BSearchRecur(ar, mid + 1, last, target);
        }
    }
}
