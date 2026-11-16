using App;

namespace AppTests;

public class Tests
{
    [Test]
    public void EmptyOrder()
    {
        var shop = new CoffeeShop();
        Assert.That(shop.MakeOrder("").Price == 0);
    }
}