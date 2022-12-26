// See https://aka.ms/new-console-template for more information

Console.Write("Digite um número real: ");
float num = 0;
float.TryParse(Console.ReadLine(), out num);

Console.WriteLine(num);
