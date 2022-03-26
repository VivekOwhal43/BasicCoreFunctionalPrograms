using System.Collections;

namespace CorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter Your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                //Created object of FlipCoin Class
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.getCoinDetails();
                    flipCoin.getFlippingResult();
                    flipCoin.totalHeadAndTail();
                    flipCoin.getPercentageOfHeadTails();
                break;

                case 2:
                    QuotientReminder quotientReminder = new QuotientReminder();
                    quotientReminder.getDataQuotientAndReminder();
                    quotientReminder.showDataQuotientAndReminder();
                break;

                case 3:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.getEvenOddNumber();
                break;
                default:
                    Console.WriteLine("Enter Correct Details: ");
                break;
            }
        }
    }
}