using System.Text;
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
        WriteIntoCsv("TiltMainRotor");
    }

    public void ChangeBladeTurnAngle(double angle)
    {
        foreach (Blade blade in _helikopter.MainRotor.Blades)
        {
            blade.TurnAngle = angle;
        }
        WriteIntoCsv("ChangeBladeTurnAngle");
    }

    public void ChangeTailRotorRpm(int RPM)
    {
        _helikopter.TailRotor.RPM += RPM;
        WriteIntoCsv("ChangeTailRotorRpm");
    }

    public void ActivateMainRotor()
    {
        _helikopter.MainRotor.Engine.On();
        _helikopter.MainRotor.RPM = 600;
        WriteIntoCsv("ActivateMainRotor");
    }
    
    public void DeactivateMainRotor()
    {
        _helikopter.MainRotor.Engine.Off();
        _helikopter.MainRotor.RPM = 0;
        WriteIntoCsv("DeactivateMainRotor");
    }
    
    public void ActivateTailRotor()
    {
        _helikopter.TailRotor.Engine.On();
        _helikopter.TailRotor.RPM = 600;
        WriteIntoCsv("ActivateTailRotor");
    }
    
    public void DeactivateTailRotor()
    {
        _helikopter.TailRotor.Engine.Off();
        _helikopter.TailRotor.RPM = 0;
        WriteIntoCsv("DeactivateTailRotor");
    }

    public void ActivateAntiCollisionLight()
    {
        _helikopter.AntiCollisionLight.IsOn = true;
        WriteIntoCsv("ActivateAntiCollisionLight");
    }
    
    public void DeActivateAntiCollisionLight()
    {
        _helikopter.AntiCollisionLight.IsOn = false;
        WriteIntoCsv("DeActivateAntiCollisionLight");
    }

    public void ActivateLandingLight()
    {
        _helikopter.LandingLight.IsOn = true;
        WriteIntoCsv("ActivateLandingLight");
    }
    
    public void DeactivateLandingLight()
    {
        _helikopter.LandingLight.IsOn = false;
        WriteIntoCsv("DeactivateLandingLight");
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
        WriteIntoCsv("LockBackDoors");
    }
    
    public void UnlockBackDoors()
    {
        _helikopter.Cabin.RightDoor.Locked = false;
        _helikopter.Cabin.LeftDoor.Locked = false;
        WriteIntoCsv("UnlockBackDoors");
    }

    public void ReleaseDrone()
    {
        _helikopter.DroneLug.Drone = null;
        WriteIntoCsv("ReleaseDrone");
    }

    public void Stop()
    {
        DeactivateMainRotor();
        DeactivateTailRotor();
        DeactivateLandingLight();
        DeActivateAntiCollisionLight();
        WriteIntoCsv("Stop");
    }

    private void WriteIntoCsv(string action)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(action);
        string TimeStamp = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
        sb.Append(" ");
        sb.Append(TimeStamp);
        Console.WriteLine(sb.ToString());
        StringBuilder filepath = new StringBuilder();
        filepath.Append(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()));
        filepath.Append("/flight_recorder.txt");
        Console.WriteLine(filepath.ToString());
        File.WriteAllText(filepath.ToString(),sb.ToString());
    }
}