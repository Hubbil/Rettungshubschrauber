namespace Rettungshubschrauber.Helikopter.Technic;

public class EnergyUnit
{
    public Battery[] Batteries { get; set; }

    public EnergyUnit()
    {
        Batteries = new Battery[2];
        Batteries[0] = new Battery();
        Batteries[1] = new Battery();
    }

    public void TakeEnergy(int amount)
    {
        int amount1;
        int amount2;
        if (amount % 2 == 0)
        {
            amount1 = amount / 2;
            amount2 = amount / 2;
        }
        else
        {
            amount1 = (amount + 1) / 2;
            amount2 = (amount - 1) / 2;
        }

        if (Batteries[0].GetLoadedCells() >= Batteries[1].GetLoadedCells())
        {
            Batteries[0].discharge(amount1);
            Batteries[1].discharge(amount2);
        }
        else
        {
            Batteries[0].discharge(amount2);
            Batteries[1].discharge(amount1);
        }
    }

    public int GetAvailableEnergyAmount()
    {
        int amount = Batteries[0].GetLoadedCells() + Batteries[1].GetLoadedCells();

        return amount;
    }
}