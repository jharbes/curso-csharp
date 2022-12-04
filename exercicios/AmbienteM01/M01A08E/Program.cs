// See https://aka.ms/new-console-template for more information

int n = 0;

Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out n); // Aqui pedimos que o sistema "tente" converter, caso nao seja possível ele nao finalizará a operação.

int d = n * 2;

Console.WriteLine("O dobro de "+n+" é "+d);