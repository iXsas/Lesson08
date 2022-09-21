// See https://aka.ms/new-console-template for more information

//Sukurti struktūrą Miskas, su public lauku medžiai List<int> tipo.
//Struktūroje yra metodas public void PasodintiMedį(). Jis prideda medį į sąrašą. 

using Lesson08_04;
//sukuriu medziu sarasa
List<string> medziuSarasas = new List<string>() { "liepa", "uosis", "pusis", "egle" };

Miskas vilniausMiskas = new Miskas(medziuSarasas);

Console.WriteLine("Pradinis medziu sarasas");

for (int i = 0; i < vilniausMiskas.Medziai.Count; i++)
{
    string kintVid = vilniausMiskas.Medziai[i];
    Console.Write($"{kintVid}, ");
}
Console.WriteLine(" ");
Console.WriteLine("Iveskite nauja medzio pavadinima (kai jau visus suvesi spausk n) ");

string naujasMedis = Console.ReadLine();

while (true) {
    vilniausMiskas.PasodintiMedi(naujasMedis);
    naujasMedis = Console.ReadLine();
    if (naujasMedis != "n") { continue; } else { break; }
}


Console.WriteLine("Medziu sarasas po papildymo");
foreach (string kintVid in vilniausMiskas.Medziai)
{
    Console.Write($"{kintVid}, ");
}
Console.WriteLine($"\nViso medziu yra: {vilniausMiskas.Medziai.Count}");