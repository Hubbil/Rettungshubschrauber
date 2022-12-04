using System.Security.AccessControl;

namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class Camera
{

    public Section[] searchArea;

    public Camera(Section[] searchArea)
    {
        this.searchArea = searchArea;
    }
    public string[,] getSection()
    {
        Random r = new Random();
        return searchArea[0].Content;
    }
}