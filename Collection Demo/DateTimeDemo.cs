namespace Collection_Demo
{
    internal class DateTimeDemo
    {
        public static void DateTimeDemoMain()
        {
            // Current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("1. Current Date and Time: " + now);

            // Current date only
            DateTime today = DateTime.Today;
            Console.WriteLine("\n2. Current Date (Time is 00:00:00): " + today);

            // UTC time
            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine("\n3. Current UTC Date and Time: " + utcNow);

            // Custom date and time
            DateTime customDateTime = new DateTime(2024, 12, 25, 10, 30, 45);
            Console.WriteLine("\n4. Custom DateTime: " + customDateTime);

            // Extracting date components
            Console.WriteLine("\n5. Extracting Components:");
            Console.WriteLine($"   Year: {now.Year}");
            Console.WriteLine($"   Month: {now.Month}");
            Console.WriteLine($"   Day: {now.Day}");
            Console.WriteLine($"   Hour: {now.Hour}");
            Console.WriteLine($"   Minute: {now.Minute}");
            Console.WriteLine($"   Second: {now.Second}");
            Console.WriteLine($"   Millisecond: {now.Millisecond}");
            Console.WriteLine($"   Day of Week: {now.DayOfWeek}");
            Console.WriteLine($"   Day of Year: {now.DayOfYear}");

            // Adding time
            Console.WriteLine("\n6. Adding Time:");
            Console.WriteLine($"   Add 10 Days: {now.AddDays(10)}");
            Console.WriteLine($"   Add 2 Months: {now.AddMonths(2)}");
            Console.WriteLine($"   Add 3 Years: {now.AddYears(3)}");
            Console.WriteLine($"   Add 5 Hours: {now.AddHours(5)}");
            Console.WriteLine($"   Add 30 Minutes: {now.AddMinutes(30)}");

            // Subtracting time
            Console.WriteLine("\n7. Subtracting Time:");
            DateTime earlierDate = now.AddDays(-7);
            Console.WriteLine($"   7 Days Ago: {earlierDate}");
            TimeSpan difference = now.Subtract(earlierDate);
            Console.WriteLine($"   Difference Between {now} and {earlierDate}: {difference.TotalDays} days");

            // Formatting
            Console.WriteLine("\n8. Formatting Date and Time:");
            Console.WriteLine($"   Short Date: {now.ToShortDateString()}");
            Console.WriteLine($"   Long Date: {now.ToLongDateString()}");
            Console.WriteLine($"   Short Time: {now.ToShortTimeString()}");
            Console.WriteLine($"   Long Time: {now.ToLongTimeString()}");
            Console.WriteLine($"   Custom Format: {now.ToString("yyyy-MM-dd HH:mm:ss")}");

            // Parsing dates from strings
            Console.WriteLine("\n9. Parsing Date and Time:");
            string dateString = "2024-12-31 23:59:59";
            DateTime parsedDate = DateTime.Parse(dateString);
            Console.WriteLine($"   Parsed Date: {parsedDate}");

            // Checking date range
            Console.WriteLine("\n10. Date Comparison:");
            Console.WriteLine($"   Is {customDateTime} earlier than {now}? {customDateTime < now}");
            Console.WriteLine($"   Is {customDateTime} later than {now}? {customDateTime > now}");
            Console.WriteLine($"   Are {customDateTime} and {now} equal? {customDateTime == now}");

            // Static properties
            Console.WriteLine("\n11. Static Properties:");
            Console.WriteLine($"   MinValue: {DateTime.MinValue}");
            Console.WriteLine($"   MaxValue: {DateTime.MaxValue}");
        }
    }
}
