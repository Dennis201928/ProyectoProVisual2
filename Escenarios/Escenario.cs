using System.Collections.Generic;
using Modelo;

namespace Escenarios
{
    public class Escenario
    {
        public enum ListaTipo
        {
            Periodos, Configuracion, Carreras, Estudiantes, Materias, Mallas, Prerequisitos, Cursos, Jornadas
        };
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> datos;

        public Escenario()
        {
            datos = new();
        }
    }
}
