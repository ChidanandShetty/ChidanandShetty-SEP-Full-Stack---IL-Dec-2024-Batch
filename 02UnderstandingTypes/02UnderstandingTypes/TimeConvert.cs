namespace _02UnderstandingTypes
{
    internal class TimeConvert
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of centuries: ");
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = years * 36524 / 100;  // 1 century = 36524 days (accounting for leap years)
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            ulong nanoseconds = (ulong)microseconds * 1000; // Use ulong to prevent overflow

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        
        }
    }
}
