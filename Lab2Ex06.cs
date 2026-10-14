
Console.WriteLine("Welcome to DONETSK ADVENTURE!");

Console.WriteLine("Are you ready to start your adventure? Enter 1 for yes and 2 for no:");
int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine("Let's begin creating your character!");
}
else if ( choice == 2)
{
    Console.WriteLine("Come back when you're ready for and adventure!");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("INVALID INPUT\nENDING SEQUENCE");
    Environment.Exit(0);
}

Console.WriteLine("Enter the name of your character: ");
string characterName = Console.ReadLine();

Console.WriteLine($"Enter the symbol of {characterName} on the map: ");
char characterMapIndicator = char.Parse(Console.ReadLine());


const int minHP = 1;


Console.WriteLine("Enter your character's max HP: ");
int maxHP = int.Parse(Console.ReadLine());

Console.WriteLine($"Enter your character's current HP(must be above 0 and under or equal to {maxHP}):");
int currentHP = int.Parse(Console.ReadLine());

bool isAlive = currentHP > minHP;
bool isFullHP = currentHP == maxHP;
bool needsHealing = currentHP < maxHP / 2;
double currentHPPercentage = currentHP % maxHP;


Console.WriteLine("Enter your character's basic attack damage: ");
int basicAttackDMG = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your amount of strength: ");
int strength = int.Parse(Console.ReadLine());

basicAttackDMG += strength;

Console.WriteLine("Enter your character's special attack base damage: ");
double specialAttackDMG = int.Parse(Console.ReadLine());


Console.WriteLine("Enter your special attack multiplier (for ex. 1,5): ");
double specialAttackMult = double.Parse(Console.ReadLine());

specialAttackDMG += strength;
specialAttackDMG *= specialAttackMult;

Console.WriteLine("Enter your backpack size: ");
int backpackMaxSlots = int.Parse(Console.ReadLine());

Console.WriteLine("Enter how many items you have in your backpack: ");
int itemsInBackpack = int.Parse(Console.ReadLine());

bool hasSpaceInBackpack = itemsInBackpack < backpackMaxSlots;


Console.WriteLine("Enter your amount of gold: ");
int goldAmount = int.Parse(Console.ReadLine());

Console.WriteLine("Enter how many people are in your party: ");
int partySize = int.Parse(Console.ReadLine());

int goldForEach = goldAmount / partySize;

double extraGold = goldAmount % partySize;

bool readyForAdventure = isAlive == true && needsHealing == false && hasSpaceInBackpack == true;

Console.WriteLine("+========================================== +:");
Console.WriteLine("| CHARACTER CARD |");
Console.WriteLine("+========================================== +");
Console.WriteLine($"| NAME: {characterName} MAP SYMBOL:{characterMapIndicator}    |");
Console.WriteLine("+ ------------------------------------------+");
Console.WriteLine($"| HEALTH: {currentHP} / {maxHP}({currentHPPercentage:F2}%) |");
Console.WriteLine($"| STRENGTH: {strength} |");
Console.WriteLine($"| BASIC ATTACK DAMAGE:{basicAttackDMG} (with the +{strength} strength bonus) |");
Console.WriteLine($"| SPECIAL ATTACK TOTAL DAMAGE: {specialAttackDMG} (with +{strength} strength bonus and *{specialAttackMult} special attack multiplier) |");
Console.WriteLine("+ ------------------------------------------+");
Console.WriteLine($"| GOLD AMOUNT: {goldAmount} |");
Console.WriteLine($"| PEOPLE IN PARTY:  {partySize} |");
Console.WriteLine($"| GOLD FOR EACH MEMBER: {goldForEach} |");
Console.WriteLine($"| EXTRA GOLD REMAINING: {extraGold:F2} |");
Console.WriteLine("+------------------------------------------+ ");
Console.WriteLine($"| IS ALIVE: {isAlive} |                            ");
Console.WriteLine($"| IS FULL HP: {isFullHP} |                  ");
Console.WriteLine($"| NEEDS HEALING: {needsHealing} |                    ");
Console.WriteLine($"| HAS SPACE IN BACKPACK: {hasSpaceInBackpack} |               ");
Console.WriteLine($"| READY FOR ADVENTURE: {readyForAdventure} |                  ");
Console.WriteLine("+========================================== +");