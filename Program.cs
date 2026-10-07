static void Main(string[] args)
{

    FirstQuestion();
    
}












static void FirstQuestion()
{
    Console.WriteLine("==========================");
    Console.WriteLine("==========================");
    Console.WriteLine("====TEL AVIV SIMULATOR====");
    Console.WriteLine("==========================");
    Console.WriteLine("==========================");

    Console.WriteLine("Do you support Big Yahu? Type 1 for yes and 2 for no");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 2)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("=====================================");
        Console.WriteLine("=====================================");
        Console.WriteLine("+++EXECUTED BY DONALDINA TRUMPOVNA+++");
        Console.WriteLine("======================================");
        Console.WriteLine("======================================");
        Console.WriteLine("======================================");
        Environment.Exit(0);
    }
    else if (choice == 1)
    {
        Console.WriteLine("===============================");
        Console.WriteLine("===============================");
        Console.WriteLine("===============================");
        Console.WriteLine("TRUE SOLDIER OF ISRAEL! SHALOM!");
        Console.WriteLine("===============================");
        Console.WriteLine("===============================");
        Console.WriteLine("===============================");
    }
    else
    {
        Console.WriteLine("==========================");
        Console.WriteLine("==========================");
        Console.WriteLine("======TEL AVIV SCARED=====");
        Console.WriteLine("==========================");
        Console.WriteLine("==========================");
        Environment.Exit(0);
    }
}
