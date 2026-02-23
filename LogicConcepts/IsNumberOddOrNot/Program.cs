var numberString = String.Empty;
do  //do =>ciclo hacer o haga
{
    Console.Write("Ingrese numero o la palabra 'Salir' para salir: ");
    numberString = Console.ReadLine(); // number = "45" ---  number = 45
    if (numberString!.ToLower() == "salir")  // ToLower es convertir a minuscula
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt}, es par");  // $ interpolar combinar texto con numeros
        }
        else
        {
            Console.WriteLine($"El número {numberInt}, es impar");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString}, no es un número entero.");
    }
} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over");

