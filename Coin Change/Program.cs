using System;

namespace Coin_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[] {1};
            int amount = 0;
            Console.WriteLine("result:" + CoinChange(coins,amount));


        }
        public static int CoinChange(int[] coins, int amount)
        {
            Array.Sort(coins);
            int ptn = coins.Length - 1;
            int counter =0;
            while (ptn>=0)
            {
               
                if (amount>0)
                {
                    if (amount > coins[ptn])
                    {
                        amount -= coins[ptn];
                        counter++;
                    }
                    else if (amount - coins[ptn] == 0)
                    {
                        counter++;
                        return counter;
                    }
                    
                    else
                    {
                        ptn--;
                    }
                }
                else if (amount - coins[ptn] <= 0)
                {
                    return amount;
                }
            }
            return -1;

        }
    }
}
