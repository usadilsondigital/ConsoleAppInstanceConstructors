namespace ConsoleAppInstanceConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.5;
            double height = 3.0;
            
            var ring = new Circle(radius);
            Console.WriteLine($"Area of the Circle{ring.Area():F3}");



            var p1 = new Coords();
            Console.WriteLine($"Coords #1 at {p1}");

            var p2 = new Coords(5,3);
            Console.WriteLine($"Coords #2 at {p2}");
        }
    }
}
