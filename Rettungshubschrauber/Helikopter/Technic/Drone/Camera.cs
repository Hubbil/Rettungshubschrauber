namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class Camera
{

    public Section[] searchArea; 
    public string[,] getSection()
    {
        Random r = new Random();
        return searchArea[r.Next(searchArea.Length)].getContent();
    }
}