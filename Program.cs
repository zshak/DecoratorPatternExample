
namespace DecoratorPatternExample;

abstract class Cart
{
    public abstract int Cost();
}


abstract class Items : Cart
{
    public abstract override int Cost();
}

class Shirt : Items 
{
    private readonly Cart cart;
    public Shirt(Cart cart)
    {
        this.cart = cart;
    }
    public override int Cost()
    {
        return this.cart.Cost() + 2;
    }
}

class Trousers : Items
{
    private readonly Cart cart;

    public Trousers(Cart cart)
    {
        this.cart = cart;
    }
    public override int Cost()
    {
        return this.cart.Cost() + 3;
    }
}

class ShoppingCart : Cart
{
    public override int Cost()
    {
        return 1;
    }
}
class Program
{
    static int Main(string[] args)
    {
        Console.WriteLine(new Trousers(new Shirt(new ShoppingCart())).Cost());
        Console.WriteLine(new Shirt(new ShoppingCart()).Cost());
        return 0;
    }
}