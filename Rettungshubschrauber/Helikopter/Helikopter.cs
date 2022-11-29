namespace Rettungshubschrauber.Helikopter;

public class Helikopter
{
    
    public string Id { get; }
    
    public string Type { get; }
    
    public string Uuid { get; }

    public Helikopter()
    {
        Id = "D-MGHX";
        Type = "M145";
        Guid t = Guid.NewGuid();
        Uuid = t.ToString();
    }
    
}