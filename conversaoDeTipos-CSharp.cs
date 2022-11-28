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
float c = 8;
int d = c;
Console.WriteLine("O valor de c é " + c + " do tipo " + c.GetType().Name);
Console.WriteLine("O valor de d é " + d + " do tipo " + d.GetType().Name);
*/


// Conversao explicita float -> int, nesse caso a conversao implicita nao funciona, precisaremos utilizar a conversao explicita


float c = 8;
int d = (int)c;
Console.WriteLine("O valor de c é " + c + " do tipo " + c.GetType().Name);
Console.WriteLine("O valor de d é " + d + " do tipo " + d.GetType().Name);
