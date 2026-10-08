namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Generic Vehicle", 100);
            vehicle.Move();
            Bicycle bicycle = new Bicycle("Mountain Bike", 30);
            bicycle.Move();


        }
    }
}
