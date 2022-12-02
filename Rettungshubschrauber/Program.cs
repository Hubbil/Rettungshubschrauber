// See https://aka.ms/new-console-template for more information

using Rettungshubschrauber.Helikopter;
using Rettungshubschrauber.Helikopter.Technic;

Battery battery = new Battery();
battery.charge();
Console.Write($@"charged : {battery.GetLoadedCells()} ");
battery.discharge(3499);
Console.Write($@"discharge 1 : {battery.GetLoadedCells()} ");
battery.discharge(50001);
Console.Write($@"discharge 2 : {battery.GetLoadedCells()} ");
double test = 2;