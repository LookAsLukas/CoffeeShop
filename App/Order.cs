namespace App;

public record Order(Guid Id, double Price, string Name)
{
    public static Order Empty = new(Guid.NewGuid(), 0, "");
}