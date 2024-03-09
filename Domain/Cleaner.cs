namespace Domain;

public interface ICleaner
{
    
}

public class Cleaner : ICleaner
{
    public Cleaner(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    
    public int Id { get; set; }
}