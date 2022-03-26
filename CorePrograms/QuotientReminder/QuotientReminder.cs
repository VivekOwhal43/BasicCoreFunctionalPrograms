using System.Runtime.CompilerServices;

namespace CorePrograms
{
    public class QuotientReminder
    {
        int devisor, devident;
        int quotient, reminder=0;
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
            //we can obtain Quotient in following Two Ways:
            
            quotient = (devident / devisor);
            quotient = Math.DivRem(devident,devisor, out reminder);
            Console.WriteLine("Quotient " + quotient);

            //we can obtain reminder in following Two Ways :
            //reminder = devident-(devisor * quotient);

            reminder = devident % devisor;
            Console.WriteLine("Reminder: " + reminder);
        }
    }
}