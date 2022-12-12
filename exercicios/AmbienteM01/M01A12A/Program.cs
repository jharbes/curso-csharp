// See https://aka.ms/new-console-template for more information

// STRING INTERPOLADAS EM C#

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Olá "+nome+"! Tudo bem?");

// EXEMPLO com interpolacao:

Console.WriteLine($"Olá {nome}! Tudo bem?");


// Caso voce nao queira que interpole utilize o @ no lugar do $:

