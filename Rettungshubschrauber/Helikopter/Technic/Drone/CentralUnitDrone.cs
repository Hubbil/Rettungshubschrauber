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

    public void startSectionInspection()
    {
        bool condition = false;
        int Iterator = 0;
        while (!condition)
        {
            condition = analyzeSection(Camera.getSection(Iterator));
            Iterator++;
        }
    }
    
    public bool analyzeSection(string[,] searchArea)
    {
        string[] searchGoal = new string[] { "h", "u", "m", "a", "n" };
        int searchState = 0;
        int endOfHumanX;
        int endOfHumanY;
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                
                Console.WriteLine(i + " " + j + " " + searchArea[i,j]);
                if (searchState > 4)
                {
                    Console.WriteLine("Human found");
                    endOfHumanX = i;
                    endOfHumanY = j;
                    extractHuman(endOfHumanX,endOfHumanY,searchArea);
                    return true;
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

        return false;
    }

    public void extractHuman(int i, int j,string[,] searchArea)
    {
        string[,] extraction = new string[11, 7];

        int startX = i - 7;
        int endX = i + 3;
        int startY = j - 3;
        int endY = j + 3;
        int xIterator = 0;
        int yIterator = 0;

        if (startX < 0)
        {
            startX = 0;
        }
        
        if (startY < 0)
        {
            startY = 0;
        }
        
        if (endX > 49)
        {
            endX = 49;
        }
        
        if (endY < 49)
        {
            endY = 49;
        }

        for (int k = startX; k < endX; k++)
        {
            yIterator = 0;
            
            for (int l = startY; l < endY; l++)
            {
                extraction[xIterator, yIterator] = searchArea[k, l];
                yIterator++;
            }

            xIterator++;
        }

        saveExtraction(extraction,startX,startY,searchArea);
    }

    public void saveExtraction(string[,] extraction,int x,int y,string[,] searchArea)
    {
        x = x + 3;
        y = y + 3;
        MemoryCard.save(extraction,x,y,searchArea);
    }
}