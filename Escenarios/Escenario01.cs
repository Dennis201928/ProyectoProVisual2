using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Escenarios.Escenario;
using Modelo.Escuela;
using Modelo;

namespace Escenarios
{
    public class Escenario01 : Escenario, IEscenario
    {
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> carga()
        {
            //        //Creación de periodos
            //        Periodo per2020_PAO2 = new()
            //        {
            //            Estado = "Cerrado",
            //            FechaInicio = new DateTime(2020, 9, 1),
            //            FechaFin = new DateTime(2021, 3, 1)
            //        };
            //        Periodo per2021_PAO1 = new() { Estado = "Cerrado", FechaInicio = new DateTime(2021, 4, 1), FechaFin = new DateTime(2021, 9, 1) };
            //        Periodo per2021_PAO2 = new() { Estado = "Abierto", FechaInicio = new DateTime(2021, 9, 1), FechaFin = new DateTime(2022, 4, 1) };
            //        List<Periodo> lstPeriodos = new()
            //        {
            //            per2020_PAO2,
            //            per2021_PAO1,
            //            per2021_PAO2
            //        };

            //        datos.Add(ListaTipo.Periodos, lstPeriodos);

            //        //Configuración de los datos de escuela
            //        Configuracion configuracion = new()
            //        {
            //            EscuelaNombre = "Escuela Nacional Quito",
            //            CreditosMaximo = 24,
            //            NotaMinima = 7.00f,
            //            PesoNota1 = 0.35f,
            //            PesoNota2 = 0.35f,
            //            PesoNota3 = 0.30f,
            //            PeriodoVigente = per2021_PAO2
            //        };
            //        List<Configuracion> lstConfiguration = new()
            //        {
            //            configuracion
            //        };
            //        datos.Add(ListaTipo.Configuracion, lstConfiguration);

            //        //Registro de Estudiantes
            //        Estudiante Pedro = new() { Nombre = "Pedro Infante" };
            //        Estudiante Juan = new() { Nombre = "Juan Mora" };
            //        Estudiante Maria = new() { Nombre = "Maria Brito" };
            //        List<Estudiante> lstEstudiante = new()
            //        {
            //            Pedro,
            //            Juan,
            //            Maria
            //        };
            //        datos.Add(ListaTipo.Estudiantes, lstEstudiante);

            //        //Registro de carreras
            //        Carrera carSistemas = new() { Nombre = "Análisis de Sistemas", CostoCredito = 34.50f };
            //        Carrera carComercio = new() { Nombre = "Comercio Electrónico", CostoCredito = 35.12f };
            //        List<Carrera> lstCarreras = new()
            //        {
            //            carSistemas,
            //            carComercio
            //        };
            //        datos.Add(ListaTipo.Carreras, lstCarreras);

            //        //Registro de materias
            //        Materia matDisenio = new Materia() { Area = "Diseño Gráfico", Creditos = 3, Nombre = "Diseño Web" };
            //        Materia matAdminDB = new Materia() { Nombre = "Admin BBDD", Area = "Sistemas", Creditos = 3 };
            //        Materia matLogProg = new Materia() { Nombre = "Lógica de Prog", Area = "Sistemas", Creditos = 3 };
            //        Materia matProdDig = new Materia() { Nombre = "Productos Digitales", Area = "Marketing", Creditos = 2 };
            //        Materia matProgWeb = new Materia() { Nombre = "Programación Web", Area = "Web", Creditos = 3 };
            //        Materia matELearng = new Materia() { Nombre = "E-Learning", Area = "Marketing", Creditos = 2 };
            //        Materia matVideoMk = new Materia() { Nombre = "Video Marketing", Area = "Marketing", Creditos = 3 };
            //        Materia matComuniwe = new Materia() { Nombre = "Comunicacion web", Area = "Web", Creditos = 3 };

            //        List<Materia> lstMaterias = new()
            //        {
            //            matAdminDB,
            //            matDisenio,
            //            matELearng,
            //            matLogProg,
            //            matProdDig,
            //            matProgWeb,
            //            matVideoMk,
            //            matComuniwe
            //        };
            //        datos.Add(ListaTipo.Materias, lstMaterias);
            //        //Registro de mallas
            //        Malla mallaProDig = new() { Carrera = carComercio, Nivel = "3do", Materia = matProdDig };
            //        Malla mallaDisenio = new() { Carrera = carComercio, Nivel = "2do", Materia = matDisenio };
            //        Malla mallaAdminDB = new() { Carrera = carComercio, Nivel = "2do", Materia = matAdminDB };
            //        Malla mallaLogProg = new() { Carrera = carComercio, Nivel = "3ro", Materia = matLogProg };
            //        Malla mallaVideoMk = new() { Carrera = carComercio, Nivel = "3ro", Materia = matVideoMk };
            //        Malla mallaProgWeb = new() { Carrera = carComercio, Nivel = "4ro", Materia = matProgWeb };
            //        Malla mallaELearng = new() { Carrera = carComercio, Nivel = "4ro", Materia = matELearng };
            //        List<Malla> lstMallas = new() { mallaAdminDB, mallaDisenio, mallaELearng, mallaLogProg, mallaProgWeb, mallaVideoMk, mallaProDig };
            //        datos.Add(ListaTipo.Mallas, lstMallas);

            //        //Registro de prerequisitos
            //        Prerequisito preProgWeb_Disenio = new() { Malla = mallaProgWeb, Materia = matDisenio };
            //        Prerequisito preProgWeb_AdminDB = new() { Malla = mallaProgWeb, Materia = matAdminDB };
            //        Prerequisito preProgWeb_LogProg = new() { Malla = mallaProgWeb, Materia = matLogProg };
            //        Prerequisito preELearng_ProdDig = new() { Malla = mallaELearng, Materia = matProdDig };
            //        Prerequisito preELearng_VideoMk = new() { Malla = mallaELearng, Materia = matVideoMk };
            //        Prerequisito preProdDig_ComunWeb = new() { Malla = mallaProDig, Materia = matComuniwe };

            //        List<Prerequisito> lstPrerequisitos = new() { preProgWeb_AdminDB, preProgWeb_Disenio, preProgWeb_LogProg, preELearng_ProdDig, preELearng_VideoMk, preProdDig_ComunWeb };
            //        datos.Add(ListaTipo.Prerequisitos, lstPrerequisitos);
            //        //Registro de las JORNADAS

            //        Curso N2D_2020PAO2_Diseño = new Curso()
            //        {
            //            carrera = carComercio,
            //            Periodo = per2020_PAO2,
            //            Materia = matDisenio,
            //            FechaInicio = new DateTime(2020, 5, 1),
            //            FechaFin = new DateTime(2020, 6, 30),
            //            Jornada = "Diurna",
            //            Nombre = "Nivel 2 Diurna de Diseño Web"
            //        };
            //        Curso N2D_2020PAO2_AdminDB = new Curso()
            //        {
            //            carrera = carComercio,
            //            Periodo = per2020_PAO2,
            //            Materia = matAdminDB,
            //            FechaInicio = new DateTime(2020, 5, 1),
            //            FechaFin = new DateTime(2020, 6, 15),
            //            Jornada = "Diurna",
            //            Nombre = "Nivel 2 Diurna de Administracion DB"
            //        };
            //        Curso N3D_2021PAO1_LogProg = new Curso()
            //        {
            //            carrera = carComercio,
            //            Periodo = per2021_PAO1,
            //            Materia = matLogProg,
            //            FechaInicio = new DateTime(2020, 11, 1),
            //            FechaFin = new DateTime(2021, 1, 15),
            //            Jornada = "Diurna",
            //            Nombre = "Nivel 3 Diurna de Logica de programacion"
            //        };
            //        Curso N3D_2021PAO1_ProDig = new Curso()
            //        {
            //            carrera = carComercio,
            //            Periodo = per2021_PAO1,
            //            Materia = matProdDig,
            //            FechaInicio = new DateTime(2020, 2, 18),
            //            FechaFin = new DateTime(2021, 3, 25),
            //            Jornada = "Diurna",
            //            Nombre = "Nivel 3 Diurna de Productos Digitales"
            //        };
            //        Curso N3D_2021PAO1_VideoMK = new Curso()
            //        {
            //            carrera = carComercio,
            //            Periodo = per2021_PAO1,
            //            Materia = matVideoMk,
            //            FechaInicio = new DateTime(2020, 4, 7),
            //            FechaFin = new DateTime(2021, 6, 8),
            //            Jornada = "Diurna",
            //            Nombre = "Nivel 3 Diurna de Video Marketing"
            //        };
            //        Curso N4D_2021PAO2_ProgWeb = new Curso()
            //        {
            //            carrera = carComercio,
            //            Periodo = per2021_PAO2,
            //            Materia = matProgWeb,
            //            FechaInicio = new DateTime(2020, 11, 1),
            //            FechaFin = new DateTime(2021, 12, 21),
            //            Jornada = "Diurna",
            //            Nombre = "Nivel 4 Diurna de Programacion Web"
            //        };
            //        Curso N4D_2021PAO2_Elearnign = new Curso()
            //        {
            //            carrera = carComercio,
            //            Periodo = per2021_PAO2,
            //            Materia = matELearng,
            //            FechaInicio = new DateTime(2020, 1, 4),
            //            FechaFin = new DateTime(2021, 2, 27),
            //            Jornada = "Diurna",
            //            Nombre = "Nivel 4 Diurna de E-Learning"
            //        };
            //        List<Curso> lstCursos = new List<Curso>()
            //        {
            //            //nivel 2
            //            N2D_2020PAO2_AdminDB, N2D_2020PAO2_Diseño,
            //            //nivel 3
            //            N3D_2021PAO1_LogProg, N3D_2021PAO1_ProDig, N3D_2021PAO1_VideoMK,
            //            //nivel 4
            //            N4D_2021PAO2_Elearnign, N4D_2021PAO2_ProgWeb
            //        };
            //        datos.Add(ListaTipo.Cursos, lstCursos);

            //        //Retorno el diccionario
            //        return datos;
        }
    }
}

















//            Jornada JMatutina = new Jornada()
//            {
//                TipoJornada = "Matutina",
//                dias = "Lunes a Viernes",
//                HoraIncio = "7:00 a.m",
//                HoraFinal = "13:00 p.m"
//            };
//            Jornada JVespertina = new Jornada()
//            {
//                TipoJornada = "Vespertina",
//                dias = "Lunes a Viernes",
//                HoraIncio = "13:00 p.m",
//                HoraFinal = "19:00 p.m"
//            };
//            Jornada JNocturna = new Jornada()
//            {
//                TipoJornada = "Nocturna",
//                dias = "Lunes a Viernes",
//                HoraIncio = "16:30 p.m",
//                HoraFinal = "22:00 p.m"
//            };
//            Jornada JIntensiva = new Jornada()
//            {
//                TipoJornada = "Intensiva",
//                dias = "Lunes a Viernes",
//                HoraIncio = "14:00 p.m",
//                HoraFinal = "16:00 p.m"
//            };
//            Jornada JEjecutiva = new Jornada()
//            {
//                TipoJornada = "Intensiva",
//                dias = "Sabados",
//                HoraIncio = "8:00 a.m",
//                HoraFinal = "16:00 p.m"
//            };
//            List<Jornada> lstJornada = new() { JMatutina, JNocturna, JVespertina, JIntensiva, JEjecutiva };
//            datos.Add(ListaTipo.Jornadas, lstJornada);
//            //Registro de los cursos
//            Curso N2D_2020PAO2_Disenio = new Curso()
//            {
//                Materia = matDisenio,
//                FechaInicio = new DateTime(2020, 5, 1),
//                FechaFin = new DateTime(2020, 6, 30),
//                Jornada = JMatutina,
//                Nombre = "Nivel 2 Diurna de Diseño Web",
//                Periodo = per2020_PAO2
//            };
//            Curso N2D_2020PAO2_AdminDB = new Curso()
//            {
//                Periodo = per2020_PAO2,
//                Materia = matAdminDB,
//                Jornada = JVespertina,
//                Nombre = "Nivel 2 Diurno de Administración BBDD",
//                FechaInicio = new DateTime(2020, 5, 1),
//                FechaFin = new DateTime(2020, 6, 15)
//            };
//            Curso N3D_2021PAO1_LogProg = new Curso()
//            {
//                Periodo = per2021_PAO1,
//                Materia = matLogProg,
//                Jornada = JMatutina,
//                Nombre = "Nivel 3 Diurno de Lógica de Programación",
//                FechaInicio = new DateTime(2020, 11, 1),
//                FechaFin = new DateTime(2021, 1, 30)
//            };
//            Curso N3D_2021PAO1_ProdDig = new Curso()
//            {
//                Periodo = per2021_PAO1,
//                Materia = matProdDig,
//                Jornada = JNocturna,
//                Nombre = "Nivel 3 Diurno de Productos Digitales",
//                FechaInicio = new DateTime(2020, 2, 10),
//                FechaFin = new DateTime(2021, 3, 28)
//            };
//            Curso N3D_2021PAO1_VideoMk = new Curso()
//            {
//                Periodo = per2021_PAO1,
//                Materia = matVideoMk,
//                Jornada = JMatutina,
//                Nombre = "Nivel 3 Diurno de Video Marketing",
//                FechaInicio = new DateTime(2020, 4, 7),
//                FechaFin = new DateTime(2021, 6, 8)
//            };
//            Curso N4D_2021PAO2_ProgWeb = new Curso()
//            {
//                Periodo = per2021_PAO2,
//                Materia = matProgWeb,
//                Jornada = JNocturna,
//                Nombre = "Nivel 4 Diurno de Programación Web",
//                FechaInicio = new DateTime(2021, 11, 1),
//                FechaFin = new DateTime(2021, 12, 21)
//            };
//            Curso N4D_2021PAO2_Elearng = new Curso()
//            {
//                Periodo = per2021_PAO2,
//                Materia = matELearng,
//                Jornada = JIntensiva,
//                Nombre = "Nivel 4 Diurno de E-Learning",
//                FechaInicio = new DateTime(2022, 1, 4),
//                FechaFin = new DateTime(2022, 2, 27)
//            };
//            List<Curso> lstCursos = new() {
//                N2D_2020PAO2_AdminDB, N2D_2020PAO2_Disenio,
//                N3D_2021PAO1_LogProg, N3D_2021PAO1_ProdDig, N3D_2021PAO1_VideoMk,
//                N4D_2021PAO2_Elearng, N4D_2021PAO2_ProgWeb
//            };

//            datos.Add(ListaTipo.Cursos,lstCursos);

//            //Retorno el diccionario
//            return datos;
//        }
//    }
//}
