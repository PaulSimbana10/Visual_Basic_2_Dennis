using System;
using System.Collections.Generic;
using Modelo.entidades;
using ModeloDB;

namespace consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Category cat1 = new Category()
            {
                Name = "drama",
                lastUpdate = "drama"
            };
            Category cat2 = new Category()
            {
                Name = "Animacion",
                lastUpdate = "Animacion"
            };
            Category cat3 = new Category()
            {
                Name = "Accion",
                lastUpdate = "Accion"
            };



            Actor act1 = new Actor()
            {
                firstName = "Paulo",
                lastName = "Marquez",
                lastUpdate = "Flash"
            };
            Actor act2 = new Actor()
            {
                firstName = "Gabriela",
                lastName = "Mosquera",
                lastUpdate = "Luci"
            };
            Actor act3 = new Actor()
            {
                firstName = "Emilio",
                lastName = "Granda",
                lastUpdate = "Laberinto"
            };

            Language legE = new Language()
            {
                name = "Frances",
                lastUpdate = "Frances"
            };
            Language legI = new Language()
            {
                name = "Mandarin",
                lastUpdate = "Mandarin"
            };


            Film film1 = new Film()
            {
                title = "Flash",
                description = "Tierras infinitas",
                releaseYear = new DateTime(2021, 11, 02),
                rentalDuration = "1 dia",
                rentalRate = "20%",
                length = "20",
                replacementCost = 15.00M,
                rating = "Buena",
                lastUpdate = "si",
                specialFeatures = "Animationficction",
                fullText = "que mejora sustancialmente en relación a lo visto en 'Rey de los monstruos' y deja instantáneas realmente espectaculares que merecen ser disfrutadas en una pantalla lo más grande posible —y con un sistema de sonido que permita escuchar la brutal banda sonora de Junkie XL en todo su esplendor",
                Language = new List<Language>()
                {
                    legE

                }


            };
            Film film2 = new Film()
            {
                title = "Luci",
                description = "EL legado hacia un futuro cercano",
                releaseYear = new DateTime(2021, 10, 02),
                rentalDuration = "2 dia",
                rentalRate = "10%",
                length = "10",
                replacementCost = 10.00M,
                rating = "Medianamente buena",
                lastUpdate = "si",
                specialFeatures = "La buena escena",
                fullText = "narra la aventura de Neo, un joven hacker que es convocado por el movimiento de resistencia liderado por Morfeo, que lucha contra la dominación de los seres humanos por las máquinas.",
                Language = new List<Language>()
                {
                    legI

                }


            };
            Film film3 = new Film()
            {
                title = "Laberinto",
                description = "El gran escape hacia una libertad",
                releaseYear = new DateTime(2020, 10, 02),
                rentalDuration = "3 dia",
                rentalRate = "30%",
                length = "30",
                replacementCost = 16.00M,
                rating = "Mala",
                lastUpdate = "si",
                specialFeatures = "Cambio ritico trama",
                fullText = "contiene cuatro aventuras distintas. Las instrucciones que incluye son algo confusas, pues antes de empezar a jugar es muy difícil comprender el sistema de juego.",
                Language = new List<Language>()
                {
                    legI

                }


            };


            PruebaDB res = new PruebaDB();
            res.actors.Add(act1);
            res.SaveChanges();



        }
    }
}