using Rettungshubschrauber.Helikopter.Technic;
using Rettungshubschrauber.Helikopter.Triebwerke;

namespace Rettungshubschrauber.Helikopter.Cockpit;

public class CollectivePitchControl
{
    private CentralUnit Unit;

    private static int[] steps = { 0, 1, 2 };

    public CollectivePitchControl(CentralUnit centralUnit)
    {
        Unit = centralUnit;
    }

    public void activate(int step)
    {
        if (steps.Contains(step))
        {
            switch (step)
            {
                case 0:
                    Unit.ChangeBladeTurnAngle(0);

                    break;

                case 1:
                    Unit.ChangeBladeTurnAngle(15);

                    break;

                case 2:
                    Unit.ChangeBladeTurnAngle(-15);

                    break;
            }
        }
        else
        {
            Console.WriteLine($@"{step} ist keine Valide Stufe!");
        }

    }
}