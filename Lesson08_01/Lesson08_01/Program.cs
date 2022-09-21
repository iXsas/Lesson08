// See https://aka.ms/new-console-template for more information

//Sukurti struktūrą Saskaita. Public laukai gavejas, siuntejas, moketiViso,
//saskaitosNumeris. Visi laukai tik skaitymui, perduodami per konstruktorių 
//išskyrus saskaitosNumeris, jis generuojasi automatiškai konstruktoriuje 
//(NR_metai_menuo_diena_01)
using Lesson08_01;

Saskaita uzMaista = new Saskaita("","",1);
Console.WriteLine(uzMaista.SaskaitosNumeris);
