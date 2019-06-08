using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[] { 186, 419, 83, 408 };

            int count = CoinChange(coins, 6249);

            //int[] coins = new int[] { 1, 2, 5 };

            //int count = CoinChange(coins, 11);

            Console.Read();
        }


        public static int CoinChange(int[] coins, int amount)
        {
            int coinCount = CoinChangeHelper(amount, coins, new int[amount]);
            return coinCount;
        }

        public static int CoinChangeHelper(int amount, int[] coins, int[] count)
        {
            if (amount < 0) return -1;
            if (amount == 0) return 0;

            if (count[amount - 1] != 0) return count[amount - 1];

            int min = int.MaxValue;

            for (int i = 0; i < coins.Length; i++)
            {
               int result = CoinChangeHelper(amount - coins[i], coins, count);
                if (result >= 0 && result < min)
                    min = result + 1;
            }

            count[amount - 1] = (min == int.MaxValue) ? -1 : min;
            return count[amount - 1];
        }


        //public static int CoinChange(int[] coins, int amount)
        //{
        //    coins = coins.OrderBy(c => c).ToArray();

        //    int coinCount = 0;
        //    int coinReducer = 0;
        //    int coinIndex = coins.Length - 1;
        //    int remainingAmount = amount;

        //    int coinReducerCounter = remainingAmount / coins[coinIndex];

        //    while (coinIndex >= 0)
        //    {
        //        coinCount = CoinChangeHelper(remainingAmount, coinIndex, coins, coinReducer);

        //        if (coinReducer < coinReducerCounter)
        //        {
        //            coinReducer++;
        //        }
        //        else
        //        {
        //            coinIndex--;
        //            if(coinIndex >=0)
        //                coinReducerCounter = remainingAmount / coins[coinIndex];
        //            coinReducer = 1;
        //        }
        //    }

        //    return coinCount;
        //}

        //public static int CoinChangeHelper(int amount, int coinIndex, int[] coins, int coinReducer)
        //{
        //    if (coinIndex < 0 && amount > 0) return -1;
            
        //    int remainder = amount  % coins[coinIndex];
        //    int coinCount = amount / coins[coinIndex];

        //    remainder = remainder + (coinReducer * coins[coinIndex]);
        //    coinCount = coinCount - coinReducer;

        //    if (remainder == 0) return coinCount;

        //    if (remainder > 0)
        //    {
        //        coinIndex--;
        //        var result = CoinChangeHelper(remainder, coinIndex, coins, 0);

        //        if (result == -1) return -1;
        //        else coinCount += result;
        //    }

        //    return coinCount;
        //}

        //----------------------------------------------------------

        // Note: Partial Solution
        //public static int CoinChange(int[] coins, int amount)
        //{
        //    coins = coins.OrderBy(c => c).ToArray();

        //    int coinCount = 0;
        //    int coinReducer = 1;
        //    int coinIndex = coins.Length - coinReducer;
        //    int remainingAmount = amount;


        //    while (coinIndex >= 0)
        //    {
        //        while (remainingAmount > 0 && coinIndex >= 0)
        //        {
        //            int coinValue = coins[coinIndex];
        //            remainingAmount = remainingAmount - coinValue;
        //            coinCount++;

        //            if (remainingAmount == 0) return coinCount;
        //            if (remainingAmount < 0)
        //            {
        //                remainingAmount = remainingAmount + coinValue;
        //                coinCount--;
        //                coinIndex--;
        //            }
        //        }

        //        coinReducer++;
        //        coinCount = 0;
        //        coinIndex = coins.Length - coinReducer;
        //        remainingAmount = amount;
        //    }


        //    if (remainingAmount > 0)
        //        return -1;

        //    return coinCount;
        //}
    }
}
