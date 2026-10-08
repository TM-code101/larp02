Console.WriteLine("Podaj ilość racjii żywnościowych: ");
int rationAmount = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj ilość członków drużyny: ");
int teamSize = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj liczbę dni wyprawy: ");
int tripLength = int.Parse(Console.ReadLine());

int fullRationsForAll = rationAmount / teamSize;
int fullRationsLeft = rationAmount % teamSize;
double dailyUsageOfRations = (rationAmount / tripLength);
double dailyUsageOfRationsPerPerson = (rationAmount / tripLength) / teamSize;

Console.WriteLine("Ile pełnych racji otrzyma każdy członek drużyny: " + fullRationsForAll);
Console.WriteLine("Racjii pozostanie po równym podziale: " + fullRationsLeft);
Console.WriteLine($"Ile racjii diennie przypadnie na całą drużynę: {dailyUsageOfRations:F2}");
Console.WriteLine($"Ile racjii diennie przypadnie średnio na jedną osobę: {dailyUsageOfRationsPerPerson:F2}");