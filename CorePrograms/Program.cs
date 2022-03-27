using System.Collections;

namespace CorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter Your choice");
            Console.WriteLine("\n1.Flip A Coin \n2.Quotient And Remainder \n3.Check a Number is Even or Odd \n4. Find if Year is Leap Year or not. \n5.Calculate Power of Two");
            Console.WriteLine("6.Check Entered character is Consonent or Vowel \n7.Calculate Harmonic Value till Entered Number \n8.Find Largest Amoung Three Numbers");
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

                case 4:
                     LeapYear leapYear = new LeapYear();
                     leapYear.acceptYear();
                     leapYear.checkIfLeapOrNot();
                break;

                case 5:
                     PowerOfTwo powerOfTwo = new PowerOfTwo();
                     powerOfTwo.getPoewrNumber();
                     powerOfTwo.calculatePower();
                break;

                case 6:
                     ConsonentVowelDetect consonentVowelDetect = new ConsonentVowelDetect();
                     consonentVowelDetect.getChar();
                     consonentVowelDetect.checkConsonentOrVowel();
                break;

                case 7:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.getHarmonicNumber();
                    //Console.WriteLine($"{harmonic}");
                break;

                case 8:
                    LargestOfThree largestOfThree = new LargestOfThree();
                    largestOfThree.getNumbers();
                    largestOfThree.compareNumbers();
                break; 
                
                default:
                    Console.WriteLine("Enter Correct Details: ");
                break;
            }
        }
    }
}