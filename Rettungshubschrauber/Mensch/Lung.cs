namespace Rettungshubschrauber.Mensch;

public class Lung
{
    private LungChamber leftChamber;
    private LungChamber rightChamber;

    public Lung(bool smoker, Covid covid)
    {
        leftChamber = new LungChamber(smoker, covid);
        rightChamber = new LungChamber(smoker, covid);
    }

    public void exhale(Covid covid, bool smoker)
    {
        leftChamber.exhale(covid,smoker);
        rightChamber.exhale(covid,smoker);
    }

    public void inhale()
    {
        leftChamber.inhale();
        rightChamber.inhale();
    }

    public bool checkDeath()
    {
        if (leftChamber.checkDeath() || rightChamber.checkDeath())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}