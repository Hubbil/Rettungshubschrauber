namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class CentralUnitDrone
{
    public CentralUnit unit;
    
    public MemoryCard MemoryCard { get; set; }
    
    public Camera Camera { get; set; }

    public CentralUnitDrone(CentralUnit unit,Camera cam)
    {
        this.unit = unit;
        MemoryCard = new MemoryCard();
        Camera = cam;
    }

    public void sendSection()
    {
        analyzeSection(Camera.getSection());
    }
    
    public void analyzeSection(string[,] searchArea)
    {
        string[] searchGoal = new string[] { "h", "u", "m", "a", "n" };
        int searchState = 0;
        int endOfHumanX;
        int endOfHumanY;
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                if (searchState > 4)
                {
                    Console.WriteLine("Human found");
                    endOfHumanX = i;
                    endOfHumanY = j;
                    extractHuman(endOfHumanX,endOfHumanY);
                    return;
                }
                if (searchArea[i, j].Equals(searchGoal[searchState]))
                {
                    searchState++;
                }
                else
                {
                    searchState = 0;
                }
            }
        }
    }

    public void extractHuman(int i, int j)
    {
        string[,] extraction = new string[11, 7];

        int startX = i - 7;
        int endX = i + 3;
        int startY = j - 3;
        int endY = j + 3;
    }
}