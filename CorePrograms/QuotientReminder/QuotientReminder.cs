namespace CorePrograms
{
    public class QuotientReminder
    {
        int devisor, devident;
        float quotient, reminder;
        // public QuotientReminder(int devisor, int devident)
        // {
        //     this.devisor = devisor;
        //     this.devident = devident;
        // }
        //devisor = 3, divident: 15 quotient: 0 reminder: 3
        public void getDataQuotientAndReminder()
        {
            Console.Write("\nEnter Devident Number: ");
            devident = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Devisor Number: ");
            devisor = Convert.ToInt32(Console.ReadLine());
        }

        public void showDataQuotientAndReminder()
        {
            quotient = (devident / devisor);
            Console.WriteLine("Quotient " + quotient);
            // we can obtain reminder in two ways :
            //reminder = devident-(devisor * quotient);
            reminder = devident % devisor;
            Console.WriteLine("Reminder: " + reminder);
        }
    }
}