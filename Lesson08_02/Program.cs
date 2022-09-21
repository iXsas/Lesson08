// See https://aka.ms/new-console-template for more information
//Sukurti struktūrą Palmė. Public laukai: amzius ir vaisiuKiekis. Abu tik skaitymui. Sukurti public metodą
//Prideti1MenAmziaus(). Palmė duoda vaisius nuo 5 iki 12 menėsio, paskui miršta, t.y. amžius tampa 0. 
//VaisiuKiekis = amžius*3;

using Lesson08_02;

Palme naujaPalme = new Palme(6,12);
Console.WriteLine(naujaPalme.Amzius);
naujaPalme.Prideti1MenAmziaus();
Console.WriteLine(naujaPalme.Amzius);

