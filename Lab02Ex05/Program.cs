
Console.WriteLine("==== Input data for battle report ====");

Console.Write("Character name: ");
string name = Console.ReadLine();

Console.Write("Max health (more than 0): ");
int maxHp = int.Parse(Console.ReadLine());

Console.Write("Current health before battle: ");
int currentHpBefore = int.Parse(Console.ReadLine());

Console.Write("Base damage: ");
int baseDamage = int.Parse(Console.ReadLine());

Console.Write("Strength bonus: ");
int strengthBonus = int.Parse(Console.ReadLine());

Console.Write("Special attack multiplier (ex. 1,5): ");
double specialMultiplier = double.Parse(Console.ReadLine());

Console.Write("Amount of normal attacks done: ");
int normalAttacksCount = int.Parse(Console.ReadLine());

int normalAttackDamage = baseDamage + strengthBonus;
int specialAttackDamage = (int)(normalAttackDamage * specialMultiplier);
int totalDamageDealt = (normalAttackDamage * normalAttacksCount) + specialAttackDamage;
double healthPercentage = ((double)currentHpBefore / maxHp) * 100.0;

bool isAlive = currentHpBefore > 0;
bool hasFullHealth = (currentHpBefore == maxHp);

Console.WriteLine("\n==================== BATTLE REPORT ===================");
Console.WriteLine($"Character name: {name}");
Console.WriteLine($"Current health: {currentHpBefore}/{maxHp} ({healthPercentage:F2}%)");
Console.WriteLine($"Normal attack damage: {normalAttackDamage}");
Console.WriteLine($"Special attack damage: {specialAttackDamage}");
Console.WriteLine($"Total damage dealt: {totalDamageDealt}");
Console.WriteLine($"Alive: {(isAlive ? "Yes" : "No")}");
Console.WriteLine($"Full health: {(hasFullHealth ? "Yes" : "No")}");
Console.WriteLine("====================================");
