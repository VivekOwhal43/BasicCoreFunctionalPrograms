namespace CorePrograms
{
    public class SwapTwoNumbers
    {
        int num1, num2, temp;
        public void acceptNumber()
        {
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        public void swapNumbers()
        {
            temp = num1;
            num1 = num2;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Swapped Numbers \nNumber1: {num1} \nNumber2: {num2}");
        }
    }
}