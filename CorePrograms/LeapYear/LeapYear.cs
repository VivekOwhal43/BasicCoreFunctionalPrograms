using System.Security;

namespace CorePrograms
{
    public class LeapYear
    {
        int userYear;
        // LeapYear(int userYear)
        // {
        //     this.userYear =userYear;
        // }
        public void acceptYear()
        {
            Console.WriteLine("Enter Year");
            userYear = Convert.ToInt32(Console.ReadLine());
        }

        public void checkIfLeapOrNot()
        {
            while (userYear <= 999)
            {
                Console.WriteLine($"Entered year is {userYear}");
                Console.WriteLine("Year is less than 1000 \nEnter Year greater than 999 ");
                acceptYear();
                if (userYear >= 999)
                {
                    Console.WriteLine($"Entered year is {userYear}");

                }
            }
            if ((userYear%4)==0 && (userYear%100)!=0 || (userYear%400)==0)
            {
                Console.WriteLine($"{userYear} is a Leap Year");
            }
            else
            {
                Console.WriteLine($"{userYear} is not a Leap Year");
            }

        }
    }
}