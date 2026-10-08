string name = "Tymur";
char mapSymbol = '@';
int currentExperience = 25;
int level = 2;
int goldAmount = 35;
double weightKilograms = 40;
bool mapPosession = true;
int trainingLevel = 0;

Console.WriteLine("\n\n=== EKWIPUNEK ===");
Console.WriteLine("Imię (string): " + name);
Console.WriteLine("(char): " + mapSymbol);
Console.WriteLine("Doświadczenie (int): " + currentExperience);
Console.WriteLine("Poziom (int):" + level);
Console.WriteLine("Złoto (int): " + goldAmount);
Console.WriteLine("Waga (double): " + weightKilograms);
Console.WriteLine("Ma mapę (bool): " + mapPosession);

Console.WriteLine("\n\n" + name + " wchodzi na arenę! (koszt: 8 złota)");


currentExperience *= 2;
goldAmount -= 8;
goldAmount += 15;
trainingLevel += 1;

Console.WriteLine("\nTrening skończono!");

Console.WriteLine("\n\n=== EKWIPUNEK ===");
Console.WriteLine("Imię (string): " + name);
Console.WriteLine("(char): " + mapSymbol);
Console.WriteLine("Doświadczenie (int): " + currentExperience);
Console.WriteLine("Poziom (int):" + level);
Console.WriteLine("Złoto (int): " + goldAmount);
Console.WriteLine("Waga (double): " + weightKilograms);
Console.WriteLine("Ma mapę (bool): " + mapPosession);