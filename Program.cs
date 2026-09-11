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
    Console.WriteLine("Okay");

else
    Console.WriteLine("Keine Berechnungen verfügbar");


if (SG == 23)
    Console.WriteLine("optimale Boardbreite = 6.5");

if (SG >= 24 && SG <= 25)
    Console.WriteLine("optimale Boardbreite = 6.75");

if (SG >= 26 && SG <= 28)
    Console.WriteLine("Optimale Boardgrösse = 6.825");

if (SG == 28)
    Console.WriteLine("Optimale Boardgrösse = 7.0");

if (SG == 29)
    Console.WriteLine("Optimale Boardgröse = 7.125");

if (SG == 30)
    Console.WriteLine("Optimale Boardgrösse = 7.25");

if (SG == 31)
    Console.WriteLine("Optimale Boardgrösse = 7.375");

if (SG == 32)
    Console.WriteLine("Optimale Boardgrösse = 7.5");

if (SG == 33 && SG == 34)
    Console.WriteLine("Optimale Boardgrösse = 7.75");

if (SG >= 35 && SG <= 42)
{
    Console.WriteLine("Optimale Boardgrösse = 8.0");
}

if (SG >= 43 && SG <= 55)
{
    Console.WriteLine("Optimale Deckgrösse = 8.25");
}
Console.WriteLine("Dies ist nur eine Empfehlung");
Console.WriteLine("Man kann auch ein Board nehmen das 0.125 bis 0.25 grösser oder kleiner ist als die Optimale Grösse ist");


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
//Räder

Console.WriteLine(
    "Welche Räder möchtest du?\n\n" +
    "1. Weiche Cruiser Rollen (Härte = 78A) - Sehr weich, angenehm auf unebenen Straßen, viel Grip, schlecht für Tricks\n\n" +
    "2. Filmrollen (Härte = 80A) - Sehr komfortabel und leise, gut für lange Strecken\n\n" +
    "3. Cruiser Rollen (Härte = 83A) - Verbindet Komfort und Geschwindigkeit, viel Grip, aber etwas weniger\n\n" +
    "4. Weiche Cruiser-Rollen (Härte = 85A) - Etwas härter und schneller, gut für Straße und kleinere Unebenheiten\n\n" +
    "5. Hybrid-Rollen (Härte = 87A) - Weiches Fahrgefühl und besseres Slide-Verhalten, gut zum Cruisen und für Tricks\n\n" +
    "6. Hybrid-/Street-Rollen (Härte = 90A) - Härter und direkter, gut für Tricks und Skateparks\n\n" +
    "7. Hybrid-Rollen (Härte = 95A) - Spürbar härter, leichter zu sliden, guter Übergang zu Street-Rollen\n\n" +
    "8. Typische Street-Rollen (Härte = 99A) - Schnell und präzise auf glattem Untergrund, gut für Ollies, Slides und Grinds\n\n" +
    "9. Harte Street-/Park-Rollen (Härte = 101A) - Sehr hart und schnell auf glattem Beton, weniger Grip\n\n" +
    "10. Sehr harte Park-Rollen (Härte = 101A+) - Extrem hart, wenig Grip, besonders gut für glatte Skateparks\n\n"
);

Console.WriteLine("für die gewünschten Räder die jeweilige Zahl eingeben");
string Räder = Console.ReadLine();
while (!int.TryParse(Räder, out int zahl) || zahl < 1 || zahl > 10)
{
    Console.WriteLine("Ungültige Eingabe! Bitte eine Zahl zwischen 1 und 10 eingeben:");
    Räder = Console.ReadLine();
}
Console.WriteLine("Okay");
Console.WriteLine("");

//Achsen

Console.WriteLine(
    "Welche Achsen möchtest du?\n\n" +
    "1. Standard-Achsen - Ausgewogenes Fahrgefühl, gut für Street und Allround\n\n" +
    "2. Low-Achsen - Board liegt tiefer, gut für Street und Tricks\n\n" +
    "3. High-Achsen - Mehr Abstand zum Boden, gut zum Cruisen und für Rampen\n\n" +
    "4. Leichte Achsen - Weniger Gewicht, gut für Flip-Tricks\n\n" +
    "5. Breite Achsen - Mehr Stabilität und Standfläche, gut für Bowl und Rampen\n\n" +
    "6. Schmale Achsen - Wendiger und leichter zu drehen, gut für Street und technische Tricks\n\n"
);


Console.WriteLine("Für die gewünschte Achse die jeweilige Zahl eingeben");
string Achsen = Console.ReadLine();

while (!int.TryParse(Achsen, out int zahl) || zahl < 1 || zahl > 10)
{
    Console.WriteLine("Ungültige Eingabe! Bitte eine Zahl zwischen 1 und 10 eingeben:");
    Achsen = Console.ReadLine();
}
Console.WriteLine("Okay");
Console.WriteLine("");

Console.WriteLine(
    "Welche Qualität sollten die Teile haben?\n\n" +
    "1. Niedrige Qualität\n\n" +
    "2. Mittlere Qualität\n\n" +
    "3. Hohe Qualität\n\n"
);

Console.WriteLine("Für die gewünschte Qualität die jeweilige Zahl eingeben");
double Qualität = System.Convert.ToDouble(Console.ReadLine());
if (Qualität == 1)
    Console.WriteLine("Preis = 55-90Fr.");

if (Qualität == 2)
    Console.WriteLine("Preis = 95-160Fr.");

if (Qualität == 3)
    Console.WriteLine("Preis = 160-280Fr.");

Console.WriteLine("Dies ist nur ein ungefährer Preis, der Preis kann je nach Marke und Grösse stark variieren");
Console.WriteLine("Der Preis schliesst alle Komponenten ein die angegeben wurden");
