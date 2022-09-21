using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_04
{
    public struct Miskas
    {
        // public string medzioPavadinimas;
        //  public int medzioNumeris;
        public List<string> Medziai { get; set; }
        //strukturos konstruktorius, paduodame is karto medziu sarasa
        public Miskas(List<string> zsarasas)
        {
            Medziai = zsarasas;
        }
        public void PasodintiMedi(string medzioPavadinimas) {
            Medziai.Add(medzioPavadinimas);
        }
    }
}
