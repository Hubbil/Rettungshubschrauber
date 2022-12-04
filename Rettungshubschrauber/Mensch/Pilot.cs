using Rettungshubschrauber.Helikopter.Cockpit;

namespace Rettungshubschrauber.Mensch;

public class Pilot : Worker
{
    private ControlPanal panel;
    private CyclicStick stick;
    private CollectivePitchControl pitchControl;
    private AntiTorguePadel leftPadel;
    private AntiTorguePadel rightPadel;

    public Pilot(PilotIDCard card, string name, string firstname, string personalNumber, DateTime date,
        ControlPanal panal, CyclicStick stick, CollectivePitchControl pitchControl, AntiTorguePadel leftPadel, AntiTorguePadel rightPedal)
    {
        this.card = card;
        this.name = name;
        this.firstname = firstname;
        this.personalNumber = personalNumber;
        birthday = date;
        this.card = card;
        panel = panal;
        this.stick = stick;
        this.pitchControl = pitchControl;
        this.leftPadel = leftPadel;
        this.rightPadel = rightPedal;
    }

    public void pushLeftPedal()
    {
        leftPadel.Push();
    }
    
    public void pushRightPedal()
    {
        rightPadel.Push();
    }

    public void turnPitchControll(int step)
    {
        int[] choices = new int[] { 0, 1, 2};
        if(choices.Contains(step)){
            pitchControl.activate(0);
        } 
        else
        {
            Console.WriteLine("Not a valid step");
        }
    }

    public void moveStickHorizontal(double steps,Direction direction)
    {
        double[] choices = new double[] { 0, 1, 2, 3, 4, 5 };
        if (choices.Contains(steps))
        {
            stick.MoveHorizontal(steps,direction);
        }
        else
        {
            Console.WriteLine("Not a valid step");
        }
        
    }
    
    public void moveStickVertical(int steps)
    {
        int[] choices = new int[] { 0, 1, 2, 3, 4, 5 };
        if (choices.Contains(steps))
        {
            stick.MoveVertical(steps);
        }
        else
        {
            Console.WriteLine("Not a valid step");
        }
        
    }
    
    public void SwitchMainRotorButton()
    {
        panel.SwitchMainRotorButton();
    }
    
    public void SwitchTailRotorButton()
    {
        panel.SwitchTailRotorButton();
    }

    public void SwitchAntiCollisionLightButton()
    {
        panel.SwitchAntiCollisionLightButton();
    }

    public void SwitchLandingLightButton()
    {
        panel.SwitchLandingLightButton();
    }

    public void SwitchDoorButton()
    {
        panel.SwitchDoorButton();
    }
}