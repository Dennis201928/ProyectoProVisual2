using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escenarios;
using Microsoft.EntityFrameworkCore;
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
                //db.configuracions.AddRange((List<Configuracion>)datos[ListaTipo.configuracion]);

                Console.WriteLine("*****GENERADO CON EXITO*****");
                
                //Genera la persistencia

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException exception)
                {
                    Exception ex = new Exception("Conficto de concurrencia", exception);
                    throw ex;
                }
               
            }
        }
       
    }
}
