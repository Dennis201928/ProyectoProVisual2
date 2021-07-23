using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escenarios;
using Modelo.Escuela;
using static Escenarios.Escenario;

namespace Virtual
{
    class EscenarioControl
    {
        public void Grabar(IEscenario escenario) {
            var datos = escenario.carga();
            using (var db = new SchoolContext()) {
                //Reiniciamos la Base de datos
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                //Insertamos los datos
                //db.configuracions.AddRange((List<Configuracion>) datos[ListaTipo.Configuracion]);
                //db.estudiantes.AddRange((List<Estudiante>)datos[ListaTipo.Estudiantes]);
                //db.periodos.AddRange((List<Periodo>)datos[ListaTipo.Periodos]);
                //db.carreras.AddRange((List<Carrera>)datos[ListaTipo.Carreras]);
                //db.materias.AddRange((List<Materia>)datos[ListaTipo.Materias]);
                //db.mallas.AddRange((List<Malla>)datos[ListaTipo.Mallas]);
                //db.prerequisitos.AddRange((List<Prerequisito>)datos[ListaTipo.Prerequisitos]);
                //db.cursos.AddRange((List<Curso>)datos[ListaTipo.Cursos]);
                //Genera la persistencia
                db.SaveChanges();
            }
        }
    }
}
