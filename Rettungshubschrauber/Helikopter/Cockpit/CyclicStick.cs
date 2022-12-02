using Rettungshubschrauber.Helikopter.Triebwerke;

namespace Rettungshubschrauber.Helikopter.Cockpit;

public class CyclicStick
{
    private MainRotor _mainRotor;
    public CyclicStick()
    {
        
    }

    //intensity could be a natural number between 1 and 25
    public void MoveForward(int intensity)
    {
        double RotorTilt = intensity / 10;
        if (_mainRotor.Tilt + RotorTilt > 2.5)
        {
            _mainRotor.Tilt = 2.5;
        }
        else
        {
            _mainRotor.Tilt += RotorTilt;
        }
    }

    public void MoveBack(int intensity)
    {
        double RotorTilt = intensity / 10;
        if (_mainRotor.Tilt + RotorTilt < 0)
        {
            _mainRotor.Tilt = 0;
        }
        else
        {
            _mainRotor.Tilt -= RotorTilt;
        }
    }

    public void MoveLeft(int intensity)
    {
        double RotorTilt = intensity / 10;
        if (_mainRotor.SideTilt + RotorTilt < -2.5)
        {
            _mainRotor.SideTilt = -2.5;
        }
        else
        {
            _mainRotor.SideTilt -= RotorTilt;
        }
    }

    public void MoveRight(int intensity)
    {
        double RotorTilt = intensity / 10;
        if (_mainRotor.SideTilt + RotorTilt > 2.5)
        {
            _mainRotor.SideTilt = 2.5;
        }
        else
        {
            _mainRotor.SideTilt += RotorTilt;
        }
    }
    
}