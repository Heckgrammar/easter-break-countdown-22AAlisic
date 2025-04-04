namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your target year?");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your target month?");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your target day?");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your target hour?");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your target minute?");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your target second?");
            int second = Convert.ToInt32(Console.ReadLine());
            DateTime target = new DateTime(year, month, day, hour, minute, second);
            while (true) {
                DateTime current = DateTime.Now;
                TimeSpan difference = target - current;
                if (difference.Days > 365)
                {
                    Console.WriteLine((difference.Days) / 365 + ":" + (difference.Days) % 365 + ":" + difference.Hours + ":" + difference.Minutes + ":" + difference.Seconds);
                }
                else if (difference.Days > 0)
                {
                    Console.WriteLine(difference.Days + ":" + difference.Hours + ":" + difference.Minutes + ":" + difference.Seconds);
                }
                else
                {
                    Console.WriteLine(difference.Hours + ":" + difference.Minutes + ":" + difference.Seconds);
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
            
        }
    }
}
