using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneWheel
{
    //TODO : Dodanie hiperłącza do linku w informacjach
    //TODO : Refaktoryzacja kodu i podział na metody
    //TODO : ??? Baza haseł z losowym ich wybieraniem

    public class Puzzle
    {
        public string Category { get; set; }
        public string Sentence { get; set; }
        public int? PossibleAttempts { get; set; }
        public int? TimeRemains  { get; set; }
    }
}
