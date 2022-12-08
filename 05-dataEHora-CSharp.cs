// DATA E HORA EM C#
Console.WriteLine("DATA E HORA EM C#\n");

int ano=DateTime.Now.Year;

int mes=DateTime.Now.Month;

int dia=DateTime.Now.Day;

Console.WriteLine("A data atual é dia "+dia+" do mês "+mes+" do ano "+ano);


int hora=DateTime.Now.Hour;

int minuto=DateTime.Now.Minute;

int segundo=DateTime.Now.Second;

Console.WriteLine("\nA hora atual é " + hora + " hora(s), " + minuto + " minuto(s) e " + segundo + " segundo(s).\n");