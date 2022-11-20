System.Console.Out.WriteLine("mensagem"); // Imprimir em console pulando linha.
System.Console.Out.Write("mensagem"); // Imprimir em console sem pular linha.

System.Console.ReadKey(); // Comando para ficar aguardando aperto de tecla para finalizar programa

System.Console.Clear(); // Limpa a tela de console

System.Console.SetCursorPosition(20, 5); // Altera a posicao do cursor

System.Console.ForegroundColor = ConsoleColor.DarkGray; // Escolhe a cor da letra

System.Console.BackgroundColor = ConsoleColor.Yellow; // Escolhe a cor de fundo

System.Console.ResetColor(); // Reseta as cores utilizadas no terminal

/*

Como importamos a biblioteca System podemos suprimir esse comando nas opções acima
ficando apenas Console.Out.WriteLine("mensagem");
ou até mesmo suprimir o Out ficando apenas Console.WriteLine("mensagem"); e Console.ReadKey();

se nós adicionarmos a biblioteca 
using static System.Console;
podemos suprimir tudo ficando apenas WriteLine("mensagem");
e ReadKey();

*/

Sequencias de escape em C#:

\n -> Nova linha, pula linha dentro de uma string.
\t -> Tabulacao, como se apertasse a tecla tab.
\b -> Backspace, volta uma letra
\a -> Alerta, faz barulho sempre que encontrar o \a.
\r -> Retorno, retorna para o inicio da tela
\\ -> Mostra uma contrabarra
\" -> Mostra aspas.
System.Console.Out.WriteLine(@"mensagem"); // O arroba na frente da string cancela qualquer formatacao feito com alguma sequencia de escape que tenha por ventura sido feita.


