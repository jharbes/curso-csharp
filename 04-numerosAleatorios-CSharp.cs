// NUMEROS ALEATORIOS EM C#


Random gerador = new Random();

int n = gerador.Next(); // Gera um numero aleatorio qualquer e guarda na variavel n

Console.WriteLine("Acabei de gerar o numero aleatorio "+n);


int n1=gerador.Next(100); // Nesse caso gera um numero aleatorio considerando apenas os 100 primeiros numeros, ou seja, de 0 a 99.

Console.WriteLine("\nAcabei de gerar o numero aleatorio " + n1);


int n2 = gerador.Next(90, 100); // Nesse caso será gerado um numero aleatorio na faixa de 90 até 99.

Console.WriteLine("\nAcabei de gerar o numero aleatorio " + n2);