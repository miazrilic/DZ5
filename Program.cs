namespace DZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee espressoCoffee = new Espresso();
            Coffee espressoWithMilk = new Milk(new Espresso());
            Console.WriteLine($"{espressoCoffee.GetDescription()} = {espressoCoffee.GetCost()} $");
            Console.WriteLine($"{espressoWithMilk.GetDescription()} = {espressoWithMilk.GetCost()} $");






        }
    }
}