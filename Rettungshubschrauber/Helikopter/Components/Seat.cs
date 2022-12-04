using Rettungshubschrauber.Helikopter.Cockpit;
using Rettungshubschrauber.Mensch;

namespace Rettungshubschrauber.Helikopter.Components;

public class Seat
{
    private Worker worker;
    public SeatBelt SeatBelt { get; }

    public Seat()
    {
        SeatBelt = new SeatBelt();
    }

    public void sitDown(Worker worker)
    {
        this.worker = worker;
    }
}