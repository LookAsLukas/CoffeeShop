using App;

namespace AppTests;

public class OrderTests
{
    [Test]
    public void ToString_ReturnsFormattedString()
    {
        var order = new Order(Guid.NewGuid(), 100, new[] { "Espresso", "Espresso", "Espresso" });
        var expected = """
            Espresso 100
            Espresso 100
            Espresso 100
            """;
        Assert.That(order.ToString(), Is.EqualTo(expected));
    }
}
