namespace EspacioEmpleado;
public enum Cargos
{
  Auxiliar,
  Administrativo,
  Ingeniero,
  Especialista,
  Investigador,
}
public class Empleado
{
  private string nombre;
  private string apellido;
  private DateTime fechaNacimiento;
  private char estadoCivil;
  private DateTime fechaIngreso;
  private double sueldoBasico;
  private Cargos cargo;

  public Empleado(string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso,Cargos cargo)
  {
    this.nombre = nombre;
    this.apellido = apellido;
    this.fechaNacimiento = fechaNacimiento;
    this.fechaIngreso = fechaIngreso;
    this.cargo = cargo;
  }
  public string Nombre { get => nombre; }
  public string Apellido { get => apellido; }
  public DateTime FechaNacimiento { get => fechaNacimiento; }
  public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
  public DateTime FechaIngreso { get => fechaIngreso; }
  public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
  public Cargos Cargo { get => cargo; }
  public int AniosAntiguedad()
  {
    return DateTime.Today.Year - fechaIngreso.Year;
  }
  public int Edad()
  {
    int cumplio = (DateTime.Today.Month <= fechaNacimiento.Month && DateTime.Today.Day <= fechaNacimiento.Day) ? 1 : 0;
    return DateTime.Today.Year - FechaNacimiento.Year - 1 + cumplio;
  }
  public int AniosAJubilarse()
  {
    return 65 - Edad();
  }
  public double Salario()
  {
    double salario = 0;
    int antiguedad = AniosAntiguedad();
    double adicional = antiguedad < 20 ? 0.01 * antiguedad : 0.25;
    salario = sueldoBasico * adicional;
    if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
      salario *= 1.5;
    if (EstadoCivil == 'c')
      salario += 150000;

    salario += sueldoBasico;
    return salario ;
  }
}
  