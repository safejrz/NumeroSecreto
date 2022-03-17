var min = 1;
var max = 30;
var vidas =6;

Random rnd = new Random();
Console.BackgroundColor = (ConsoleColor)rnd.Next(1, 15);
Console.Clear();
Console.WriteLine($"Hola, Adivina el numero secreto ({min}-{max}):");

var numeroSecreto = rnd.Next(min, max);
int x = 0;

while (x != numeroSecreto && vidas >= 0)
{
    
    Console.ForegroundColor = (ConsoleColor)rnd.Next(1,15);
    if (x != 0)
      
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
  
    var input = Console.ReadLine();
    int.TryParse(input, out x);
    vidas = vidas - 1;
    
    if(x == 0)
        Console.WriteLine($"ERROR eso no es un numero ...rata");
    //update1

    if (vidas <= 0)
        Console.WriteLine($"PERDISTE");
    else
    {    
        Console.WriteLine(r + "  felicidades ganaste el juego");
        Console.WriteLine("Quieres jugar otra vez? ('Y' para si)");
    }
        var x = Console.ReadLine().Substring(0, 1).ToUpper();
        otraVez = x.ToCharArray()[0];
}
while (otraVez == 'Y');
