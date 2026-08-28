// Grössenrechnung
using System.ComponentModel.Design;
using System.Globalization;
Console.WriteLine("Herzlich Willkomen");
Console.WriteLine("Wollen sie wissen was für eine Skateboardbreite sie brauchen?");
string A1 = Console.ReadLine();
if (A1 == "ja")
{
    Console.WriteLine("dann kann ich dir weiterhelfen");
}
else if (A1 == "nein")
{
    Console.WriteLine("Dann verpiss dich");
}
else
{
    Console.WriteLine("Ungültige Eingabe");
}
Console.WriteLine("Was ist ihre Schuhgrösse?");
double SG = System.Convert.ToDouble(Console.ReadLine());
if (SG >= 23 && SG <= 55)
{
    Console.WriteLine("Okay");
}
else 
{
    Console.WriteLine("Keine Berechnungen verfügbar");
}
if  (SG == 23)
{
    Console.WriteLine("optimale Boardbreite = 6.5");
}
if (SG >= 24 && SG <=  25)
{
    Console.WriteLine("optimale Boardbreite = 6.75");
}
if (SG >= 26 && SG <= 28)
{
    Console.WriteLine("Optimale Boardgrösse = 6.825");
}
if (SG == 28)
{
    Console.WriteLine("Optimale Boardgrösse = 7.0");
}
if (SG == 29)
{
    Console.WriteLine("Optimale Boardgröse = 7.125");
}
if (SG == 30)
{
    Console.WriteLine("Optimale Boardgrösse = 7.25");
}
if (SG == 31)
{
    Console.WriteLine("Optimale Boardgrösse = 7.375");
}
if(SG == 32)
{
    Console.WriteLine("Optimale Boardgrösse = 7.5");
}
if (SG == 33 && SG == 34)
{
    Console.WriteLine("Optimale Boardgrösse = 7.75");
}
if (SG >= 35 && SG <= 42)
{
    Console.WriteLine("Optimale Boardgrösse = 8.0");
}
if (SG >= 43 && SG <= 55)
{
    Console.WriteLine("Optimale Deckgrösse = 8.25");
}
Console.WriteLine("Dies ist nur eine Empfehlung");
Console.WriteLine("Man kann auch ein Board nehmen dass 0.125 bis 0.25 grösser oder kleiner ist als die Optimale Grösse ist");


//Skateboard Konfiguration
string A2 = "0";
Console.WriteLine("");
Console.WriteLine("Möchtest du dir ein eigenes Skateboard zusammenstellen?");
while (A2 != "ja" && A2 != "nein")
{
    A2 = Console.ReadLine();
    if (A2 == "ja")
    {
        Console.WriteLine("Okay");
    }
    else if (A2 == "nein")
    {
        Console.WriteLine("Okay, wir hoffen dieser Rechner hat ihnen geholfen");
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe");
    }
}

