using Modelo.Colegio;
using Modelo.Entidades;
using ModeloBD;
using System;

namespace ConsoleApp
{

    internal class Program

    {

        static void Main(String[] args)
        {
            
            Alumno Pedro = new Alumno() {Nombrecompl="Pablo Villafuerte",alumnoId=1, Cedula="1718082488", GradeId=1};



            Periodo Pao2019_2020 = new Periodo()
            {
                Ciclos = new List<Ciclo>(),
                FechaFin = new DateTime(2021, 3, 1),
                FechaInicio = new DateTime(2021, 31, 8),
                Pagos = new List<Pago>(),
                PeriodoId = new(),
            };


            //clase pago
            Grado pagoPao2019_2020 = new Grado()
            {
                //Alumno = Pedro,
                GradoId = 1,
                nomgrado = "Quinto",
                Seccion = "Vespertina",
                






            };
            ColegioBD db = new ColegioBD();
            db.Grados.Add(pagoPao2019_2020);
            db.SaveChanges();

        }
    }
}