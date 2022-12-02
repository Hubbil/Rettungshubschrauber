using Rettungshubschrauber.Helikopter.Technic;
using Rettungshubschrauber.Helikopter.Triebwerke;

namespace Rettungshubschrauber.Helikopter.Cockpit;

public class AntiTorguePadel
{
    private CentralUnit _unit;

    private Position _position;

    public AntiTorguePadel(CentralUnit centralUnit, Position position)
    {
        _unit = centralUnit;
        _position = position;
    }

    public void Push()
    {
        if (_position == Position.Left)
        {
            _unit.ChangeTailRotorDirection(Direction.LEFT);
        }
        else
        {
            _unit.ChangeTailRotorDirection(Direction.RIGHT);
        }
    }

    public void StopPushing()
    {
        _unit.ChangeTailRotorDirection(Direction.NONE);
    }
}