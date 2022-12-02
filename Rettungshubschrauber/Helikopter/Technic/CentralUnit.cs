using Rettungshubschrauber.Helikopter.Cockpit;
using Rettungshubschrauber.Helikopter.Triebwerke;

namespace Rettungshubschrauber.Helikopter.Technic;

public class CentralUnit
{
    private MainRotor _mainRotor;

    private TailRotor _tailRotor;

    public CentralUnit(MainRotor mainRotor, TailRotor tailRotor)
    {
        _mainRotor = mainRotor;
        _tailRotor = tailRotor;
    }

    public void TiltMainRotor(double step, Boolean side)
    {
        if (side)
        {
            _mainRotor.SideTilt = step;
        }
        else
        {
            _mainRotor.Tilt = step;
        }
    }

    public void ChangeBladeTurnAngle(double angle)
    {
        foreach (Blade blade in _mainRotor.Blades)
        {
            blade.TurnAngle = angle;
        }
    }

    public void ChangeTailRotorDirection(Direction direction)
    {
        _tailRotor.RotatioDirection = direction;
    }
}