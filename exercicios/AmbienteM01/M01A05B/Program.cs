// See https://aka.ms/new-console-template for more information

byte idade = 25;

ushort publico = 45_239;

Console.WriteLine("Teste de "+publico);


// Todo float deve vir escrito (float) antes do numero ou f após
float media = (float)4.5;
float media1 = 5.2f;


// Todo decimal deve vir escrito (decimal) antes ou com a letra m no final
decimal estrela = 4.9847373723m;
decimal estrela1 = (decimal)4.9847373723;


bool aprovado=false;
Console.WriteLine("\nO tipo de aprovado é "+aprovado.GetType().Name);


var x=2; // Na declaracao var ele deve ter algum valor inicializado para que o sistema possa efetuar a escolha do tipo da variavel em questão

int y; // No caso da inicialização com o tipo não é necessário que haja um valor pré estabelecido para a variável