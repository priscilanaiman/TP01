public class grupo
{
    private Dictionary<int, integrante> Integrantes = new Dictionary<int, integrante>();

    public grupo()
    {
        CargaDatosManual();
    }
    void CargaDatosManual()
    {
        List<string> Familiares1 = new List<string>(){"Papa:Juan", "Mama: Leo", "Hermano:Prisci"};
        List<string> Intereses1 = new List<string>(){"Futbol", "Ajedrez"};
        integrante I1 = new integrante(50233866, "Alfie", new DateTime(2000,2,15), Familiares1, Intereses1, "/imagenes/50233866.jfif");

        List<string> Familiares2 = new List<string>(){"Papa:Uner", "Mama: Luca", "Hermano: Scala"};
        List<string> Intereses2 = new List<string>(){"Pintar", "Comer"};
        integrante I2 = new integrante(50031557, "marto", new DateTime(2010,1,5), Familiares2, Intereses2, "/imagenes/50031557.jfif");
        Integrantes.Add(I1.getDni(), I1);
        Integrantes.Add(I2.getDni(), I2);
    }   
     
    public Dictionary<int, integrante> DevolverIntegrantes()
    {
        return this.Integrantes;
    }
    public integrante GetIntegrante(int dni)
    {
     if(Integrantes.ContainsKey(dni))
     {
        return Integrantes[dni];
     }
     else
     {
        return null;
     }
    }
}