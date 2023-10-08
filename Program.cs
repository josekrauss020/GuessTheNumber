
void main()
{
    Console.WriteLine("Bem vindo ao jogo NumberGuesser");
    Console.WriteLine("O Numero pode ser entre 1 e 100\n");
    int NumberToGuess= AleatoryNumberGenerator();
    //Console.WriteLine(NumberToGuess);
    ReceivePlayerNumber(NumberToGuess);

}

int AleatoryNumberGenerator()
{
    Random NumAleatory = new();
    int valorInteiro = NumAleatory.Next(1,101);
    //Console.WriteLine(valorInteiro);
    return valorInteiro;
 }

int ReceivePlayerNumber(int AleatoryNumber)
{
    Console.WriteLine("terceira função:\n");
    Console.WriteLine($"{AleatoryNumber}");
    return 0;
}


main();