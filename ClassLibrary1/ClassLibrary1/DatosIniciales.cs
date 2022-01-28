using Modelos.Entidades;

namespace ClassLibrary1
{
    public class DatosIniciales
    {
        public enum ListasTipo
        {
            Configuraciones, Estados, Estudiantes,
            Pagos, PagosPorPeriodos, Penalizaciones,
            Periodos, TiposPagos,
            Configuracion,
        }

        public Dictionary<ListasTipo, object> Carga()
        {

            // --------------------------------------------
            // Lista de Periodos
            // --------------------------------------------
            #region
            // Periodo 2020-PA=2
            Periodo p2020_PAO1 = new Periodo()
            {
                FechaInicio = new DateTime(2020, 3, 1),
                FechaFin = new DateTime(2020, 9, 30),

            };
            // Periodo 2020-PA=2
            Periodo p2020_PAO2 = new Periodo()
            {
                FechaInicio = new DateTime(2020, 9, 1),
                FechaFin = new DateTime(2021, 3, 31),

            };
            // Periodo 2021-PA=1
            Periodo p2021_PAO1 = new Periodo()
            {
                FechaInicio = new DateTime(2021, 4, 1),
                FechaFin = new DateTime(2021, 9, 1),

            };
            // Periodo 2020-PA=2
            Periodo p2021_PAO2 = new Periodo()
            {
                FechaInicio = new DateTime(2021, 9, 30),
                FechaFin = new DateTime(2022, 3, 31),

            };

            List<Periodo> listaPeriodos = new List<Periodo>()
            {
                p2020_PAO2,p2021_PAO1,p2021_PAO2
            };
            #endregion
            // --------------------------------------------
            // Configuracion
            // --------------------------------------------
            #region
            Configuracion config = new Configuracion()
            {
                TipoID = 1,
            };

            List<Configuracion> listaConfiguracion = new List<Configuracion>()
            {
                config
            };
            #endregion
            // --------------------------------------------
            // Lista de Estudiante
            // --------------------------------------------
            #region
            Estudiante estudiante1 = new Estudiante()
            {
                Cedula = "1718082488",
                Nombre = "Dennis Simbaña",
            };
            Estudiante estudiante2 = new Estudiante()
            {
                Cedula = "1718474545",
                Nombre = "Patricia Carrera",
            };
            Estudiante estudiante3 = new Estudiante()
            {
                Cedula = "1717954784",
                Nombre = "Augusto Cruz",
            };
            Estudiante estudiante4 = new Estudiante()
            {
                Cedula = "1718154785",
                Nombre = "Dilan Araque",
            };
            Estudiante estudiante5 = new Estudiante()
            {
                Cedula = "1718547848",
                Nombre = "Sonia de la Cruz",
            };



            List<Estudiante> listaEstudiante = new List<Estudiante>()
            {
                // lista est
                estudiante1, estudiante2, estudiante3, estudiante4, estudiante5

            };
            #endregion
            // --------------------------------------------
            // Lista de Tipos Pagos
            // --------------------------------------------
            #region
            TiposPago Tipo1 = new TiposPago()
            {
                Descuento = 25,
                NombreTipo = "Descuento por discapacidad"
            };
            TiposPago Tipo2 = new TiposPago()
            {
                Descuento = 50,
                NombreTipo = "Descuento por Enfermedad catastrófica"
            };
            TiposPago Tipo3 = new TiposPago()
            {
                Descuento = 95,
                NombreTipo = "Descuento por beca "
            };


            List<TiposPago> listatipospago = new List<TiposPago>()
            {
                Tipo1, Tipo2, Tipo3
            };
            #endregion


            // --------------------------------------------
            // Estados
            // --------------------------------------------
            #region
            Estados Estado1 = new Estados()
            {
                NombreEstado = "Pagos al dia",
                Descripcion = "Todos los convenios de pago estan cancelados al dia"

            };
            Estados Estado2 = new Estados()
            {
                NombreEstado = "Pagos demorados",
                Descripcion = "Pagos demorados se le aplicara su respectiva Penalización"
            };

            List<Estados> listaEstados = new List<Estados>()
            {
                Estado1, Estado2
            };
            #endregion
            // --------------------------------------------
            // Pagos
            // --------------------------------------------
            #region
            // Pago 1
            Pagos pago1 = new Pagos()
            {
                FechaPago = new DateTime(2021, 1, 15),
                ValorPago = 70,
                Descuento = false,
                Mora = true,
                TotalAPagar = 80,
                MetodoPago = "Depósito bancario",

            };
            Pagos pago2 = new Pagos()
            {
                FechaPago = new DateTime(2021, 1, 20),
                ValorPago = 85,
                Descuento = true,
                Mora = false,
                TotalAPagar = 68,
                MetodoPago = "Transferencia bancaria",

            };

            Pagos pago3 = new Pagos()
            {
                FechaPago = new DateTime(2021, 2, 01),
                ValorPago = 90,
                Descuento = false,
                Mora = true,
                TotalAPagar = 102,
                MetodoPago = "Tarjeta de credito",

            };
            Pagos pago4 = new Pagos()
            {
                FechaPago = new DateTime(2021, 2, 22),
                ValorPago = 75,
                Descuento = true,
                Mora = false,
                TotalAPagar = 40,
                MetodoPago = "Depósito bancario",

            };
            Pagos pago5 = new Pagos()
            {
                FechaPago = new DateTime(2021, 2, 20),
                ValorPago = 83,
                Descuento = false,
                Mora = true,
                TotalAPagar = 92,
                MetodoPago = "Transferencia bancaria",




            };
            List<Pagos> ListaPagos = new List<Pagos>()
            {
                pago1,pago2,pago3,pago4,pago5,
            };

            #endregion
            // --------------------------------------------
            // Penalización
            // --------------------------------------------
            #region
            Penalizacion Pen1 = new Penalizacion()
            {

                NombrePenalizacion = "Penalización leve",
                Descripcion = "Esta penalización se aplica cuando tiene menos de 3 dias de retraso en el pago de su pensión",

            };
            Penalizacion Pen2 = new Penalizacion()
            {

                NombrePenalizacion = "Penalización media",
                Descripcion = "Esta penalización se aplica cuando tiene menos de 6 dias de retraso en el pago de su pensión",

            };
            Penalizacion Pen3 = new Penalizacion()
            {

                NombrePenalizacion = "Penalización Grave",
                Descripcion = "Esta penalización se aplica cuando tiene menos de mas de una semana retraso en el pago de su pensión",

            };
            List<Penalizacion> ListaPenalizacion = new List<Penalizacion>()
            {
                Pen1,Pen2,Pen3
            };

            #endregion





            // --------------------------------------------
            // Diccionario contiene todas las listas
            // --------------------------------------------
            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Periodos, listaPeriodos },
                { ListasTipo.Estudiantes, listaEstudiante },
                { ListasTipo.TiposPagos, listatipospago },
                { ListasTipo.Estados, listaEstados },
                { ListasTipo.Configuraciones, listaConfiguracion },
                { ListasTipo.Pagos, listaEstados },
                { ListasTipo.Penalizaciones, ListaPenalizacion },


            };

            return dicListasDatos;
        }


    }
}