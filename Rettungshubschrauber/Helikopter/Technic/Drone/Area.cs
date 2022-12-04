using System.Diagnostics;

namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class Area
{
    public string[,] Content { get; set; }
    
    public Section[] Sections { get; set; }

    private string[] AreaContent = { "a", "g", "h", "m", "n", "t", "u", "w" };

    public Area()
    {
        Random r = new Random();
        Content = new string[500, 500];

        for (int i = 0; i < 500; i++)
        {
            for (int j = 0; j < 500; j++)
            {
                Content[i,j] = AreaContent[r.Next(AreaContent.Length)];
            }
        }

        Sections = new Section[100];
        int t = 0;
        for (int i = 0; i < 500; i++)
        {
            for (int j = 0; j < 500; j++)
            {
                switch (i)
                {
                    case < 50:
                        switch (j)
                        {
                            case < 50:
                                for (int k = 0; k < 50; k++)
                                {
                                    for (int l = 0; l < 50; l++)
                                    {
                                        Sections[0].Content[k, l] = Content[i, j];
                                    }
                                }

                                break;
                            
                        }

                        break;
                }
            }
        }
    }
}