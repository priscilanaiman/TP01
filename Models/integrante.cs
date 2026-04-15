public class integrante
{
    private int DNI;
    private string nombre;
    private DateTime FechaDeNacimiento;
    private List<string> Familiares;
    private List<string> Intereses;

 public integrante (int dni, string nombre,DateTime FechaDeNacimiento, List<string> Familiares, List<string> Intereses)
 {
    this.DNI = dni;
    this.nombre = nombre;
    this.FechaDeNacimiento = FechaDeNacimiento;
    this.Familiares = Familiares;
    this.Intereses = Intereses;

 }

}