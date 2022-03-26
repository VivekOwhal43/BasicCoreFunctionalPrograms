namespace CorePrograms
{
    public class PowerOfTwo
    {
        int power;
        const int powerLimit = 32;
        double powerResult;
        public void getPoewrNumber()
        {
            Console.WriteLine("Enter Power for 2:");
            power = Convert.ToInt32(Console.ReadLine());
        }
        public void calculatePower()
        {
            for (int i = 0; i <= power; i++)
            {
                if (power < powerLimit )
                {
                    powerResult = Math.Pow(2, i);
                    Console.WriteLine($"Two to power {i} = {powerResult}");
                }
                else if(i == power)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Number out of Range. \nYou can enter number less than or equal to 32");
                    break;
                }
            }

        }
    }
}