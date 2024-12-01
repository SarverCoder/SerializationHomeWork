using System.Text;
using System.Text.Json;

namespace SerializationHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order()
            {
                OrderId = 1,
                CostomerName = "Michael",
                TotalAmount = 23,
                Status = Status.Pending,
                orderItem = new OrderItem()
                {
                    ItemName = "VideoCard",
                    Quantity = 10,
                    Price = 450

                }
            };

            var jsonOptions = new JsonSerializerOptions()
            {
                AllowTrailingCommas = false,
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
            };

           


           // Console.WriteLine(text);

            using var memoryStream = new MemoryStream();

            var text = JsonSerializer.Serialize(order, jsonOptions);
            var buffer = Encoding.UTF8.GetBytes(text);
            memoryStream.Write(buffer, 0, buffer.Length);


            string json = Encoding.UTF8.GetString(memoryStream.ToArray());
            Console.WriteLine(json);
            json = json.Replace("\"TotalAmount\": 23", "\"TotalAmount\": 10");


            Console.WriteLine("\n\n");

            var update = JsonSerializer.Deserialize<Order>(json);

            Console.WriteLine("Update order object: ");

            Console.WriteLine($" Id: {update.OrderId}\n Name: {update.CostomerName}\n Total: {update.TotalAmount}\n Status: {update.Status}\n" +
                $"OrderItem : {update.orderItem.ItemName}");





            

        }
    }
}
