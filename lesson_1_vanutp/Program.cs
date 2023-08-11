internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What your name?");

        string name = Console.ReadLine();

        Console.WriteLine(name);

        Console.WriteLine("How old are you&");

        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"You will be {age + 10} in ten yers");
    }
}