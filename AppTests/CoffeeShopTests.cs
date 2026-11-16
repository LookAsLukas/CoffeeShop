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

    [TestCase(new[] { "Espresso" }, 100)]
    [TestCase(new[] { "Espresso", "Espresso", "Espresso" }, 300)]
    [TestCase(new[] { "Latte", "Espresso", "Kruassan" }, 420)]
    [TestCase(new[] { "Espresso", "Cappucciono", "Latte" }, 450)]
    [TestCase(new[] { "Latte", "Latte", "Latte" }, 200)]
    public void MakeOrder_HasPrice_WhenNameIsPassed(string[] names, double expectedPrice)
    {
        var shop = new CoffeeShop();
        Assert.That(shop.MakeOrder(names).Price, Is.EqualTo(expectedPrice));
    }
}