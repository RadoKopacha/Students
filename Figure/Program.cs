namespace Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle:");
            Circle circle = new Circle();
            circle.Radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");

        }
    }
}
