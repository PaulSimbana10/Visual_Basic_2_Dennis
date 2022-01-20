



using Modelo.Colegio;
using ModeloBD;

namespace  Dennis_proyectoVB
{

    public class Dennis_
    {
        static void Main(string[] args)
        {
            // 1.- Estudiante
            Alumno estPedro = new Alumno() { Nombrecompl = "Pedro Infante" };
            Alumno estJuan = new Alumno() { Nombrecompl = "Juan Mera" };
            Alumno estMaria = new Alumno() { Nombrecompl = "María Blanco" };
            List<Alumno> lstEstudiantes = new List<Alumno>()
            {
                estJuan, estMaria, estPedro
            };

            ColegioBD bd = new ColegioBD();
            bd.Add(estJuan);
            bd.SaveChanges();








        }
    }
}