// See https://aka.ms/new-console-template for more information

//Sukurti struktūrą Point, public laukai x ir y tik skaitymui, perduodami per konstr. 
//    Sukurti struktūrą Rectangle, su public laukais TopLeft, BottomRight Point tipo.
//    Sukurti metodą bool IsPointInRectangle(Point taskas).

using Lesson08_03;

Console.WriteLine("Paduodame inputa");

Point pirmasTaskas = new Point(2, 10);
Point antrasTaskas = new Point(8, 3);
Point yraTaskas = new Point(4, 6);
Point neraTasko = new Point(15, 12);

Rectangle kvadratas = new Rectangle(pirmasTaskas, antrasTaskas);
Console.WriteLine("Tikrinam trecia taska");
Console.WriteLine(kvadratas.IsPointInRectangle(yraTaskas));
Console.WriteLine("Tikrinam ketvirta taska");
Console.WriteLine(kvadratas.IsPointInRectangle(neraTasko));
