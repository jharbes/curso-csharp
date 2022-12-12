// STRING INTERPOLADAS EM C#

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Olá "+nome+"! Tudo bem?");

// EXEMPLO com interpolacao, basta adicionar o $ na frente da string a ser digitada:

Console.WriteLine($"Olá {nome}! Tudo bem?");


// Caso voce nao queira que interpole utilize o @ no lugar do $:


// INTERPOLACAO COM NUMEROS

float sal = 0;

Console.Write("Qual é o seu salário? ");
float.TryParse(Console.ReadLine(), out sal);

Console.WriteLine($"Você ganha {sal} por mês!");

Console.WriteLine($"Você ganha {sal:C} por mês!"); // O :C ja formata o valor para moeda corrente local, ou seja , em reais,   porque o sistema no caso está localizado no Brasil, se fosse localizado nos EUA a saida seria em Dólar.

