using DesignPatternsInCSharp.Creational;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===Design Patterns in C#===\n");

        //Testing Singleton
        var s1 = SingleTon.Instance;
        var s2 = SingleTon.Instance;

        s1.DoSomething();

        Console.WriteLine($"Same instance? {ReferenceEquals(s1, s2)}");
    }
}