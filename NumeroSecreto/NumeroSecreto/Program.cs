// See https://aka.ms/new-console-template for more information

var otraVez = 'Y';

do
{
    var min = 1;
    var max = 30;
    var r = 0;
    var random = new Random();


    Console.WriteLine($"Hola adivina el numero del {min} al {max}");
    var numeroSecreto = random.Next(min, max);

    while (r != numeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        if (r != 0)
        {
            if (r > numeroSecreto)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("baja el num.");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("sube el num.");
            }

        }

        var palabra = Console.ReadLine();
        int.TryParse(palabra, out r);
        if (r == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR eso no es un numero ...rata");
        }
    }

    Console.WriteLine(r + "  felicidades ganaste el juego");
    Console.WriteLine("Quieres jugar otra vez? ('Y' para si)");

    var x = Console.ReadLine().Substring(0, 1).ToUpper();
    otraVez = x.ToCharArray()[0];
}
while (otraVez == 'Y');