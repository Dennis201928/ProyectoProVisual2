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
           

            var Escenario = new Escenario01();
            var EscenarioControl = new EscenarioControl();
            EscenarioControl.Grabar(Escenario);
            Console.WriteLine("*******************************");
            using (var db = new SchoolContext())
            {
                var blogs = db.Clientes
                    .Where(b => b.clienteId > 3)
                    .OrderBy(b => b.clienteId)
                    .ToList();

                foreach (var venta in blogs)
                {
                    Console.WriteLine(
                    String.Format("ClienteId: {0} \n" +
                          "Nombre: {1} \n" +
                          "Edad: {2} \n" ,
                          //"GeneroId: {3} \n",

                venta.clienteId,
                venta.nombre,
                venta.edad
                 //venta.generoId

                        )
                    );
                }
            }
            
            Console.WriteLine("*******************************");
            using (var db = new SchoolContext())
            {
                var blogs = db.ventas
                    .Where(b => b.clienteId > 3)
                    .OrderBy(b => b.carroId)
                    .ToList();

                foreach (var venta in blogs)
                {
                    Console.WriteLine(
                    String.Format("VentaId: {0} \n" +
                          "ClienteId: {1} \n" +
                          "CarroId: {2} \n" +
                          "Tipo PagoId: {3} \n" +
                          "IvaId: {4} \n" +
                          "Total: {5} \n" +
                          "Estado: {6} \n",

                venta.ventaId,
                venta.clienteId,
                  venta.carroId,
                venta.tipopagoId,
                  venta.ivaId,
                venta.total,
                venta.Estado

                        )
                    );
                }
            }


            


        }


    }
}
