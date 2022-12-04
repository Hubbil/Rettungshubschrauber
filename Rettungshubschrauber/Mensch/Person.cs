using Microsoft.VisualBasic;

namespace Rettungshubschrauber.Mensch;

public class Person
{
    private string name;
    private string firstname;
    private Gender gender;
    private DateTime birthday;
    private bool smoker;
    private bool vaccinated;
    private Lung lung;
    private Covid covid;

    public Person(string name,string firstname, Gender gender, DateTime date)
    {
        this.name = name;
        this.firstname = firstname;
        this.gender = gender;
        birthday = date;
        Random random = new Random();
        int c = random.Next(1, 2);
        if (c == 1)
        {
            smoker = true;
        }
        else
        {
            smoker = false;
        }
        c = random.Next(1, 2);
        if (c == 1)
        {
            vaccinated = true;
        }
        else
        {
            vaccinated = false;
        }c = random.Next(1, 4);
        switch (c)
        {
            case 0:
                covid = Covid.S0;
                break;
            case 1:
                covid = Covid.S1;
                break;
            case 2:
                covid = Covid.S2;
                break;
            default:
                covid = Covid.S3;
                break;
        }

        lung = new Lung(smoker,covid);
    }

    public void exhale()
    {
        lung.exhale(covid,smoker);
    }

    public void inhale()
    {
        lung.inhale();
    }

    public void checkDeath()
    {
        if (lung.checkDeath())
        {
            Console.WriteLine(firstname + " " + name + " has died.");
        }
    }

    public void breath()
    {
        inhale();
        exhale();
        checkDeath();
    }
}