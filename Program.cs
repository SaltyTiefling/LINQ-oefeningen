using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mijnStringArray = {
                "hallo",
                "dit",
                "is",
                "Jonas",
                "van",
                "mullem"
            };
            string[] mijnStringArray2 = {
                "Jonas",
                "van",
                "mullem",
                "ben",
                "ik"
            };
            int[] mijnIntArray = { 5, 6, 4, 7, 8, 15, 15, 2, 1, 1, 1, 1, 100, 201, 300, 3 };

            List<int> intList = new List<int>() { 5, 6, 4, 7, 8, 15, 15, 2, 1, 1, 1, 1, 100, 201, 300, 3 };
            List<Persoon> personenlijst = new List<Persoon>(){
                new Persoon("Mike","mikelson", 18),
                new Persoon("Laurens", "laureen",18),
                new Persoon("Stefaan", "stefaania",19),
                new Persoon("Sofie","sophia", 19),
                new Persoon("Elias","Warforged", 20),
                new Persoon("Joris","jorst", 20),
                new Persoon("Bart","Simpson", 20
                ),


            };

            //1. Maak een query waarmee je een array met strings print. 
            var oefening1 = mijnStringArray.Select(str => str);

            Console.WriteLine("oefening 1:");
            foreach (string str in oefening1)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            //2. Maak een query waarmee je alle getallen in een array deelbaar door 2 print.

            var oefening2 = mijnIntArray.Where(getal => getal % 2 == 0);

            Console.WriteLine("oefening 2:");

            foreach (var integer in oefening2)
            {
                Console.WriteLine(integer);
            }
            Console.WriteLine();

            //3. Maak een query waarmee je alle getallen in een array van 0 tot en met 20 print.
            Console.WriteLine("oefening 3:");
            var oefening3 = mijnIntArray.Where(i => i > 0 && i < 20);
            foreach (var integer in oefening3)
            {
                Console.WriteLine(integer);
            }
            Console.WriteLine();

            //4. Maak een query waarmee je het kwadraat van elk getal in een array print, als dat getal na de bewerking groter is dan 50.
            Console.WriteLine("oefening 4:");
            var oefening4 = mijnIntArray.Select(s => Math.Pow(s, 2)).Where(s => s > 50);
            foreach (var integer in oefening4)
            {
                Console.WriteLine(integer);
            }
            Console.WriteLine();

            // 5. Maak een query waarmee je kijkt of elk getal in die array tussen 12 en 18 ligt.
            Console.WriteLine("oefening 5:");
            var oefening5 = mijnIntArray.All(s => s > 12 && s < 18);
            Console.WriteLine(oefening5);
            Console.WriteLine();

            //6. Maak een query waarmee je het laatste element van een list teruggeeft.
            Console.WriteLine("oefening 6:");
            Console.WriteLine(personenlijst.Last());
            Console.WriteLine();

            //7. Maak een query waar je iedere persoon zijn voornaam ouder dan 18 jaar van een klasse Persoon print.
            Console.WriteLine("oefening 7:");
            var oefening7 = personenlijst.Where(s => s.leeftijd > 18);
            foreach (Persoon persoon in oefening7)
            {
                Console.WriteLine(persoon.voornaam);
            }
            Console.WriteLine();

            //8. Maak een query waarmee je elk getal in een array opsomt, en hoe vaak dat getal erin voor komt
            Console.WriteLine("oefening 8:");
            var oefening8 = mijnIntArray.GroupBy(s => s);
            foreach (var item in oefening8)
            {
                Console.WriteLine($"{item.Key}: {item.Count()}");
            }
            Console.WriteLine();

            //9. Maak een query waarbij je een lijst van personen sorteert op de achternaam, en daarna op de voornaam.
            Console.WriteLine("oefening 9:");
            var oefening9 = personenlijst.OrderBy(s => s.voornaam).ThenBy(s => s.achternaam);
            foreach (Persoon persoon in oefening9)
            {
                Console.WriteLine(persoon);
            }
            Console.WriteLine();

            //10. Maak een query waarmee je het gemiddelde berekend van een array.
            Console.WriteLine("oefening 10:");
            Console.WriteLine(mijnIntArray.Average());
            Console.WriteLine();

            //11. Maak een query waarmee je kijkt of een ingegeven string in de array zit.
            Console.WriteLine("oefening 11:");
            string inputstr = "nas";
            Console.WriteLine(mijnStringArray.Any(s => s.Contains(inputstr)));
            Console.WriteLine();

            //12. Maak een query waarbij je personen klasseert volgens hun leeftijd
            Console.WriteLine("oefening 12:");
            var oefening12 = personenlijst.GroupBy(s => s.leeftijd);
            foreach (var leeftijdsgroup in oefening12)
            {
                Console.Write(leeftijdsgroup.Key + ":");
                foreach (Persoon persoon in leeftijdsgroup)
                {
                    Console.Write(" " + persoon.voornaam);
                }
                Console.Write(" | ");
            }
            Console.WriteLine();

            //13. Maak een query waarmee je het hoogste even getal teruggeeft.
            Console.WriteLine("oefening 13:");
            Console.WriteLine(mijnIntArray.Where(s => s % 2 == 0).Max());
            Console.WriteLine();

            //14. Maak een query waarmee je elk character in een string dat je zelf ingeeft opsomt, en hoe vaak dat character er in voor komt. 
            Console.WriteLine("oefening 14:");
            inputstr = "oke dit is een test";
            Console.WriteLine(inputstr);

            var oefening14 = inputstr.GroupBy(s => s);
            foreach (var item in oefening14)
            {
                Console.WriteLine($"{item.Key}: {item.Count()}");
            }
            Console.WriteLine();

            //15. Maak een query waarmee je elk getal opsomt, maal hoe vaak dat het er in voor komt (dus als er 3 keer 6 in voorkomt print je 18).
            Console.WriteLine("oefening 15:");
            var oefening15 = mijnIntArray.GroupBy(s => s);
            foreach (var item in oefening15)
            {
                Console.WriteLine($"{item.Key} X {item.Count()} = {item.Key * item.Count()}");
            }
            Console.WriteLine();

            //16. Maak een query waarmee je uit 2 lists alle gelijke waarden print
            Console.WriteLine("oefening 16:");
            var oefening16 = mijnStringArray.Join(mijnStringArray2,
                s1 => s1,
                s2 => s2,
                (r1, r2) => r1);
            foreach (var item in oefening16)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();

            //17. Maak een query waarmee je elk woord print uit een array dat start met een letter dat je ingeeft, en eindigt met een letter dat je ingeeft.
            Console.WriteLine("oefening 17:");
            string beginLetter = "J";
            string eindletter = "s";

            var oefening17 = mijnStringArray.Where(s => s.StartsWith(beginLetter) && s.EndsWith(eindletter)).Select(s => s);
            foreach (string item in oefening17)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            //18. Maak een query waarmee je elk getal in een List print dat groter is dan 10.
            Console.WriteLine("oefening 18:");
            var oefening18 = intList.Where(s => s > 10);
            foreach (int item in oefening18)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //19. Maak een query waarmee je voor elk object in een list een nieuw object maakt met de voornaam en achternaam, print deze
            Console.WriteLine("oefening 19:");
            var oefening19 = personenlijst.Select(s => new { s.voornaam, s.achternaam });
            foreach (var item in oefening19)
            {
                Console.WriteLine($"{item.voornaam} {item.achternaam}");
            }
            Console.WriteLine();

            //20. Maak een query waarbij je de indexen uit een List print waarvan elk getal groter is dan een ingegeven waarde. (Dus bij [10, 20, 25, 30, 12] print je 2 en 3 als je 24 ingeeft)
            Console.WriteLine("oefening 20:");
            int ingegevenint = 15;
            Console.WriteLine("ingegevenint:" + ingegevenint);
            var oefening20 = intList.Select((s, index) => new { s, index }).Where(s => s.s > ingegevenint);

            foreach (var item in oefening20)
            {
                Console.WriteLine($"{item.index}: {item.s}");
            }

            Console.WriteLine();

            //21. Print de 5 grootste getallen uit een array.
            Console.WriteLine("oefening 21:");
            var oefening21 = mijnIntArray.OrderByDescending(s => s).Take(5);
            foreach (var item in oefening21)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //22. Print alle woorden in full-caps uit een string
            Console.WriteLine("oefening 22:");
            inputstr = "Dit is EEN LEUKE zin HOOR";
            Console.WriteLine(inputstr);
            var oefening22 = inputstr.Split(' ').Where(s => s == s.ToString().ToUpper());
            foreach (string item in oefening22)
            {
                Console.Write(item + ' ');
            }

            Console.ReadLine();
        }

    }

    class Persoon
    {
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public int leeftijd { get; set; }

        public Persoon(string voornaam, string achternaam, int leeftijd)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.leeftijd = leeftijd;
        }

        public override string ToString()
        {
            return $"{voornaam} {achternaam} {leeftijd}";
        }
    }
}
