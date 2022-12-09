// COMANDOS TEMPORIZADORES EM C#

using System.Threading;

Thread.Sleep(2000); // tempo em milisegundos

Console.WriteLine("Testando temporizador");

int ano = DateTime.Now.Year;
int mes = DateTime.Now.Month;
int dia = DateTime.Now.Day;

Console.WriteLine("\nA data atual é dia " + dia);
Thread.Sleep(1500);

Console.WriteLine("\n do mês " + mes);
Thread.Sleep(1500);

Console.WriteLine("\n do ano " + ano);

System.Threading.Thread.Sleep(1000); // Comando inteiro sem a importacao da biblioteca System.Threading


// TEMPORIZADORES EM WINDOWS FORM

using System.Threading.Tasks;


lblMsg.Text = "Olá";

await Task.Delay(2000);

lblMsg.Text+=", tudo bem?";