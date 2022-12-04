using Rettungshubschrauber.Helikopter.Technic;
using Rettungshubschrauber.Helikopter.Triebwerke;

namespace Rettungshubschrauber.Helikopter.Cockpit;

public class CyclicStick
{
    private CentralUnit Unit;

    private static double[] steps = {0, 1, 2, 3, 4, 5};
    public CyclicStick(CentralUnit centralUnit)
    {
        Unit = centralUnit;
    }
    
    public void MoveVertical(int step)
    {
        if (steps.Contains(step))
        {
            Unit.TiltMainRotor(step, false);
        }
        else
        {
            Console.WriteLine($@"{step} ist keine valide Stufe!");
        }
    }

    public void MoveHorizontal(double step, Direction direction)
    {
        if (steps.Contains(step))
        {
            double angle = step / 2;
            if (direction == Direction.LEFT)
            {
                angle = -angle;
            }

            Unit.TiltMainRotor(angle, true);
        }
        else
        {
            Console.WriteLine($@"{step} ist keine valide Stufe!");
        }
    }
}