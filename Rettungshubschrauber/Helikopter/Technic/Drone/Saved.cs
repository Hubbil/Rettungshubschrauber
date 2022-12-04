namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class Saved
{
    private string timestamp;
    private string[,] section;
    private string[,] picture;
    private int xKoordinate;
    private int yKoordinate;

    public Saved(string[,] Section, string[,] Picture, int x, int y)
    {
        timestamp = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        section = Section;
        picture = Picture;
        xKoordinate = x;
        yKoordinate = y;
    }
}