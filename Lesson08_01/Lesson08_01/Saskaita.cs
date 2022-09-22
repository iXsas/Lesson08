using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_01
{
public class Saskaita
{
public string _gavejas { get; set; }
public string Siuntejas { get; set; }
public int MoketiViso { get; set; }
public string SaskaitosNumeris { get; set; }

public Saskaita(string gavejas, string siuntejas, int moketiViso)
{
    _gavejas = gavejas;
    Siuntejas = siuntejas;
    MoketiViso = moketiViso;
    SaskaitosNumeris = $"NR_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_01";
}
}
}
