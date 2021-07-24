using System.Collections.Generic;
using Modelo;

namespace Escenarios
{
    public class Escenario
    {
        public enum ListaTipo
        {
            carro,modelo,cliente, configuracion, genero, tipopago, iva, marca, venta
        }
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> datos;

        public Escenario()
        {
            datos = new();
        }
    }
}
