/*
 * LEITURA DE DADOS VIA TECLADO EM C#
 */

string nome;
Console.Write("Qual é o seu nome? ");
nome = Console.ReadLine(); // Comando para ler uma linha em string no teclado

Console.WriteLine("Muito prazer em te conhecer "+nome);

// LENDO NÚMEROS PELO TECLADO EM C#

int n=Convert.ToInt32(Console.ReadLine()); // Convertendo de string para Inteiro

int d = n * 2;

Console.WriteLine("O dobro de "+n+" é "+d);

int n = 0;

Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out n); // Aqui pedimos que o sistema "tente" converter, caso nao seja possível ele nao finalizará a operação.

int d = n * 2;

Console.WriteLine("O dobro de "+n+" é "+d);

