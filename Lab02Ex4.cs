Console.WriteLine("Enter your health points: ");
int healthPoints = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your amount of potions: ");
int potionAmount = int.Parse(Console.ReadLine());

Console.WriteLine("Do you have a key? enter true/false");
bool keyPossesion = bool.Parse(Console.ReadLine());





Console.WriteLine("Do you have a map? enter true/false");
bool mapPosession = bool.Parse(Console.ReadLine());




bool isAlive = healthPoints > 0;
bool isFullHealth = healthPoints == 100;
bool needsHealing = !isFullHealth;
bool maZaopatrzenie = potionAmount > 0;
bool hasNavigation = mapPosession == true || keyPossesion == true;
bool readyForAdventure = isAlive ==true && maZaopatrzenie == true && hasNavigation == true;

Console.WriteLine("Żyje: " + isAlive);
Console.WriteLine("Ma pełne zdrowie: " + isFullHealth);
Console.WriteLine("Wymaga leczenia: " + needsHealing);
Console.WriteLine("Ma zaopatrzenie: " + maZaopatrzenie);
Console.WriteLine("Ma klucz lub mapę: " + hasNavigation);
Console.WriteLine("Gotowy do wyprawy: " + readyForAdventure);
