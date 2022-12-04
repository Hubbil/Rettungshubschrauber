namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class MemoryCard
{
    private List<Saved> savedPeople = new List<Saved>();

    public void save(string[,] extraction,int x,int y,string[,] searchArea)
    {
        savedPeople.Add(new Saved(searchArea,extraction,x,y));
    }

}