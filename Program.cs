
void main()
{
    Console.WriteLine("Welcome to the game NumberGuesser");
    Console.WriteLine("Choose a number between 1 and 100\n");
    int NumberToGuess= AleatoryNumberGenerator();
    ReceivePlayerNumber(NumberToGuess);

}

int AleatoryNumberGenerator()
{
    Random NumAleatory = new();
    int valueInt = NumAleatory.Next(1,101);
    return valueInt;
 }

int ReceivePlayerNumber(int AleatoryNumber)
{
    
   // Console.WriteLine($"{AleatoryNumber}");
    Console.Write("Insert a Number between 1 and 100: ");
    string PlayerNumber = Console.ReadLine()!; // "!" https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference
    Console.WriteLine(PlayerNumber);
    if(AleatoryNumber == int.Parse(PlayerNumber))
    {
        Console.WriteLine("You Win!");
    }
    else
    {
        int i = 0;
        do
        {
            Console.WriteLine("Try again");
            PlayerNumber = Console.ReadLine()!;
            if(AleatoryNumber == int.Parse(PlayerNumber))
            {
                Console.WriteLine("You Win!");
                return 0;
            }
            else { i++; }
        }
        while(i<5);
        Console.WriteLine("You Lose!");
    }
    return 0;
}


main();