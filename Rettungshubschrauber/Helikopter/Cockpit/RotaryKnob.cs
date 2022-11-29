namespace Rettungshubschrauber.Helikopter.Cockpit;

public class RotaryKnob
{
    public string State { get; set; }

    public void turn(String state)
    {
        State = state;
    }
}