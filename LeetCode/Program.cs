using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] arr = {1,2,3,4,5,6,7 };
             Rotate(arr,3);
        }

        /// <summary>
        /// 删除重复项，利用数组是排序的，使用两个指针
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            //if (nums.Length <= 1) return nums.Length;
            //int count = 0;
            //for (int i = 0; i < nums.Length - 1; i++)
            //    if (nums[i + 1] > nums[i])
            //        nums[++count] = nums[i + 1];
            //return (count + 1);
            //边界判断
            if (nums == null || nums.Length == 0) { return 0; }
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
                //判断是否相同
                if ((nums[count] ^ nums[i]) != 0)
                {
                    //如不相同，则替换
                    nums[++count] = nums[i];
                }
            return count + 1;
        }

        /// <summary>
        /// 买卖股票 
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 0)
            {
                return 0;
            }

            int money = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i])
                {
                    money += prices[i + 1] - prices[i];
                }
            }
            return money;
        }
        /// <summary>
        /// 指定处旋转数组
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Rotate(int[] nums, int k)
        {

            //int length = nums.Length;
            //k = k % length;
            //for (int i = 0; i < k; i++)
            //{
            //    int temp = nums[length - 1];
            //    for (int j =length-1 ; j >0; j--)
            //    {
            //        nums[j] = nums[j - 1];
            //    }
            //    nums[0] = temp;
            //}
            //------------------------------------------
            //k = k % nums.Length;
            //int[] temp = new int[k];

            //for (int i = nums.Length - k, j = 0; i < nums.Length; i++, j++)
            //{
            //    temp[j] = nums[i];
            //}
            //for (int i = nums.Length - k - 1; i >= 0; i--)
            //{
            //    nums[i + k] = nums[i];
            //}
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    nums[i] = temp[i];
            //}
            //-----------------------------------------
            //List<int> a = new List<int>(nums.Length);
            //for (int i = k+1; i <nums.Length; i++)
            //{
            //    a.Add(nums[i]);
            //}
            //for (int i = 0; i <k+1; i++)
            //{
            //    a.Add(nums[i]);
            //}
            //nums = a.ToArray();
            //----------------------------------------
            k %= nums.Length;
            if (nums == null || nums.Length <= 1 || k <= 0)
            {
                return;
            }
            Overturn(nums, 0, nums.Length - 1);
            Overturn(nums, 0, k - 1);
            Overturn(nums, k, nums.Length - 1);
        }
        public static void Overturn(int[] nums, int startIndex, int endIndex)
        {
            int cache;

            while (endIndex > startIndex)
            {
                cache = nums[startIndex];

                nums[startIndex++] = nums[endIndex];

                nums[endIndex--] = cache;
            }
        }
    }
}
