Console.WriteLine("AULA DE TIPOS PRIMITIVOS EM C#\n");


var x=2; // Na declaracao var ele deve ter algum valor inicializado para que o sistema possa efetuar a escolha do tipo da variavel em questão

int y; // No caso da inicialização com o tipo não é necessário que haja um valor pré estabelecido para a variável




// TIPO BYTE (apenas positivos) *** OCUPA APENAS 1 BYTE DE MEMORIA
// O tipo byte vai de 0 a 255 e NÃO ADMITE NUMEROS NEGATIVOS
Console.WriteLine("O tipo byte vai de " + byte.MinValue + " até " + byte.MaxValue);


// TIPO SBYTE *** OCUPA APENAS 1 BYTE DE MEMORIA
// O tipo sbyte vai de -128 até 127
Console.WriteLine("\nO tipo sbyte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue);


// TIPO SHORT *** OCUPA 2 BYTES DE MEMORIA
// O tipo short vai de -32768 até 32767
Console.WriteLine("\nO tipo short vai de "+short.MinValue+" até "+short.MaxValue);


// TIPO USHORT (apenas positivos) *** OCUPA 2 BYTES DE MEMORIA
// O tipo ushort vai de 0 até 65535
Console.WriteLine("\nO tipo ushort vai de "+ushort.MinValue+" até "+ushort.MaxValue);


// TIPO INT *** OCUPA 4 BYTES DE MEMORIA
// O tipo int vai de -2147483648 até 2147483647
Console.WriteLine("\nO tipo int vai de "+int.MinValue+" até "+int.MaxValue);


// TIPO UINT - unsigned int (int sem sinal) (apenas positivos) *** OCUPA 4 BYTES DE MEMORIA
// O tipo uint vai de 0 até 4294967295
Console.WriteLine("\nO tipo uint vai de " + uint.MinValue + " até " + uint.MaxValue);


// TIPO LONG *** OCUPA 8 BYTES DE MEMORIA
// O tipo long vai de -9223372036854775808 até 9223372036854775807
Console.WriteLine("\nO tipo long vai de " + long.MinValue + " até " + long.MaxValue);


// TIPO ULONG - unsigned long (long sem sinal) *** OCUPA 8 BYTES DE MEMORIA
// O tipo ulong vai de 0 até 18446744073709551615
Console.WriteLine("\nO tipo ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue);


// TIPO CHAR


// TIPO STRING


// TIPO FLOAT *** OCUPA 32 BITS
// O tipo float vai de -3,4028235E+38 até 3,4028235E+38
// Todo float deve vir escrito (float) antes do numero ou f após
float media = (float)4.5;
float media1 = 5.2f;
Console.WriteLine("\nO tipo float vai de " + float.MinValue + " até " + float.MaxValue);


// TIPO DOUBLE *** OCUPA 64 BITS
// O tipo double vai de -1,7976931348623157E+308 até 1,7976931348623157E+308
Console.WriteLine("\nO tipo double vai de " + double.MinValue + " até " + double.MaxValue);


// TIPO DECIMAL *** OCUPA 128 BITS
// O tipo decimal vai de -79228162514264337593543950335 até 79228162514264337593543950335
// Todo decimal deve vir escrito (decimal) antes ou com a letra m no final
decimal estrela = 4.9847373723m;
decimal estrela1 = (decimal)4.9847373723;
Console.WriteLine("\nO tipo decimal vai de " + decimal.MinValue + " até " + decimal.MaxValue);


// TIPO BOOL *** Tipo lógico (V ou F)
bool aprovado=false;
Console.WriteLine("\nO tipo de aprovado é "+aprovado.GetType().Name);


// TIPO ENUM


// TIPO STRUCT


// TIPO OBJECT

