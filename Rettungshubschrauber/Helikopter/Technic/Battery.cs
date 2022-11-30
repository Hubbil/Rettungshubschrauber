using System.Text.Json.Serialization;

namespace Rettungshubschrauber.Helikopter.Technic;

public class Battery
{
    private BatteryCell[,,] Cells { get; set; }

    public Battery()
    {
        Cells = new BatteryCell[250, 100, 50];
    }

    public void charge()
    {
        foreach (BatteryCell cell in Cells)
        {
            cell.Loaded = true;
        }
    }

    public void discharge(int amount)
    {
        int[] Coordinates = GetFirstLoadedCell();
        
        for (int i = 0; i < 250; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 50; k++)
                {
                    
                }
            }
        }
    }

    private int[] GetFirstLoadedCell()
    {
        int[] Coordinates = new int[3];
        for (int i = 0; i < 250; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 50; k++)
                {
                    if (Cells[i, j, k].Loaded)
                    {
                        Coordinates[0] = i;
                        Coordinates[1] = j;
                        Coordinates[2] = k;
                        break;
                    }
                }
            }
        }

        return Coordinates;
    }
}