namespace Rettungshubschrauber.Mensch;

public class Paramedic : Worker
{
    public Paramedic(IDCard card, string name, string firstname, string personalNumber, DateTime date)
    {
        this.card = card;
        this.name = name;
        this.firstname = firstname;
        this.personalNumber = personalNumber;
        birthday = date;
        this.card = card;
    }
}