// See https://aka.ms/new-console-template for more information

// FORMATACAO DE STRINGS INTERPOLADAS EM C#


string nome = "Gustavo";
Console.WriteLine($"Muito prazer em te conhecer {nome,20}!!!"); // Mostrar o nome usando 20 letras. (Cria um espaço na frente para completar o numero de letras, alinhando a variavel a direita, para alinhar a esquerda basta colocar um numero negativo conforme exemplo abaixo)
Console.WriteLine($"\nMuito prazer em te conhecer {nome,-20}!!!");

