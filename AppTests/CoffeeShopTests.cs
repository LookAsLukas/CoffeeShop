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

    [TestCase("Esspresso")]
    public void MakeOrder_HasPrice_WhenNameIsPassed(string name)
    {
        var shop = new CoffeeShop();
        Assert.That(shop.MakeOrder(name).Price, Is.EqualTo(100));
    }
}