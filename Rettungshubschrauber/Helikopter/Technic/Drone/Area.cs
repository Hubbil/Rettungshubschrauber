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
        for (int i = 0; i < 100; i++)
        {
            Sections[i] = new Section();
        }
        for (int m = 0; m < 100; m++)
        {
            int t = m % 10;
            int h = m - t;

            int iMax = 0;
            int iStart = 0;
            int jStart = 0;
            int jMax = 0;
            switch (t)
            {
                case 0:
                    iStart = 0;
                    iMax = 49;
                    break;
                case 1:
                    iStart = 50;
                    iMax = 99;
                    break;
                case 2:
                    iStart = 100;
                    iMax = 149;
                    break;
                case 3:
                    iStart = 150;
                    iMax = 199;
                    break;
                case 4:
                    iStart = 200;
                    iMax = 249;
                    break;
                case 5:
                    iStart = 250;
                    iMax = 299;
                    break;
                case 6:
                    iStart = 300;
                    iMax = 349;
                    break;
                case 7:
                    iStart = 350;
                    iMax = 399;
                    break;
                case 8:
                    iStart = 400;
                    iMax = 449;
                    break;
                case 9:
                    iStart = 450;
                    iMax = 499;
                    break;
            }

            switch (h)
            {
                case 0:
                    jStart = 0;
                    jMax = 49;
                    break;
                case 1:
                    jStart = 50;
                    jMax = 99;
                    break;
                case 2:
                    jStart = 100;
                    jMax = 149;
                    break;
                case 3:
                    jStart = 150;
                    jMax = 199;
                    break;
                case 4:
                    jStart = 200;
                    jMax = 249;
                    break;
                case 5:
                    jStart = 250;
                    jMax = 299;
                    break;
                case 6:
                    jStart = 300;
                    jMax = 349;
                    break;
                case 7:
                    jStart = 350;
                    jMax = 399;
                    break;
                case 8:
                    jStart = 400;
                    jMax = 449;
                    break;
                case 9:
                    jStart = 450;
                    jMax = 499;
                    break;
            }

            int SectionI = 0;
            int SectionJ = 0;
            for (int i = iStart; i <= iMax; i++)
            {
                SectionJ = 0;
                for (int j = jStart; j <= jMax; j++)
                {
                    Sections[m].Content[SectionI,SectionJ] = Content[i, j];
                    SectionJ++;
                }

                SectionI++;
            }
        }
        InsertHuman();
    }

    private void InsertHuman()
    {
        Random r = new Random();
        int RandomSection = r.Next(0, 99);
        int RandomRow = r.Next(0, 49);
        int RandomColumn = r.Next(0, 45);

        Sections[RandomSection].Content[RandomRow, RandomColumn] = "h";
        Sections[RandomSection].Content[RandomRow, RandomColumn + 1] = "u";
        Sections[RandomSection].Content[RandomRow, RandomColumn + 2] = "m";
        Sections[RandomSection].Content[RandomRow, RandomColumn + 3] = "a";
        Sections[RandomSection].Content[RandomRow, RandomColumn + 4] = "n";
    }

    public Section[] getSections()
    {
        return Sections;
    }
}