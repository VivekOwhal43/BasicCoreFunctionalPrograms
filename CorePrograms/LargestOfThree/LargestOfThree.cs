namespace CorePrograms
{
    public class LargestOfThree
    {
        int num1, num2, num3;
        public void getNumbers()
        {
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
        }

        public void compareNumbers()
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("First Number is Gratest");
            }
            else if(num2 > num1 && num2>num3)
            {
                Console.WriteLine("Second Number is Gratest ");
            }
            else
            {
                Console.WriteLine("Third Number is Gratest ");
            }
        }
    }
}