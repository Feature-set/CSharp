using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LData
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int data;

            list.ListInit();

            list.LInsert(11);
            list.LInsert(11);
            list.LInsert(22);
            list.LInsert(22);
            list.LInsert(33);

            Console.WriteLine("현재 데이터의 수: " + list.LCount());

            if (list.LFirst(out data))
            {
                Console.Write(data + " ");

                while (list.LNext(out data))
                    Console.Write(data + " ");
            }
            Console.WriteLine("\n");

            if (list.LFirst(out data))
            {
                if (data == 22)
                    list.LRemove();

                while (list.LNext(out data))
                {
                    if (data == 22)
                        list.LRemove();
                }
            }

            Console.WriteLine("현재 데이터의 수: " + list.LCount());

            if (list.LFirst(out data))
            {
                Console.Write(data + " ");

                while (list.LNext(out data))
                    Console.Write(data + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
