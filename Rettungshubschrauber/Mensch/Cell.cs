namespace Rettungshubschrauber.Mensch;

public class Cell
{
    private char state { get; set; }
    private char content { get; set; }

    public Cell()
    {
        state = 'H';
        content = 'o';
    }

    public void setState(char state)
    {
        this.state = state;
    }

    public char getState()
    {
        return state;
    }

    public void swap()
    {
        if (content == 'o')
        {
            content = 'c';
        }
        else
        {
            content = 'o';
        }
    }
}