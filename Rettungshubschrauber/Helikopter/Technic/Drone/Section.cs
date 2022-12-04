namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class Section
{
    public string[,] Content { get; set; }

    public Section()
    {
        Content = new string[50, 50];
    }
    
    public string[,] getContent()
    {
        return Content;
    }
}