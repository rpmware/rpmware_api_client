using System;
using System.Collections;
using RPMWare.Api.Client.RPMWareOrder;

namespace RPMWare.Api.Client
{
    /// <summary>
    ///     This is a quick implementation of a RPMWare API client application.
    ///     It shows how to connect to the RPMWare API and retrieve a list of orders. While the code here works,
    ///     it IS NOT INTENDED FOR PRODUCTION USE. PLEASE REVIEW ALL THE CODE CONTAINED IN THIS PROJECT BEFORE
    ///     USING IT FOR MISSION CRITICAL BUSINESS APPLICATIONS.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            var apiKey = UserService.GetApiKey();

            var service = new Order();
            Console.WriteLine("Calling Order Service at: {0}", service.Url);
            Result result = service.GetOrdersSinceLastOrderId(apiKey, 25000);

            if (result.Success == "SUCCESS")
            {
                foreach (Order1 order in (IEnumerable) result.Data)
                {
                    Console.WriteLine(order.Customer.AccountName);

                    foreach (OrderLineItem orderLineItem in order.LineItems)
                    {
                        Console.WriteLine(orderLineItem.PartNumber);
                    }

                    Console.WriteLine("======================================================");
                }

                Console.ReadLine();
            }
        }
    }
}
