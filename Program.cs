namespace ConsoleAppInstanceConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Coords();
            Console.WriteLine($"Coords #1 at {p1}");

            var p2 = new Coords(5,3);
            Console.WriteLine($"Coords #2 at {p2}");
        }
    }
}
