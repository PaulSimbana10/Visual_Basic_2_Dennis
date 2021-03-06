using ClassLibrary1;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.DatosIniciales;

namespace Consola
{
    internal class Grabar
    {

        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            // Extraer del diccionario las listas
            var listaConfiguracion = (List<Configuracion>)listas[ListasTipo.Configuracion];
            var listaPeriodos = (List<Periodo>)listas[ListasTipo.Periodos];
            var listaMaterias = (List<Materia>)listas[ListasTipo.Materias];
            var listaCarreras = (List<Carrera>)listas[ListasTipo.Carreras];
            var listaSubMallas = (List<Malla>)listas[ListasTipo.SubMallas];
            var listaMallas = (List<Malla>)listas[ListasTipo.Mallas];
            var listaNiveles = (List<Nivel>)listas[ListasTipo.Niveles];

            

            //Grabar
            AcademiaDB db = new AcademiaDB();

            db.carreras.AddRange(listaCarreras);
            db.periodos.AddRange(listaPeriodos);
            db.materias.AddRange(listaMaterias);
            db.configuracion.AddRange(listaConfiguracion);
            db.mallas.AddRange(listaSubMallas);
            db.mallas.AddRange(listaMallas);
            db.niveles.AddRange(listaNiveles);

            db.SaveChanges();
        }

    }
}
