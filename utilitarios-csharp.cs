System.Console.Out.WriteLine("mensagem"); // Imprimir em console pulando linha.
System.Console.Out.Write("mensagem"); // Imprimir em console sem pular linha.

System.Console.ReadKey(); // Comando para ficar aguardando aperto de tecla para finalizar programa

/*

Como importamos a biblioteca System podemos suprimir esse comando nas opções acima
ficando apenas Console.Out.WriteLine("mensagem");
ou até mesmo suprimir o Out ficando apenas Console.WriteLine("mensagem"); e Console.ReadKey();

se nós adicionarmos a biblioteca 
using static System.Console;
podemos suprimir tudo ficando apenas WriteLine("mensagem");
e ReadKey();

*/
