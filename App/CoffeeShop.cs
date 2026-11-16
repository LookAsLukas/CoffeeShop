namespace App;

public class CoffeeShop
{
    public Order MakeOrder(string name) => new Order(0, 0.0, name);
}