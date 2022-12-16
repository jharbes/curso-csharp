// See https://aka.ms/new-console-template for more information

// FORMATACAO DE STRINGS INTERPOLADAS EM C#


string nome = "Gustavo";
float sal = 550.75556f;
int idade = 22;

Console.WriteLine($"Muito prazer em te conhecer {nome,20}!!!"); // Mostrar o nome usando 20 letras(contando os caracteres do nome inclusive). (Cria um espaço na frente para completar o numero de letras, alinhando a variavel a direita, para alinhar a esquerda basta colocar um numero negativo conforme exemplo abaixo)
Console.WriteLine($"\nMuito prazer em te conhecer {nome,-20}!!!");

Console.WriteLine($"\nO {nome,-10} ganha {sal,20:C} por mês");

Console.WriteLine($"\nO {nome,-10} ganha {sal,20:C3} por mês"); // No caso o C3 faz com que o formato monetario tenha 3 casas decimais, como é utilizado por exemplo nos postos de gasolina.

/* FORMATACAO DE NUMEROS EM C#
 * 
 *  :C  -   Monetario (currency)
 *  :D  =   Decimal
 *  :N  -   Numero (real)
 *  :E  -   Cientifico
 *  :X  -   Hexadecimal
 *  
 */

Console.WriteLine($"\nO {nome,-10} tem {idade,-5:D3} anos e ganha {sal,20:C2} por mês"); // O D3 completa o numero com zeros na frente caso o numero em questao tenha menos algarismos que o numero escolhido apos a letra D.

int num = 13;

Console.WriteLine($"\nO número {num} em hexadecimal é {num:X}");

float val = 44679.003f;

Console.WriteLine($"\nO valor foi {val:N2}."); // Nesse caso ele formata o numero com duas casas decimais, virgula nas casas decimais e ponto na casa dos milhares

Console.WriteLine($"\nO valor foi {val:E}."); // Com saida em notacao cientifica