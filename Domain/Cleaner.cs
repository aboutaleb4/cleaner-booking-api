namespace Domain;

public interface ICleaner
{
    
}

public class Cleaner : ICleaner
{
    public Cleaner(int id, string name)
    {
        Name = name;
        Id = id;
    }
    public string Name { get; set; }
    
    public int Id { get; set; }
}