namespace Rettungshubschrauber.Mensch;

public class LungChamber
{
    private Cell[,] chamber;

    public LungChamber(bool smoker, Covid covid)
    {
        chamber = new Cell[50, 20];
        
        if (smoker)
        {
            setupSmoker();
        }

        setupCovid(covid);
    }

    public void setupSmoker()
    {
        Random random1 = new Random();
        Random random2 = new Random();

        int i = 0;
        int j = 0;

        for (int k = 0; k < 200; k++)
        {
            i = random1.Next(0, 49);
            j = random2.Next(0, 19);

            if (chamber[i, j].getState() != 'I')
            {
                    chamber[i,j].setState('I');
            }
            else
            {
                k--;
            }
        }
    }

    public void setupCovid(Covid covid)
    {
        int length = 0;
        switch (covid)
        {
            case Covid.S0:
                length = 30;
                break;
            case Covid.S1:
                length = 50;
                break;
            case Covid.S2:
                length = 100;
                break;
            default:
                length = 150;
                break;
        }
        
        Random random1 = new Random();
        Random random2 = new Random();

        int i = 0;
        int j = 0;

        for (int k = 0; k < length; k++)
        {
            i = random1.Next(0, 49);
            j = random2.Next(0, 19);

            if (chamber[i, j].getState() != 'I')
            {
                chamber[i,j].setState('I');
            }
            else
            {
                k--;
            }
        }
        
    }

    public void inhale()
    {
        int inhaledOxygen = 0;
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (chamber[i, j].getState() == 'H')
                {
                    chamber[i,j].swap();
                    inhaledOxygen++;
                }
            }
        }

        Console.WriteLine("Inhaled oxygen: " + inhaledOxygen);
    }

    public void exhale(Covid covid, bool smoker)
    {
        int carbonDioxide = 0;
        for (int l = 0; l < 50; l++)
        {
            for (int p = 0; p < 20; p++)
            {
                if (chamber[l, p].getState() == 'H')
                {
                    chamber[l,p].swap();
                    carbonDioxide++;
                }
            }
        }

        Console.WriteLine("Exhaled carbon dioxide: " + carbonDioxide);
        
        int length = 0;
        switch (covid)
        {
            case Covid.S0:
                if (smoker)
                {
                    length = 20;
                }
                else
                {
                    length = 40;
                }

                break;
            case Covid.S1:
                if (smoker)
                {
                    length = 30;
                }
                else
                {
                    length = 60;
                }

                break;
            case Covid.S2:
                if (smoker)
                {
                    length = 60;
                }
                else
                {
                    length = 100;
                }

                break;
            default:
                if (smoker)
                {
                    length = 100;
                }
                else
                {
                    length = 150;
                }

                break;
        }
        
        Random random1 = new Random();
        Random random2 = new Random();

        int i = 0;
        int j = 0;
        
        for (int k = 0; k < length; k++)
        {
            i = random1.Next(0, 49);
            j = random2.Next(0, 19);

            if (chamber[i, j].getState() != 'I')
            {
                chamber[i,j].setState('I');
            }
            else
            {
                k--;
            }
        }
    }

    public bool checkDeath()
    {
        int infectedCells = 0;
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (chamber[i, j].getState() == 'I')
                {
                    infectedCells++;
                }
            }
        }

        if (infectedCells < 650)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}