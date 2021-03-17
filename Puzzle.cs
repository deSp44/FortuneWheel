using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneWheel
{
    //TODO : Wybór podstawowych kategorii lub wpisywanie własnej
    //TODO : Prostsze wpisywanie hasła do zgadnięcia (nieakceptowanie ENTER)
    //TODO : Ulepszenie wyglądu ukrytego hasła
    //TODO : Przycisk "poddania się"
    //TODO : Lepszy ekran wygranej wraz z opcjami co użytkownik chce robić dalej
    //TODO : Tryb wisielca - dodanie limitu możliwych błędów
    //TODO : Dodanie jeszcze jednego okna startowego z wyborem trybów
    //TODO : Ładniejszy wygląd i ułożenie okien
    //TODO : Baza haseł z losowym ich wybieraniem
    //TODO : Refaktoryzacja kodu i podział na metody

    public class Puzzle
    {
        public string Category { get; set; }
        public string Sentence { get; set; }
    }
}
