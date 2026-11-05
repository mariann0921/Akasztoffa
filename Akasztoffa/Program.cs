using System.ComponentModel.Design;

namespace Akasztoffa
{
    internal class Program
    {
       static string[] szavak =
  {
    "alma", "korte", "barack", "szilva", "dinnye",
    "kutya", "macska", "oroszlan", "tigris", "elefant",
    "asztal", "szekreny", "ablak", "ajto", "szek",
    "iskola", "tanulo", "tanar", "fuzet", "ceruza",
    "auto", "vonat", "repulo", "hajo", "bicikli",
    "konyv", "telefon", "szamitogep", "billentyu", "eger",
    "nap", "hold", "csillag", "felho", "eso",
    "tenger", "folyo", "hegy", "erdo", "to",
    "kenyer", "sajt", "vaj", "leves", "pizza",
    "kalap", "kabát", "cipő", "nadrag", "polo",
    "asztalos", "orvos", "mernok", "pék", "szinesz",
    "labda", "foci", "kosarlabda", "tenisz", "uszas",
    "virag", "rozsa", "tulipan", "napraforgo", "ibolya",
    "kiraly", "herceg", "lovag", "katona", "varazslo",
    "sziget", "barlang", "kastely", "templom", "hid",
    "csokolade", "cukorka", "fagylalt", "palacsinta", "suti",
    "repulo", "helikopter", "traktor", "motor", "teherauto",
    "ora", "naptar", "tukor", "lampa", "gyertya",
    "villam", "szivarvany", "havas", "jeg", "hoember",
    "sarkany", "kalóz", "kincses", "korona", "kard"
};
        static Random random = new Random();
        //metódus, mely véletlenszerűen kiválaszt egy szót - amit majd ki kell találni- és visszatér vele
        static string Kivalasztas() 
        {
            int index = random.Next(0,szavak.Length);
            return szavak[index];
        }
        static char Bekeres()
        {
            Console.Write("Kérem adjon meg egy betűt: ");
            char betu = Console.ReadLine()[0];
            return betu;
        }


        static void Main(string[] args)
        {
            string kitalalando = Kivalasztas();
//          Console.WriteLine(kitalalando);
            string talalatok = new string('_', kitalalando.Length);
            Console.WriteLine(talalatok);
            int tippekSzama = 0;
            while (kitalalando != talalatok)
            {
                char tipp = Bekeres();
                tippekSzama++;
                if (kitalalando.Contains(tipp)) //Contains megvizsgálja, hogy az adott betű enne van -e a kitalalndoban. Ha benne van, true-t ad vissza
                {
                   string seged = ""; //ideiglenesen összeirom, hogy mely betűk vannek meg
                    int index = 0;
                    foreach (char betu in talalatok) //a betu valtozo egy karaktere a talalatoknak. Először az első, majd a masodik, harmadik... sorban az összes egyesével
                    {
                        if (tipp == kitalalando[index++])
                        {
                            seged += tipp; //ha a tippem megegyezik a kitalalando szó indexikénti betűjével, akkor hozzáadjuk a segedhez
                        }
                        
                        else //ha a talalatokban lévő betű nem egyezik meg a kitalalando szó indexikénti betűjével, akkor a segedbe egy _ kerül
                        {
                            seged += betu;
                        }
                    }
                    talalatok = seged;
                    Console.WriteLine(talalatok);
                }
                else
                {
                    Console.WriteLine("Nincs benne a szóban");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gratulálok, {tippekSzama} találgatásból eltalálta! ");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}



//1 legyen egy szó, amit ki kell találni
//ki kell iratni rejtve a felhasználónak. Annyi vonalat, ahany betű van benne 
//bekérni a felhasználótól egy betűt
//eldöntjük, hogy benne van-e a kitalálandó szóban a betű
//ha benne van-e a vonal helyett azt a betűt irjuk ki. 