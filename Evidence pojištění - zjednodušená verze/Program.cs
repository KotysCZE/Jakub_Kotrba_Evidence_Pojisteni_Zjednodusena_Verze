using Evidence_pojištění___zjednodušená_verze;
string vstup = "";
Rozhrani rozhrani = new Rozhrani();
rozhrani.VypisTabulku(); //Necháme aplikaci vypsat tabulku 
while (vstup != "4") //Spustíme cyklus, který ověřuje, zda uživatel nezadá "4", pokud ano, cyklus skončí a program se ukončí.
{
    Console.Write("Zadejte akci, kterou chceš provést: ");
    vstup = Console.ReadLine();

    if (vstup == "1")
    {
        rozhrani.pridatPojisteneho();
        Console.Clear(); //Pro přehlednost vyčistíme konzoli
        rozhrani.VypisTabulku();
    }
    else if (vstup == "2")
    {
        rozhrani.VratMiSeznamPojistenych();
        Console.Clear();
        rozhrani.VypisTabulku();
    }
    else if (vstup == "3")
    {
        rozhrani.NajdiMiPojisteneho();
        Console.Clear();
        rozhrani.VypisTabulku();
    }
}