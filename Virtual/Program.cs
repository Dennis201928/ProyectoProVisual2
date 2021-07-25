using System;
using Escenarios;
using System.Linq;
//using Info;
using Modelo;
using Modelo.Escuela;
using Microsoft.EntityFrameworkCore;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            ////
            ///
            var Escenario = new Escenario01();
            var EscenarioControl = new EscenarioControl();
            EscenarioControl.Grabar(Escenario);


            //COMPLETAR

            //var datosMatrículas = new DatosMatrículas();
            //datosMatrículas.Generar();
            //// Regla del negocio: validación de prerequisitos
            //using (var db = new SchoolContext())
            //{
            //    var listaMatriculas = db.matriculas
            //        .Include(matr => matr.Estudiante)
            //        .Where(matr => matr.Estado == "Pendiente")
            //        .ToList();
            //    foreach (var matricula in listaMatriculas)
            //    {
            //        Console.WriteLine(
            //            String.Format(
            //                "  - {0} Matricula Id: {1} Estado: {2}",
            //                matricula.Estudiante.Nombre,
            //                matricula.MatriculaId,
            //                MatriculaProc.MatriculaAprobada(matricula.MatriculaId) ? "Aprobada" : "Rechazada"
            //            )
            //        );
            //    }
            //}
        }


    }
}
