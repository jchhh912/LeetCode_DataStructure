using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Test
{
    class TestSearch
    {
        public static int OrderSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==target)
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearch(int [] arr,int target)
        {
            int l = 0;
            int r = arr.Length-1;
            while (l<=r)
            {
                //int min = (l + r) / 2;  当L 和R 值都很打时  Int 可能会整形溢出
                int min = l + (r - l) / 2;
                if (target<arr[min])
                {
                    r = min - 1;
                }
                else if(target>arr[min])
                {
                    l = min + 1;
                }
                else
                {
                    return min;
                }
            }
            return -1;
        }
    }
}
