using Rettungshubschrauber.Helikopter.Cockpit;

namespace Rettungshubschrauber.Helikopter.Components;

public class Seat
{
    public SeatBelt SeatBelt { get; }

    public Seat()
    {
        SeatBelt = new SeatBelt();
    }
}