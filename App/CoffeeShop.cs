namespace App;

public class CoffeeShop
{
    public Order MakeOrder(params string[] names) => names switch
    {
        ["Espresso"] => new Order(Guid.NewGuid(), 100, names),
        ["Espresso", "Espresso", "Espresso"] => new Order(Guid.NewGuid(), 300, names),
        _ => Order.Empty
    };
}