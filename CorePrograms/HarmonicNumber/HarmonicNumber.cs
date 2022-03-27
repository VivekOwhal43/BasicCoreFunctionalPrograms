namespace CorePrograms
{
    public class HarmonicNumber
    {
        public static float harmonic;
        public int userNumber;
        public void getHarmonicNumber()
        {
            Console.Write($"Enter a number: ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            harmonic = 1;
            for (int i = 2; i <= userNumber; i++)
            {
                harmonic += (float)1 / i;
            }
            Console.WriteLine($"Value of Harmonic Number :{harmonic}");
        }
    }
}