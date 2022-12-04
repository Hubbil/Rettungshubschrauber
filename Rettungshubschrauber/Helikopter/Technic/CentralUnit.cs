using Rettungshubschrauber.Helikopter.Cockpit;
using Rettungshubschrauber.Helikopter.Triebwerke;

namespace Rettungshubschrauber.Helikopter.Technic;

public class CentralUnit
{
    private Helikopter _helikopter;

    public CentralUnit()
    {
        
    }

    public void SetHeli(Helikopter heli)
    {
        _helikopter = heli;
    }

    public void TiltMainRotor(double step, Boolean side)
    {
        if (side)
        {
            _helikopter.MainRotor.SideTilt = step;
        }
        else
        {
            _helikopter.MainRotor.Tilt = step;
        }
    }

    public void ChangeBladeTurnAngle(double angle)
    {
        foreach (Blade blade in _helikopter.MainRotor.Blades)
        {
            blade.TurnAngle = angle;
        }
    }

    public void ChangeTailRotorRpm(int RPM)
    {
        _helikopter.TailRotor.RPM += RPM;
    }

    public void ActivateMainRotor()
    {
        _helikopter.MainRotor.Engine.On();
        _helikopter.MainRotor.RPM = 600;
    }
    
    public void DeactivateMainRotor()
    {
        _helikopter.MainRotor.Engine.Off();
        _helikopter.MainRotor.RPM = 0;
    }
    
    public void ActivateTailRotor()
    {
        _helikopter.TailRotor.Engine.On();
        _helikopter.TailRotor.RPM = 600;
    }
    
    public void DeactivateTailRotor()
    {
        _helikopter.TailRotor.Engine.Off();
        _helikopter.TailRotor.RPM = 0;
    }

    public void ActivateAntiCollisionLight()
    {
        _helikopter.AntiCollisionLight.IsOn = true;
    }
    
    public void DeActivateAntiCollisionLight()
    {
        _helikopter.AntiCollisionLight.IsOn = false;
    }

    public void ActivateLandingLight()
    {
        _helikopter.LandingLight.IsOn = true;
    }
    
    public void DeactivateLandingLight()
    {
        _helikopter.LandingLight.IsOn = false;
    }

    public void LockBackDoors()
    {
        if (_helikopter.Cabin.LeftDoor.closed)
        {
            _helikopter.Cabin.LeftDoor.Locked = true;
        }
        if (_helikopter.Cabin.RightDoor.closed)
        {
            _helikopter.Cabin.RightDoor.Locked = true;
        }
    }
    
    public void UnlockBackDoors()
    {
        _helikopter.Cabin.RightDoor.Locked = false;
        _helikopter.Cabin.LeftDoor.Locked = false;
    }

    public void ReleaseDrone()
    {
        _helikopter.DroneLug.Drone = null;
    }

    public void Stop()
    {
        DeactivateMainRotor();
        DeactivateTailRotor();
        DeactivateLandingLight();
        DeActivateAntiCollisionLight();
    }
}