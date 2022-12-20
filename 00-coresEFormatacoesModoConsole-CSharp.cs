// CORES E FORMATACAO EM C#

Console.WriteLine("Estud\tonauta"); // Tabulacao, como se apertasse a tecla tab.

Console.WriteLine("Estud\bonauta"); // Backspace, volta uma letra

Console.WriteLine("Estudonauta\a"); // Alerta, faz barulho sempre que encontrar o \a.

Console.WriteLine("Estudonau\rta"); // Retorno, retorna para o inicio da tela

Console.WriteLine("\\Estudonauta\\"); // \\ Mostra uma contrabarra

Console.WriteLine(@"\Estudonauta\"); // o arroba retira a formataçao de contrabarras da string.

Console.WriteLine("\"Estudonauta\""); // Maneira de mostrar aspas dentro da string com \"

Console.WriteLine("\n\n");
Console.WriteLine("C# é\n\"SUPER\"\nFácil!\a");



Console.SetCursorPosition(20, 5); // Altera a posicao do cursor

Console.ForegroundColor = ConsoleColor.DarkGray; // Escolhe a cor da letra

Console.BackgroundColor = ConsoleColor.Yellow; // Escolhe a cor de fundo

Console.WriteLine("Olá querido(a) Estudonauta!");
Console.ReadKey();

Console.ResetColor(); // Reseta as cores utilizadas no terminal

Console.Clear();

Console.SetCursorPosition(10, 3); // Altera a posicao do cursor

Console.ForegroundColor = ConsoleColor.White;

Console.BackgroundColor = ConsoleColor.Blue;

Console.WriteLine("Tudo bem com você?");

Console.ResetColor();
Console.ReadKey();