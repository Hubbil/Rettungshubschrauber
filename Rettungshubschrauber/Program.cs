// See https://aka.ms/new-console-template for more information

using Rettungshubschrauber.Helikopter;
using Rettungshubschrauber.Helikopter.Technic;
using Rettungshubschrauber.Helikopter.Technic.Drone;

Area area = new Area();
foreach (string e in area.Content)
{
    Console.WriteLine(e);
}
foreach (string f in area.Sections[0].Content)
{
    Console.WriteLine(f);
}