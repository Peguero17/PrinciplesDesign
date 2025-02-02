
namespace KISS
{
    class program
    {
        public class RestaurantBill
        {
            public decimal CalculateTotal(decimal[] prices, decimal? tipPercentage)
            {
                decimal total = prices.Sum();

                if (tipPercentage.HasValue)
                {
                    total += total * (tipPercentage.Value / 100);
                    return total;
                }
                total += total * 0.10m;
                return total;
            }
        }
        static void Main(string[] args)
        {
            RestaurantBill restaurantBill = new RestaurantBill();

            Console.Write("Ingrese los precios de los platos (separados por comas): ");
            string input = Console.ReadLine();

            decimal[] prices = input.Split(',').Select(s => decimal.Parse(s.Trim())).ToArray();

            Console.Write("Ingrese el porcentaje de propina (o presione Enter para omitir): ");
            string tipInput = Console.ReadLine();

            decimal? tipPercentage = string.IsNullOrWhiteSpace(tipInput) ? null : decimal.Parse(tipInput);

            Console.WriteLine("Total a pagar: " + restaurantBill.CalculateTotal(prices, tipPercentage));
        }
    }
}
