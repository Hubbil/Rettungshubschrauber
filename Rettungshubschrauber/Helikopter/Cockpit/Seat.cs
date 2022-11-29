namespace Rettungshubschrauber.Helikopter.Cockpit;

public class Seat
{
    public SeatBelt SeatBelt { get; }

    public Seat()
    {
        SeatBelt = new SeatBelt();
    }
}