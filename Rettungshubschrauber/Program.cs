// See https://aka.ms/new-console-template for more information

using Rettungshubschrauber.Helikopter;
using Rettungshubschrauber.Helikopter.Technic;
using Rettungshubschrauber.Helikopter.Technic.Drone;

Area area = new Area();
foreach (string f in area.Sections[0].Content)
{
    Console.WriteLine(f);
}

Helikopter heli = new Helikopter(area.getSections());
heli.DroneLug.Drone.unit.sendSection();