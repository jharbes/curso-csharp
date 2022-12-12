// See https://aka.ms/new-console-template for more information

// INTERPOLACAO COM NUMEROS

float sal = 0;

Console.Write("Qual é o seu salário? ");
float.TryParse(Console.ReadLine(), out sal);

Console.WriteLine($"Você ganha {sal} por mês!");

Console.WriteLine($"Você ganha {sal:C} por mês!"); // O :C ja formata o valor para moeda corrente local, ou seja , em reais,   porque o sistema no caso está localizado no Brasil, se fosse localizado nos EUA a saida seria em Dólar.

