string palavraSecreta;
char letraDigitada;
bool ContemLetra;

Console.WriteLine("--- Jogo da forca ---");

Console.Write("Qual a palavra secreta: ");
palavraSecreta = Console.ReadLine()!.Trim().ToLower();

Console.Write("Qual a letra? ");
letraDigitada = char.ToLower(Console.ReadKey().KeyChar);
Console.ReadKey();

ContemLetra = palavraSecreta.Contains(letraDigitada);

Console.WriteLine($"\nA letra \"{letraDigitada}\" existe na palavra secreta => {ContemLetra}");

