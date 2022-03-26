namespace CorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            // EvenOdd evenOdd = new EvenOdd();
            // evenOdd.getEvenOddNumber();

            QuotientReminder quotientReminder = new QuotientReminder();
            quotientReminder.getDataQuotientAndReminder();
            quotientReminder.showDataQuotientAndReminder();
        }
    }
}