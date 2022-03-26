namespace CorePrograms
{
    class EvenOdd
    {
        public void getEvenOddNumber()
        {
            Console.Write("\nEnter A Number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("Entered Number is Even");
            }
            else
            {
                Console.WriteLine("Entered Number is Odd");
            }
        }
    }
}