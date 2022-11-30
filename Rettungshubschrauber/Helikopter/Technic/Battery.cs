using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Rettungshubschrauber.Helikopter.Technic;

public class Battery
{
    private BatteryCell[,,] Cells { get; set; }

    public Battery()
    {
        Cells = new BatteryCell[250, 100, 50];
        for (int i = 0; i < 250; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 50; k++)
                {
                    Cells[i, j, k] = new BatteryCell();
                }
            }
        }
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
        int counter = 0;
        
        for (int i = 0; i < 250; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 50; k++)
                {
                    if (Cells[i, j, k].Loaded)
                    {
                        Cells[i, j, k].Loaded = false;
                        counter++;
                        if (counter == amount)
                        {
                            goto Here;
                        }
                    }
                }
            }
        }

        Here:
        int c = 1;
    }


    public int GetLoadedCells()
    {
        int counter = 0;
        for (int i = 0; i < 250; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 50; k++)
                {
                    if (Cells[i, j, k].Loaded)
                    {
                        counter++;
                    }
                }
            }
        }

        return counter;
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