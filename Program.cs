Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("*** Múltiplo ***");
Console.WriteLine();
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Digite um número: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.Write("Avaliar se é múltiplo de: ");
int n2 = Convert.ToInt32(Console.ReadLine());


if (n1 % n2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n{n1} é múltiplo de {n2}");
    Console.ResetColor();

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n{n1} não é múltiplo de {n2}");
    Console.ResetColor();

}
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine();
Console.WriteLine("Clique em alguma tecla para ver outros múltiplos...");
Console.ReadKey();
Console.ResetColor();
Console.Clear();
