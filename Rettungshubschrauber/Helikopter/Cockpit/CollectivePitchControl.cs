using Rettungshubschrauber.Helikopter.Triebwerke;

namespace Rettungshubschrauber.Helikopter.Cockpit;

public class CollectivePitchControl
{
    private MainRotor _mainRotor;

    public CollectivePitchControl()
    {
        
    }

    public void pull(int step)
    {
        switch (step)
        {
            case 0:
                foreach (Blade blade in _mainRotor.Blades)
                {
                    blade.TurnAngle = 0;
                }

                break;
            
            case 1:
                foreach (Blade blade in _mainRotor.Blades)
                {
                    blade.TurnAngle = 1;
                }

                break;
            
            case 2:
                foreach (Blade blade in _mainRotor.Blades)
                {
                    blade.TurnAngle = 2;
                }

                break;
            
            case 3:
                foreach (Blade blade in _mainRotor.Blades)
                {
                    blade.TurnAngle = 3;
                }

                break;
            
            case 4:
                foreach (Blade blade in _mainRotor.Blades)
                {
                    blade.TurnAngle = 4;
                }

                break;
            
            case 5:
                foreach (Blade blade in _mainRotor.Blades)
                {
                    blade.TurnAngle = 5;
                }

                break;
            
            case 6:
                foreach (Blade blade in _mainRotor.Blades)
                {
                    blade.TurnAngle = 6;
                }

                break;
            
            case 7:
                foreach (Blade blade in _mainRotor.Blades)
                {
                    blade.TurnAngle = 7;
                }

                break;
        }

    }

    public void push(int step)
    {
        
    }
}