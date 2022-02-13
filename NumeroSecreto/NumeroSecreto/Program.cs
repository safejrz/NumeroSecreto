// See https://aka.ms/new-console-template for more information
var min = 1;
var max = 30;

Console.WriteLine($"Hola, Adivina el numero secreto ({min}-{max}):");
Random rnd = new Random();
var numeroSecreto = rnd.Next(min, max);
int x = 0;

while (x != numeroSecreto)
{
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
    if(x == 0)
        Console.WriteLine($"ERROR eso no es un numero ...rata");
    //update1
}

Console.WriteLine($"Felicidades! {x} es el numero secreto");
