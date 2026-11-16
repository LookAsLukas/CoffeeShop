namespace App;

public record Order(Guid Id, double Price, string[] Names)
{
    public static Order Empty = new(Guid.NewGuid(), 0, []);
}