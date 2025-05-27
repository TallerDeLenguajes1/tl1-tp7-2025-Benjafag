using EspacioCalculadora;

int seleccion = 0;
Console.WriteLine("Ingrese el numero inicial: ");
string ingresado = Console.ReadLine();
double num;
bool conversion = double.TryParse(ingresado, out num);
if (conversion) {
  var miCalculadora = new Calculadora(num);
  do
  {
    mostrarMenu();
    ingresado = Console.ReadLine();
    conversion = int.TryParse(ingresado, out seleccion);
    if (conversion && seleccion >= 1 && seleccion <= 5) {
      if (seleccion != 5)
      {
        ingresado = pedirNumero();
        conversion = double.TryParse(ingresado, out num);
      }
      if (conversion)
      {
        switch (seleccion)
        {
          case 1: miCalculadora.Sumar(num); break;
          case 2: miCalculadora.Restar(num); break;
          case 3: miCalculadora.Multiplicar(num); break;
          case 4: miCalculadora.Dividir(num); break;
          case 5: miCalculadora.Limpiar(); break;
          default: Console.WriteLine("Operacion no válida"); break;
        }
        mostrarResultado(miCalculadora);
      }
      else
      {
        Console.WriteLine("Número no válido");
      }
    } else {
      Console.WriteLine("Operacion no válida");
    }
  } while (seleccion != 0);
} else {
  Console.WriteLine("Número no válido");
}

void mostrarMenu()
{
  Console.WriteLine("Operacion:");
  Console.WriteLine("[1] Sumar");
  Console.WriteLine("[2] Restar");
  Console.WriteLine("[3] Multiplicar");
  Console.WriteLine("[4] Dividir");
  Console.WriteLine("[5] Limpiar");
}
string pedirNumero()
{
  Console.WriteLine("Ingrese el numero: ");
  return Console.ReadLine();

}
void mostrarResultado(Calculadora calc)
{
  Console.WriteLine($"Resultado: {calc.Resultado}");
}