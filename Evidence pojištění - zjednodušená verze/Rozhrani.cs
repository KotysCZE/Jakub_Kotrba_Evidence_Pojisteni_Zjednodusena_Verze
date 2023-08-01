using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištění___zjednodušená_verze
{
    internal class Rozhrani
    {
        private List<Pojistenec> seznamPojistenych = new List<Pojistenec>();



        //Vypíše mi tabulku s možnostmi
        public void VypisTabulku()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("Vyberte akci:\n" +
                "1 - Pridat noveho pojisteneho\n" +
                "2 - Vypsat vsechny pojistene\n" +
                "3 - Vyhledat pojisteneho \n" +
                "4 - Konec");
            Console.WriteLine();
        }


        //metoda pro přidání pojištěného do listu
        public void pridatPojisteneho()
        {
            Console.Write("Zadej jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadej přijimení pojištěného: ");
            string prijimeni = Console.ReadLine();
            Console.Write("Zadej věk pojištěného: ");
            string vek = Console.ReadLine();
            Console.Write("Zadej telefonní číslo pojištěného ");
            string telefon = Console.ReadLine();

            
            seznamPojistenych.Add(new Pojistenec(jmeno, prijimeni, vek, telefon));
            Console.WriteLine("Data byla uložena. Zadejte libovolnou klávesu..");
            Console.ReadLine();
        }

        //metoda pro vypsání seznamu pojištěných
        public void VratMiSeznamPojistenych()
        {
            if (seznamPojistenych.Count != 0) //Pokud není seznam prázdný, tak začne vypisování všech objektů v listu
            {
                foreach (Pojistenec i in seznamPojistenych)
                {
                    Console.WriteLine(i);
                    Console.WriteLine();
                }
            }
            else //Pokud je seznam prázdný, vyskočí chyba.
                Console.WriteLine("Seznam je prádný."); 
            Console.WriteLine("Zadejte libovolnou klávesu..");
            Console.ReadLine();
        }

        //Metoda pro vyhledání pojištěného podle jména a přijímení
        public void NajdiMiPojisteneho()
        {
        Console.WriteLine("Zadejte jméno hledaného pojištěného: ");
        string jmeno = Console.ReadLine();
        Console.WriteLine("Zadejte přijmení hledaného pojištěného: ");
        string prijimeni = Console.ReadLine();
            string nalezen = "";
        foreach(Pojistenec i in seznamPojistenych) //Cyklus projede každý prvek v listu
            {
                
                if ((i.jmeno.ToLower() == jmeno.ToLower()) && (i.prijimeni.ToLower() == prijimeni.ToLower())) //Porovnáváme zadané jméno a přijímení se jmény a přijimeními každého záznamu
                {
                    Console.WriteLine(i); //Pokud je shoda, tak se vypíše override třídy
                    Console.WriteLine();
                    nalezen = "ANO"; //změní se status vyhledávání
                }
            }
            if (nalezen != "ANO")
                Console.WriteLine("Hledaný pojištěný nenalezen");//Pokud se status nezmění, tak nám vyskočí chybová hláška
            Console.WriteLine("Zadejte libovolnou klávesu..");
            Console.ReadLine();
        }
       
    }
}
