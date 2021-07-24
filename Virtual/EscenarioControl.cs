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
                db.carros.AddRange((List<carro>)datos[ListaTipo.carro]);
                db.Clientes.AddRange((List<cliente>)datos[ListaTipo.cliente]);
                db.generos.AddRange((List<genero>)datos[ListaTipo.genero]);
                db.ivas.AddRange((List<iva>)datos[ListaTipo.iva]);
                db.marcas.AddRange((List<marca>)datos[ListaTipo.marca]);
                db.modelos.AddRange((List<modelo>)datos[ListaTipo.modelo]);
                db.tipopagos.AddRange((List<tipopago>)datos[ListaTipo.tipopago]);
                db.ventas.AddRange((List<venta>)datos[ListaTipo.venta]);
                //Genera la persistencia
                db.SaveChanges();
            }
        }
    }
}
