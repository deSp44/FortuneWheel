using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneWheel
{
    //TODO : Okno startowez wyborem trybów - do poprawienia i dodania więcej modyfikacji!
    //TODO : Tryb wisielca - dodanie limitu możliwych błędów
    //TODO : Zatrzymać licznik po zakończonym zgadywaniu
    //TODO : Dodanie opcji z przegraną użytkownika

    //TODO : Refaktoryzacja kodu i podział na metody
    //TODO : ??? Baza haseł z losowym ich wybieraniem

    public class Puzzle
    {
        public string Category { get; set; }
        public string Sentence { get; set; }
    }
}
