using System.Diagnostics.Contracts;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Transactions;

namespace CorePrograms
{
    public class FlipCoin
    {
        public int coinFlipNumber, flipResult;
        public int heads, tails;

        //get details from user for flipping coin
        public void getCoinDetails()
        {
            Console.WriteLine("How many Time You want to flip a coin ? ");
            coinFlipNumber = Convert.ToInt32(Console.ReadLine());
        }
        // method for obtaining Coin flipping results (Head and Tail)
        public void getFlippingResult()
        {
            for (int i = 1; i <= coinFlipNumber; i++)
            {
                //Console.WriteLine($"Coin is flipped {i} times");
                // How many times coin has been flipped.
                Random random = new Random();
                double headTail = random.NextDouble();
                //Console.WriteLine($"Result {result}");
                if(headTail<0.5)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
        }

        public void totalHeadAndTail()
        {
            Console.WriteLine($"You have got {tails} Tails");
            Console.WriteLine($"You have got {heads} Heads");
        }
        public void getPercentageOfHeadTails()
        {
            double percentOfHead, percentOfTail;
            percentOfHead = (heads/Convert.ToDouble(coinFlipNumber))*100;
            percentOfTail = (tails/Convert.ToDouble(coinFlipNumber))*100;
            Console.WriteLine($"Total Percent of getting Heads: {percentOfHead}%");
            Console.WriteLine($"Total Percent of getting Heads: {percentOfTail}%");
        }
    }
}