namespace Rettungshubschrauber.Mensch;

public class PilotIDCard :  IDCard , IIDCard
{

    private Permit permit;
    private DateTime expirationDatePermit;
    private char permitType;

    public PilotIDCard(int pin, Permit permit)
    {
        Random random = new Random();
        this.pin = pin;
        this.permit = permit;
        expirationDatePermit = new DateTime(random.Next(2023, 2026), random.Next(1, 12), random.Next(1, 28));
        char[] types = new char[3] { 'A', 'B', 'C' };
        permitType = types[random.Next(types.Length)];
    }
    
}