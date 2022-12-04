namespace Rettungshubschrauber.Mensch;

public class Pilot : Worker
{
    public Pilot(PilotIDCard card, string name, string firstname, string personalNumber, DateTime date)
    {
        this.card = card;
        this.name = name;
        this.firstname = firstname;
        this.personalNumber = personalNumber;
        birthday = date;
        this.card = card;
    }
}