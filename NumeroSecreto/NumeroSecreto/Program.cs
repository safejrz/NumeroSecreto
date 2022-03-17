var min = 1;
var max = 30;
var rnd = new Random();
var otraVez = 'Y';

do
{
    var vidas = 6;
    var numeroSecreto = rnd.Next(min, max);
    int r = 0;

    Console.BackgroundColor = (ConsoleColor)rnd.Next(0, 7);
    Console.Clear();
    Console.ForegroundColor = (ConsoleColor)rnd.Next(8, 15);
    Console.WriteLine($"Hola adivina el numero del {min} al {max}");

    while (r != numeroSecreto && vidas >= 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        if (r != 0)
        {
            if (r > numeroSecreto)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("▼▼ baja el num. ▼▼");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("▲▲ sube el num. ▲▲");
            }
        }

        var input = Console.ReadLine();
        int.TryParse(input, out r);
        vidas = vidas - 1;
        if (r == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR eso no es un numero ...rata");
        }
    }

    if (vidas <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"PERDISTE");
    }
    else
        Console.WriteLine(r + "  felicidades ganaste el juego");

    Console.WriteLine("Quieres jugar otra vez? ('Y' para si)");
    var x = Console.ReadKey().KeyChar.ToString().ToUpper();
    otraVez = x.ToCharArray()[0];
}
while (otraVez == 'Y');

Console.WriteLine($"\n\nAdios!\n");
