public class integrante
{
    private int DNI;
    private string nombre;
    private DateTime FechaDeNacimiento;
    private List<string> Familiares;
    private List<string> Intereses;
    private string foto;

   public integrante (int dni, string nombre,DateTime FechaDeNacimiento, List<string> Familiares, List<string> Intereses, string foto)
   {
      this.DNI = dni;
      this.nombre = nombre;
      this.FechaDeNacimiento = FechaDeNacimiento;
      this.Familiares = Familiares;
      this.Intereses = Intereses;
      this.foto = foto;

   }
   public string getNombre()
   {
      return this.nombre;
   }

   public int getDni()
   {
      return this.DNI;
   }

   public string getFoto()
   {
      return this.foto;
   }
}