using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class List
    {
        private const int LIST_LEN = 100; // 리스트의 최대 길이
        private int numOfData; // 저장된 데이터의 수
        private int curPosition; // 현재 데이터의 인덱스
        private LData[] arr; // 데이터를 저장할 배열

        public List()
        {
            numOfData = 0;
            curPosition = -1;
            arr = new LData[LIST_LEN];
        }

        public void LInsert(LData data)
        {
            if (numOfData > LIST_LEN)
            {
                Console.WriteLine("저장이 불가능합니다.");
                return;
            }

            arr[numOfData] = data;
            numOfData++;
        }

        public bool LFirst(out LData pdata)
        {
            if (numOfData == 0)
            {
                pdata = default(LData);
                return false;
            }

            curPosition = 0;
            pdata = arr[0];
            return true;
        }

        public bool LNext(out LData pdata)
        {
            if (curPosition >= numOfData - 1)
            {
                pdata = default(LData);
                return false;
            }

            curPosition++;
            pdata = arr[curPosition];
            return true;
        }

        public LData LRemove()
        {
            int rpos = curPosition;
            int num = numOfData;
            LData rdata = arr[rpos];

            for (int i = rpos; i < num - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            numOfData--;
            curPosition--;
            return rdata;
        }

        public int LCount()
        {
            return numOfData;
        }
    }

    public class ArrayListTest
    {
        static void Main()
        {
            List list = new List();

            list.LInsert(1);
            list.LInsert(2);
            list.LInsert(3);

            Console.WriteLine("Count: " + list.LCount());  // 출력: Count: 3

            LData item;
            if (list.LFirst(out item))
            {
                Console.WriteLine("Item at current position: " + item);  // 출력: Item at current position: 1

                while (list.LNext(out item))
                {
                    Console.WriteLine("Item at current position: " + item);  // 출력: Item at current position: 2
                                                                             // 출력: Item at current position: 3
                }
            }

            list.LRemove();

            Console.WriteLine("Count after removal: " + list.LCount());  // 출력: Count after removal: 2
        }
    }
}
