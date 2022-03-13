// See https://aka.ms/new-console-template for more informationwhile
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
    {
        if (x > numeroSecreto)
            Console.WriteLine("▼ --");
        else
            Console.WriteLine("▲ ++");
        if (x > max)
            Console.WriteLine($"ERROR El numero no puede ser mayor a {max}");
        if (x < min)
            Console.WriteLine($"ERROR El numero no puede ser menor a {min}");
    }

    var input = Console.ReadLine();
    int.TryParse(input, out x);
    vidas = vidas - 1;
    
    if(x == 0)
        Console.WriteLine($"ERROR eso no es un numero ...rata");
    //update1
}

if (vidas <= 0)
    Console.WriteLine($"PERDISTE");
else
    Console.WriteLine($"Felicidades! {x} es el numero secreto");
