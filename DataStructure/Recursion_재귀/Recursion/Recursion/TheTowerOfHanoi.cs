using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class TheTowerOfHanoi
    {
        /// <summary>
        /// 하노이타워 
        /// </summary>
        /// <param name="Num">옮겨질 타워층</param>
        /// <param name="from">출발 타워</param>
        /// <param name="by">경유 타워</param>
        /// <param name="to">목적 타워</param>
        public static void Hanoi(int Num, char from, char by, char to)
        {
            if (Num == 1)
                Console.WriteLine($"출발지 : {from} 도착지 : {to} 이동층 {Num}");
            else
            {
                Hanoi(Num - 1, from, to, by);
                Console.WriteLine($"출발지 : {from} 도착지 : {to} 이동층 {Num}");
                Hanoi(Num - 1, by, from, to);
            }
        }
    }
}
