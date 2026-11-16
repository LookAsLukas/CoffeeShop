namespace App;

public class CoffeeShop
{
    public Order MakeOrder(string name) => name switch
    {
        "Espresso" => new Order(Guid.NewGuid(), 100, name),
        _ => Order.Empty
    };
}