// See https://aka.ms/new-console-template for more information
/*
*  CONVERSÃO DE TIPOS EM C#
*/

// TIPOS DE CONVERSAO

/* Conversao implicita
*
* Conversao explicita (utilizando o typecast)
*
* Conversao por classes Auxiliares
*/


// *** CONVERSAO IMPLICITA

// Conversao implicita int -> float

int a=8;
float b = a;
Console.WriteLine("O valor de a é "+a+" do tipo "+a.GetType().Name);
Console.WriteLine("O valor de b é "+b+" do tipo "+b.GetType().Name);


// Conversao implicita float -> int, nesse caso a conversao implicita nao funciona, precisaremos utilizar a conversao explicita

/*
float c = 8f;
int d = c;
Console.WriteLine("O valor de c é " + c + " do tipo " + c.GetType().Name);
Console.WriteLine("O valor de d é " + d + " do tipo " + d.GetType().Name);
*/




// Conversao explicita float -> int, nesse caso a conversao implicita nao funciona, precisaremos utilizar a conversao explicita


float c = 8;
int d = (int)c;
Console.WriteLine("\nO valor de c é " + c + " do tipo " + c.GetType().Name);
Console.WriteLine("O valor de d é " + d + " do tipo " + d.GetType().Name);


// Conversao explicita float -> int, mas agora convertemos um numero com casas decimais para int, o resultado sera o "truncamento" do numero, preservando apenas a parte inteira.

float e = 8.75f;
int f = (int)c;
Console.WriteLine("\nO valor de e é " + e + " do tipo " + e.GetType().Name);
Console.WriteLine("O valor de f é " + f + " do tipo " + f.GetType().Name);


// Conversao utilizando classes Auxiliares float -> int, agora utilizaremos metodos de classes auxiliares para efetuar as conversoes;

float g = 5;
int h = Convert.ToInt16(g);

Console.WriteLine("\nO valor de g é " + g + " do tipo " + g.GetType().Name);
Console.WriteLine("O valor de h é " + h + " do tipo " + h.GetType().Name);