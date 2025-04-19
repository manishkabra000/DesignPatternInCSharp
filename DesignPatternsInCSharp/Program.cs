using DesignPatternsInCSharp.Creational;
using DesignPatternsInCSharp.Behavioral;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===Design Patterns in C#===\n");

        #region SingleTon Design Pattern
        //Testing Singleton
        var s1 = SingleTon.Instance;
        var s2 = SingleTon.Instance;

        s1.DoSomething();

        Console.WriteLine($"Same instance? {ReferenceEquals(s1, s2)}");
        #endregion

        var objShoppingCart = new ShoppingCart(new CreditCardPayment());
        objShoppingCart.Checkout(1200);
    }
}