// See https://aka.ms/new-console-template for more information

using Rettungshubschrauber.Helikopter;
using Rettungshubschrauber.Helikopter.Technic;
using Rettungshubschrauber.Helikopter.Technic.Drone;

Area a = new Area();
Helikopter heli = new Helikopter(a.Sections);
heli.CentralUnit.DeactivateLandingLight();
