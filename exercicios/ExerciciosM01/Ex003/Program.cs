// See https://aka.ms/new-console-template for more information

Console.Write("Digite um número real: ");
float num = 0;
float.TryParse(Console.ReadLine(), out num);

Console.WriteLine("----------------------------------");

Console.WriteLine("Você digitou o número "+ string.Format("{0:0.000}", num));
Console.WriteLine("A parte inteiro do número é "+Math.Truncate(num));
Console.WriteLine("O número arredondado é "+Math.Round(num));
