using System;

namespace QueryingResourceHealthAzure
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = SubscriptionHelper.GetSubscriptionResources().GetAwaiter().GetResult();
            Console.WriteLine(response);

            Console.ReadLine();
        }
    }
}
