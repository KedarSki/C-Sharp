using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Imię i Nazwisko: Radosław Zamojski Index: 99831 SAN grupa 2.
 
Program wykonuje instrukcje Random w języku C#. Program wypisuje do konsoli środowiska Visual Studio generowane losowo liczby od 0 do 100. Program posiada opcje podania przez użytkownika ilości elementów.
Możemy podać dowolną liczbę elementów a na naszej tablicy zostanie wypisana dana ilość elementów w liczbach od 0 do 100. Liczby dodatkowo nie powtarzają się. 
Cała wygenerowana tablica dodatkowo zostaje posortowana bombelkowo jako zadanie nr 7. Sortowanie jest konieczne do wykonania szukania binarnegp
 */


namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] arg)
        {
            
            string text; // Wykreowanie zmiennej text typu string

            Random gen; // Wykreowanie zmiennej gen typu random

            int numbers, i; // Wykreowanie zmiennych numbers, i, typu int o liczbie całkowitej

            int[] vector; // wykreowanie zmiennej vector typu int[] (array)

            gen = new Random(); // nadanie zmiennej gen funkcji Random(); która nadaje zmiennej losowe liczby.

            Console.WriteLine("Nadawanie tablicy elementów losowych");
            Console.WriteLine("Podaj liczbę elementów tablicy");

            text = Console.ReadLine(); // Jest to komenda niezbędna aby w konsoli móc wpisać cokolwiek z racji tego, że posługujemy się klawiaturą, 

            if (!int.TryParse(text, out numbers)) // warunek 'if' który ma na celu przekształcić typ zmiennej. Jest to Konwersja Typu Zmiennej. 
            {
                Console.WriteLine();
                Console.ReadKey(true);
            }

            vector = new int[numbers]; // Inicjalizowanie tablicy o nazwie 'vector' która mieści wszystkie liczby całkowite, które są przechowywane w zmiennej 'numbers'
            


            for (i = 0; i < vector.Length; i++) // pętla 'for'- jest to takie można powiedzieć wejście do tablicy od wartości 0;
            {


                int newRandomValue = gen.Next(0, 100); // inicjalizowanie nowej zmiennej newRandomValue i nadanie jej przykazu, że generowane liczby będą 0-100;

                if (!vector.Contains(newRandomValue)) // Warunek if w którym parametry wywołane są takie, które już wcześniej się nie wygenerowały;
                    vector[i] = newRandomValue; // w momencie spełnienia warunku kolejna wartość dodaje się do tablicy. 
                else
                    i--; // W przeciwnym razie warunek odejmuje  wartość się odejmuje. Cału warunek zabezpiecza, żeby liczby się nie powtarzały;
            }

            Console.WriteLine(); // Dodatkowa linia dla zachowania estetyki;

            // Sortowanie bombelkowe 

            int j; // Generowanie nowej zmiennej w celu jej późniejszego zamienienia.

            for (i = 0; i < vector.Length; i++) // Wejście do tablicy poprzez pętle.
            {
                for (j = 0; j < vector.Length; j++) //pętla zagnieżdżona z nową zmienną.
                {
                    if (vector[i] < vector[j]) //warunek gdzie jeden parametr musi być mniejszy od drugiego
                    {
                        int temp = vector[i]; // jeśli warunek spełniony to zmienna temp równa się ilości iteracji w tablicy. 
                        vector[i] = vector[j]; // zamiana pozycji z i na j.
                        vector[j] = temp; // zamiana iteracji 'j' na zmienną temp; 
                    } // Na tym polega sortowanie bombelkowe, że zamienia się miejscami pozycje jeśli się sobie nie równają. Sprawdzana jest każda wartość dwukrotnie po kolei. 
                }
            }

            for (i = 0; i < vector.Length; i++) // Wejście do tablicy za pomocą pętli for
            {
                Console.WriteLine($"{i}. {vector[i]} "); // Wyświetlenie wartości
            }

            Console.ReadKey();

          
            //Szukanie binarne

            Console.WriteLine("Podaj wartość szukaną: "); // Prośba o podanie szukanej wartości

            text = Console.ReadLine();             

           int top = 0; // nowa zmienna top czyli lewej strony tablicy

           int mid; // nowa zmienna mid czyli środek tablicy

            int bottom = vector.Length - 1; // zmienna bottom czyli prawa strona tablicy odjąć 1

            int search; // zmienna szukana; 
            
            if(!int.TryParse(text, out search)) 
            {
                Console.WriteLine();
                Console.ReadKey();
            }


            //Szukanie binarne

                while (true) // pętla while wykonywana do momentu break;
                {
                    if(top>bottom) // warunek jeśli lewa strona większa od prawej, to wtedy wartość nie istnieje. 
                {
                    Console.WriteLine("Podana wartość nie istnieje w wektorze");

                    break;
                }

                    
                    mid = (bottom + top) / 2; // zmienna mid która wykonuj operacje dzielenia na dwa wartość po dodaniu prawej i lewej strony.
                if (vector[mid] == search) // wartunej jeśli zmienna tablicy mid wyniesie wartość zmiennej szukanej  ===>>>

                {
                    Console.WriteLine($"Szukana wartość, znajduje się w indeksie nr. { mid}"); // ===>>>  to wyświetlamy szukany indeks wartości
                    break;
                }


                if (vector[mid] > search) // kolejny warunek if w pętli  while. Jeśli w tablicy o wartości równej zmiennej mid jest większa wartość niż szukana
                    {
                        bottom = mid - 1; // ==>> To prawa strona równa się strona równa się środek -1
                    }
                  else
                    {
                        top = mid + 1; // w innym przypadku  lewa strona jest równa środek +1. 
                    }
               
                
            }
                

        }

    }
}

            
