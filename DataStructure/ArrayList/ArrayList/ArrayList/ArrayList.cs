using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class ArrayList
    {
        private const int LIST_LEN = 100;
        private LData[] arr;
        private int numOfData;
        private int curPosition;

        public ArrayList()
        {
            arr = new LData[LIST_LEN];
            numOfData = 0;
            curPosition = -1;
        }

        public void ListInit()
        {
            numOfData = 0;
            curPosition = -1;
        }

        public void LInsert(LData data)
        {
            if (numOfData >= LIST_LEN)
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
            pdata = arr[curPosition];
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
            LData rdata = arr[curPosition];

            for (int i = curPosition; i < numOfData - 1; i++)
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
}
