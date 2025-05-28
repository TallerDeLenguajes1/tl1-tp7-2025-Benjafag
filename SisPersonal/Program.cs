// See https://aka.ms/new-console-template for more information
using EspacioEmpleado;



Empleado[] empleados = new Empleado[3];

DateTime nacimiento = new DateTime(2004, 7, 1);
DateTime ingreso = new DateTime(2010, 5, 20);
empleados[0] = new Empleado("Benjamin", "Fagioli", nacimiento, ingreso, Cargos.Investigador);
empleados[0].EstadoCivil = 's';
empleados[0].SueldoBasico = 200000;

nacimiento = new DateTime(1983, 12, 1);
ingreso = new DateTime(2014, 4, 15);
empleados[1] = new Empleado("Matias", "Calderon", nacimiento, ingreso,Cargos.Ingeniero);
empleados[1].EstadoCivil = 'c';
empleados[1].SueldoBasico = 450000;

nacimiento = new DateTime(1995, 5, 30);
ingreso = new DateTime(2019, 7, 15);
empleados[2] = new Empleado("Gonzalo", "Jamardo", nacimiento, ingreso, Cargos.Especialista);
empleados[1].EstadoCivil = 's';
empleados[1].SueldoBasico = 650000;

double salariosTotal = 0;
foreach (Empleado empleado in empleados)
{
  salariosTotal += empleado.Salario();
}
Console.WriteLine($"Monto total para salarios: ${salariosTotal.ToString("n")}");

int masCercano = 65;
Empleado resultado = null;
foreach (Empleado empleado in empleados)
{
  if (empleado.AniosAJubilarse() < masCercano)
  {
    resultado = empleado;
    masCercano = resultado.AniosAJubilarse();
   }

}
Console.WriteLine($"EMPLEADO MAS PROXIMO A JUBILARSE");
Console.WriteLine($"{resultado.Apellido} {resultado.Nombre}");
Console.WriteLine($"{resultado.AniosAntiguedad()} años de antiguedad\t{resultado.Edad()} años de edad\t{resultado.AniosAJubilarse()} años para jubilarse");