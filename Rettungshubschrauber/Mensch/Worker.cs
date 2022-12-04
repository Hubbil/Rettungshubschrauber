using Microsoft.VisualBasic;

namespace Rettungshubschrauber.Mensch;

public abstract class Worker
{
    protected string personalNumber;
    protected string firstname;
    protected string name;
    protected DateTime birthday;
    protected IIDCard card;
}