// See https://aka.ms/new-console-template for more information

var n = 0; // Quando usamos o var o proprio sistema define qual tipo será nossa variável
           // o que as vezes pode nao ser a melhor escolha

Console.WriteLine("A variável n tem "+n);
Console.WriteLine("n é to tipo "+n.GetType().Name);


byte x= 0; // Ocupa menos memória
Console.WriteLine("\nx é do tipo "+x.GetType().Name);


var nome = "Jorge";
Console.WriteLine("\nA variável nome tem "+nome);
Console.WriteLine("nome é do tipo "+nome.GetType().Name);